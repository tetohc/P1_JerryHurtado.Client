using P1_JerryHurtado.Client.Helpers;
using P1_JerryHurtado.Client.Models.Entities;
using P1_JerryHurtado.Client.Models.Enum;
using P1_JerryHurtado.Client.Models.ViewModels;
using P1_JerryHurtado.Client.Views.Interfaces;

namespace P1_JerryHurtado.Client.Presenters
{
    public class OrderPresenter
    {
        private IOrderView _view;
        private BindingSource _orderBindingSource;
        private BindingSource _dishBindingSource;
        private BindingSource _extraBindingSource;

        public OrderPresenter(IOrderView view)
        {
            _view = view;
            _dishBindingSource = new BindingSource();
            _extraBindingSource = new BindingSource();
            _orderBindingSource = new BindingSource();

            #region suscripction events

            _view.ConnectToServerEvent += ConnectToServerEvent;
            _view.DisconnectFromServerEvent += DisconnectFromServerEvent;
            _view.SearchEvent += SearchEvent;
            _view.AddNewEvent += AddNewEvent;
            _view.CancelEvent += CancelEvent;
            _view.LoadRestaurantDataEvent += LoadRestaurantDataEvent;
            _view.ChangeCategoryEvent += ChangeCategoryEvent;
            _view.PrepareOrderEvent += PrepareOrderEvent;
            _view.SendOrderEvent += SendOrderEvent;

            #endregion suscripction events

            _view.SetOrderBindingSource(_orderBindingSource);
            _view.SetDishBindingSource(_dishBindingSource);
            _view.SetExtraBindingSource(_extraBindingSource);
            _view.Show();
        }

        #region Event handler methods

        private void SearchEvent(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_view.SearchValue))
                {
                    var isInteger = int.TryParse(_view.SearchValue.Trim(), out _);
                    if (!isInteger)
                        throw new Exception(message: "- El Id de pedido debe ser un número entero.");
                    var orders = GetCustomerOrdersByValue(Convert.ToInt32(_view.SearchValue.Trim()));
                    _orderBindingSource.DataSource = orders;
                }
                else
                    LoadCustomerOrders();

                _view.IsSuccessful = true;
                _view.SearchValue = string.Empty;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        #region Connect and disconnect from the server

        private void ConnectToServerEvent(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_view.CustomerId))
                    throw new Exception(message: "El identificador es requerido.");

                var result = TcpClientService.ConnectToServer(customerId: _view.CustomerId.Trim());
                if (!result.IsSuccessful)
                    throw new Exception(message: result.Messages);

                _view.IsConnectedServer = true;
                LoadCustomerOrders();

                _view.IsSuccessful = true;
                _view.Message = "La conexión con el servidor se ha establecido correctamente.";
                _view.ConnectionStatus = "Conectado al servidor en (127.0.0.1, 14100) ...";
                _view.CustomerName = result.Messages;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void DisconnectFromServerEvent(object sender, EventArgs e)
        {
            try
            {
                bool result = TcpClientService.DisconnectFromServer(customerId: _view.CustomerId?.Trim());
                if (!result)
                    throw new Exception(message: Messages.ConnectionError.GetDisplayName());

                _view.CustomerName = "Info cliente";
                _view.ConnectionStatus = "Desconectado";
                _view.Message = "La conexión con el servidor se ha cerrado correctamente";
                _view.IsSuccessful = true;
                _view.IsConnectedServer = false;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.IsConnectedServer = false;
                _view.Message = ex.Message;
            }
        }

        #endregion Connect and disconnect from the server

        private void AddNewEvent(object sender, EventArgs e)
        {
            try
            {
                var restaurantSelectList = new List<SelectListViewModel>();
                var list = TcpClientService.GetRestaurantSelectList(_view.CustomerId);
                if (list.Count() > 0)
                {
                    restaurantSelectList.AddRange(list);
                    _view.EnableBtnSelectRestaurant();
                }
                else
                {
                    restaurantSelectList.Add(new SelectListViewModel { Id = -1, Name = Messages.DataEmpty.GetDisplayName() });
                    _view.DisableBtnSelectRestaurant();
                }

                _view.SetRestaurantSelectList(restaurantSelectList);
                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        #region Orders

        /// <summary>
        /// Prepara el pedido de platos y/o extras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrepareOrderEvent(object sender, EventArgs e)
        {
            try
            {
                var order = new CreateOrderViewModel();
                if (_view.SelectedDishList.Count() == 0)
                    throw new Exception(message: "Debe seleccionar al menos un plato.");

                foreach (var dish in _view.SelectedDishList)
                {
                    var model = new Order();
                    model.CustomerId = _view.CustomerId;
                    model.DishId = dish.Id;
                    order.Order.Add(model);

                    foreach (var extra in _view.SelectedExtraList)
                    {
                        if (!order.ExtraOrder.Any(x => x.DishId == dish.Id && x.ExtraId == extra.Id))
                            order.ExtraOrder.Add(new ExtraOrder()
                            {
                                DishId = dish.Id,
                                ExtraId = extra.Id,
                            });
                    }
                }

                string orderDetail = "- DETALLE DE PEDIDO -\n\n * Platos seleccionados *\n";
                int dishTotal = 0;
                int extraTotal = 0;
                foreach (var item in order.Order)
                {
                    var currentDish = _view.SelectedDishList.FirstOrDefault(x => x.Id == item.DishId);
                    orderDetail += $"- Id: {currentDish.Id}\t {currentDish.Name}\t Precio: ${currentDish.Price}\n";
                    dishTotal += currentDish.Price;
                }

                if (_view.SelectedExtraList.Count() > 0)
                {
                    orderDetail += "\n\n* Extras seleccionadas *\n";
                    foreach (var item in order.ExtraOrder)
                    {
                        var currentExtra = _view.SelectedExtraList.FirstOrDefault(x => x.Id == item.ExtraId);
                        orderDetail += $"- Id: {currentExtra.Id}\t {currentExtra.Description}\t Precio: ${currentExtra.Price}\n";
                        extraTotal += currentExtra.Price;
                    }
                }

                orderDetail += $"\n\n* Total de pedido *\n -Platos: ${dishTotal} \n-Extras: ${extraTotal} \n-Total: ${dishTotal + extraTotal}";
                _view.IsSuccessful = true;
                _view.OrderPrepared = order;
                _view.Message = orderDetail;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        /// <summary>
        /// Envía el pedido al servidor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendOrderEvent(object sender, EventArgs e)
        {
            try
            {
                if (_view.OrderPrepared == null)
                    throw new Exception(message: "Hubo un error y el pedido no se ha podido enviar al servidor.");

                var result = TcpClientService.AddOrder(customerId: _view.CustomerId.Trim(), _view.OrderPrepared);
                if (!result.IsSuccessful)
                    throw new Exception(message: result.Messages);

                _view.IsSuccessful = true;
                _view.Message = Messages.Success.GetDisplayName();
                _view.SelectedDishList.Clear();
                _view.SelectedExtraList.Clear();
                LoadCustomerOrders();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        #endregion Orders

        private void CancelEvent(object sender, EventArgs e) => CleanViewFields();

        private void LoadRestaurantDataEvent(object sender, EventArgs e) => LoadDataRestaurant();

        /// <summary>
        /// Filtra los datos por id de categoria seleccionada el combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeCategoryEvent(object sender, EventArgs e)
        {
            try
            {
                if (_view.ComboBoxCategories.Items.Count > 0)
                {
                    int categoryId = _view.CategoryId;
                    if (categoryId == (int)Filter.All)
                    {
                        _dishBindingSource.DataSource = _view.DishList;
                        _extraBindingSource.DataSource = _view.ExtraList;
                    }
                    else
                    {
                        _dishBindingSource.DataSource = _view.DishList.Where(x => x.CategoryId == categoryId); ;
                        _extraBindingSource.DataSource = _view.ExtraList.Where(x => x.CategoryId == categoryId); ;
                    }

                    _view.SetDishBindingSource(_dishBindingSource);
                    _view.SetExtraBindingSource(_extraBindingSource);

                    _view.SelectedDishList.Clear();
                    _view.SelectedExtraList.Clear();
                    _view.IsSuccessful = true;
                }
            }
            catch (Exception)
            {
                _view.IsSuccessful = false;
                _view.Message = "Algunos datos no están disponibles para la categoría seleccionada.";
            }
        }

        #endregion Event handler methods

        #region Methods

        /// <summary>
        /// Carga los pedidos realizados por el cliente.
        /// </summary>
        private void LoadCustomerOrders()
        {
            try
            {
                if (_view.IsConnectedServer)
                {
                    var orderList = TcpClientService.GetOrdersByCustomer(customerId: _view.CustomerId.Trim());
                    _orderBindingSource.DataSource = orderList;
                }
            }
            catch (Exception)
            {
                throw new Exception(message: "Ha ocurrido un error, no se pudo obtener la información de pedidos.");
            }
        }

        /// <summary>
        /// Carga los pedidos realizados por el cliente filtrados por id.
        /// </summary>
        /// <param name="orderId"></param>
        /// <exception cref="Exception"></exception>
        private IEnumerable<OrderViewModel> GetCustomerOrdersByValue(int orderId)
        {
            try
            {
                var orderList = new List<OrderViewModel>();
                if (_view.IsConnectedServer)
                {
                    var list = TcpClientService.GetOrdersByCustomer(customerId: _view.CustomerId.Trim());
                    orderList = list.Where(x => x.Id == orderId).ToList();
                    return orderList;
                }
                return orderList;
            }
            catch (Exception)
            {
                throw new Exception(message: "Ha ocurrido un error, no se pudo obtener la información de pedidos.");
            }
        }

        /// <summary>
        /// Carga los datos del restaurante seleccionado, necesarios para realizar un pedido.
        /// </summary>
        private void LoadDataRestaurant()
        {
            try
            {
                _view.DishList.Clear();
                _view.ExtraList.Clear();
                var model = TcpClientService.GetRestaurantData(_view.RestaurantId, _view.CustomerId.Trim());

                #region Load categories

                var categoriesSelectList = new List<SelectListViewModel>();
                var categories = TcpClientService.GetCategoriesSelectList(_view.RestaurantId, _view.CustomerId.Trim());
                if (categories.Count() > 0)
                {
                    categoriesSelectList.AddRange(categories);
                }
                else
                    categoriesSelectList.Add(new SelectListViewModel { Id = -1, Name = Messages.DataEmpty.GetDisplayName() });
                _view.SetCategorySelectList(categoriesSelectList);

                #endregion Load categories

                #region Load dishes

                _view.DishList = model.Dish.ToList();
                _dishBindingSource.DataSource = _view.DishList;
                _view.SetDishBindingSource(_dishBindingSource);

                #endregion Load dishes

                #region Load extras

                _view.ExtraList = model.Extra.ToList();
                _extraBindingSource.DataSource = _view.ExtraList;
                _view.SetExtraBindingSource(_extraBindingSource);

                #endregion Load extras

                _view.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            _view.SelectedDishList.Clear();
            _view.SelectedExtraList.Clear();
            _view.SearchValue = string.Empty;
        }

        #endregion Methods
    }
}