using P1_JerryHurtado.Client.Models.ViewModels;
using P1_JerryHurtado.Client.Views.Interfaces;
using P1_JerryHurtado.Client.Views.Utilities;

namespace P1_JerryHurtado.Client.Views
{
    public partial class OrderView : Form, IOrderView
    {
        private string _message;
        private bool _isSuccessful;
        private bool _isConnectedServer;
        private List<DishViewModel> _dishList;
        private List<ExtraViewModel> _extrahList;
        private CreateOrderViewModel _orderPrepared;

        public OrderView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            _dishList = new List<DishViewModel>();
            _extrahList = new List<ExtraViewModel>();
            _orderPrepared = new CreateOrderViewModel();
            DisconnectedFromServer();
            tabControlOrder.TabPages.Remove(tabPageOrderAddNew);
        }

        #region Properties

        public string CustomerId { get => textBoxCustomerId.Text; set => textBoxCustomerId.Text = value; }

        public string CustomerName { get => labelCustomerName.Text; set => labelCustomerName.Text = value; }
        public string ConnectionStatus { get => labelConnectionStatus.Text; set => labelConnectionStatus.Text = value; }
        public string SearchValue { get => textBoxSearch.Text; set => textBoxSearch.Text = value; }
        public int RestaurantId { get => Convert.ToInt32(comboBoxRestaurant.SelectedValue); set => RestaurantId = value; }
        public int CategoryId { get => Convert.ToInt32(comboBoxDishCategory.SelectedValue); set => CategoryId = value; }
        public CreateOrderViewModel OrderPrepared { get => _orderPrepared; set => _orderPrepared = value; }
        public List<DishViewModel> DishList { get => _dishList; set => _dishList = value; }
        public List<ExtraViewModel> ExtraList { get => _extrahList; set => _extrahList = value; }
        public bool IsSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public bool IsConnectedServer { get => _isConnectedServer; set => _isConnectedServer = value; }
        public string Message { get => _message; set => _message = value; }
        public ComboBox ComboBoxCategories => comboBoxDishCategory;

        public List<DishViewModel> SelectedDishList
        {
            get => dataGridViewDishList?.Rows?.Cast<DataGridViewRow>()?.Where(x => x.Selected)?.Select(x => (DishViewModel)x?.DataBoundItem)?.ToList();
            set => SelectedDishList = value;
        }

        public List<ExtraViewModel> SelectedExtraList
        {
            get => dataGridViewExtraList?.Rows?.Cast<DataGridViewRow>()?.Where(x => x.Selected)?.Select(x => (ExtraViewModel)x?.DataBoundItem)?.ToList();
            set => SelectedExtraList = value;
        }

        #endregion Properties

        #region Events

        public event EventHandler ConnectToServerEvent;

        public event EventHandler DisconnectFromServerEvent;

        public event EventHandler AddNewEvent;

        public event EventHandler CancelEvent;

        public event EventHandler LoadRestaurantDataEvent;

        public event EventHandler LoadRestaurantSelectListEvent;

        public event EventHandler ChangeCategoryEvent;

        public event EventHandler PrepareOrderEvent;

        public event EventHandler SendOrderEvent;

        public event EventHandler SearchEvent;

        #endregion Events

        #region Methods

        private void AssociateAndRaiseViewEvents()
        {
            btnConnect.Click += delegate
            {
                ConnectToServerEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                    EstablishedServerConnection();
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnDisconnect.Click += delegate
            {
                DisconnectFromServerEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    DisconnectedFromServer();
                    tabControlOrder.TabPages.Remove(tabPageOrderAddNew);
                    tabControlOrder.TabPages.Remove(tabPageOrderList);
                    tabControlOrder.TabPages.Add(tabPageOrderList);
                }
                CustomerName = "Info cliente";
                ConnectionStatus = "Desconectado";
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnSearch.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            textBoxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                    if (!IsSuccessful)
                        Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
                }
            };

            btnAddNewOrder.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
                else
                {
                    tabControlOrder.TabPages.Remove(tabPageOrderList);
                    tabControlOrder.TabPages.Add(tabPageOrderAddNew);
                    comboBoxRestaurant.SelectedIndex = 0;
                }
            };

            btnSelectRestaurant.Click += delegate
            {
                LoadRestaurantDataEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            comboBoxDishCategory.SelectionChangeCommitted += delegate
            {
                ChangeCategoryEvent?.Invoke(this, EventArgs.Empty);
                if (!IsSuccessful)
                    Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
            };

            btnPrepareOrder.Click += delegate
            {
                if (dataGridViewDishList.Rows.Count == 0)
                    Result.ShowResponse(message: "- Debe seleccionar al menos un plato para preparar el pedido.", isSuccessful: false);
                else
                {
                    PrepareOrderEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful)
                    {
                        btnPrepareOrder.Enabled = false;
                        btnSendOrder.Enabled = true;
                        MessageBox.Show(Message, "Pedido preparado - Habilitado 'Realizar pedido'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SelectedDishList.Clear();
                        SelectedExtraList.Clear();
                        Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
                    }
                }
            };

            btnSendOrder.Click += delegate
            {
                SendOrderEvent?.Invoke(this, EventArgs.Empty);
                Result.ShowResponse(message: Message, isSuccessful: IsSuccessful);
                if (!IsSuccessful)
                {
                    btnSendOrder.Enabled = false;
                    btnPrepareOrder.Enabled = true;
                    SelectedDishList.Clear();
                    SelectedExtraList.Clear();
                }
                else
                {
                    tabControlOrder.TabPages.Add(tabPageOrderList);
                    tabControlOrder.TabPages.Remove(tabPageOrderAddNew);
                    comboBoxRestaurant.SelectedIndex = 0;
                }
            };

            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControlOrder.TabPages.Remove(tabPageOrderAddNew);
                tabControlOrder.TabPages.Add(tabPageOrderList);
                btnPrepareOrder.Enabled = true;
                btnSendOrder.Enabled = false;
                comboBoxRestaurant.SelectedIndex = 0;
            };
        }

        #region Load datagridview

        public void SetDishBindingSource(BindingSource dishList) => dataGridViewDishList.DataSource = dishList;

        public void SetOrderBindingSource(BindingSource orderList) => dataGridViewOrder.DataSource = orderList;

        public void SetExtraBindingSource(BindingSource extraList)
        {
            dataGridViewExtraList.DataSource = extraList;
            dataGridViewExtraList?.ClearSelection();
        }

        #endregion Load datagridview

        #region Load combobox

        public void SetRestaurantSelectList(IEnumerable<SelectListViewModel> restaurants)
        {
            comboBoxRestaurant.DataSource = restaurants;
            comboBoxRestaurant.ValueMember = "Id";
            comboBoxRestaurant.DisplayMember = "Name";
        }

        public void SetCategorySelectList(IEnumerable<SelectListViewModel> categories)
        {
            comboBoxDishCategory.DataSource = categories;
            comboBoxDishCategory.ValueMember = "Id";
            comboBoxDishCategory.DisplayMember = "Name";
        }

        #endregion Load combobox

        #region Enable and disable

        private void EstablishedServerConnection()
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            btnAddNewOrder.Enabled = true;
            textBoxCustomerId.Enabled = false;

            if (dataGridViewOrder.Rows.Count > 1)
            {
                btnSearch.Enabled = true;
                textBoxSearch.Enabled = true;
            }
        }

        private void DisconnectedFromServer()
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnAddNewOrder.Enabled = false;
            btnSearch.Enabled = false;
            btnSendOrder.Enabled = false;
            textBoxCustomerId.Text = string.Empty;
            textBoxCustomerId.Enabled = true;
            textBoxSearch.Enabled = false;
        }

        public void DisableBtnSelectRestaurant() => btnSelectRestaurant.Enabled = false;

        public void EnableBtnSelectRestaurant() => btnSelectRestaurant.Enabled = true;

        #endregion Enable and disable

        public static OrderView GetInstance(Panel parentContainer)
        {
            var instance = new OrderView();
            instance.TopLevel = false;
            instance.FormBorderStyle = FormBorderStyle.None;
            instance.Dock = DockStyle.Fill;
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(instance);
            return instance;
        }

        #endregion Methods
    }
}