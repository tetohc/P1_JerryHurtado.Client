using Newtonsoft.Json;
using P1_JerryHurtado.Client.Models._Socket;
using P1_JerryHurtado.Client.Models.Enum;
using P1_JerryHurtado.Client.Models.ViewModels;
using System.Net;
using System.Net.Sockets;

namespace P1_JerryHurtado.Client.Helpers
{
    /// <summary>
    /// Gestiona la comunicación del cliente con el servidor.
    /// </summary>
    public class TcpClientService
    {
        #region Properties

        private static IPAddress _ipServer;
        private static TcpClient _tcpClient;
        private static IPEndPoint _serverEndPoint;
        private static StreamWriter _clientStreamWriter;
        private static StreamReader _clientStreamReader;

        #endregion Properties

        #region Connect and disconnect from the server

        /// <summary>
        /// Envia una petición al servidor para establecer una conexión.
        /// </summary>
        /// <param name="customerId">Id de usuario.</param>
        /// <returns></returns>
        public static ServerConnectionResponseViewModel ConnectToServer(string customerId)
        {
            try
            {
                _ipServer = IPAddress.Parse("127.0.0.1");
                _tcpClient = new TcpClient();
                _serverEndPoint = new IPEndPoint(_ipServer, 14100);
                _tcpClient.Connect(_serverEndPoint);
                ClientRequest<string> request = new ClientRequest<string> { TypeRequest = (int)Request.ConnectToServer, UserId = customerId };

                _clientStreamReader = new StreamReader(_tcpClient.GetStream());
                _clientStreamWriter = new StreamWriter(_tcpClient.GetStream());
                _clientStreamWriter.WriteLine(JsonConvert.SerializeObject(request));
                _clientStreamWriter.Flush();

                var result = _clientStreamReader.ReadLine();
                var response = JsonConvert.DeserializeObject<ServerConnectionResponseViewModel>(result);
                return response;
            }
            catch (SocketException)
            {
                return new ServerConnectionResponseViewModel() { IsSuccessful = false, Messages = Messages.ConnectionError.GetDisplayName() };
            }
        }

        /// <summary>
        /// Cierra la conexión con el servidor, antes informa al servidor.
        /// </summary>
        /// <param name="customerId">Id de usuario</param>
        /// <returns></returns>
        public static bool DisconnectFromServer(string customerId)
        {
            try
            {
                ClientRequest<string> request = new ClientRequest<string> { TypeRequest = (int)Request.DisconnectFromServer, UserId = customerId };
                _clientStreamWriter.WriteLine(JsonConvert.SerializeObject(request));
                _clientStreamWriter.Flush();
                _tcpClient.Close();
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        #endregion Connect and disconnect from the server

        #region Get restaurants

        /// <summary>
        /// Realiza una petición al servidor para obtener el listado de restaurantes activos.
        /// </summary>
        /// <param name="customerId">Id de usuario.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static IEnumerable<SelectListViewModel> GetRestaurantSelectList(string customerId)
        {
            try
            {
                ClientRequest<string> request = new ClientRequest<string> { TypeRequest = (int)Request.GetRestaurantSelectList, UserId = customerId };
                _clientStreamWriter.WriteLine(JsonConvert.SerializeObject(request));
                _clientStreamWriter.Flush();

                var result = _clientStreamReader.ReadLine();
                var restaurantList = JsonConvert.DeserializeObject<IEnumerable<SelectListViewModel>>(result);
                return restaurantList;
            }
            catch (Exception)
            {
                throw new Exception(message: Messages.BadRequest.GetDisplayName());
            }
        }

        /// <summary>
        /// Realiza una petición al servidor para obtener el listado de categorías asociado a los platos del restaurante seleccionado.
        /// </summary>
        /// <param name="restaurantId">Id de restaurante.</param>
        /// <param name="customerId">Id de usuario.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static IEnumerable<SelectListViewModel> GetCategoriesSelectList(int restaurantId, string customerId)
        {
            try
            {
                ClientRequest<int> request = new ClientRequest<int> { TypeRequest = (int)Request.GetCategoriesSelectList, UserId = customerId, Data = restaurantId };
                _clientStreamWriter.WriteLine(JsonConvert.SerializeObject(request));
                _clientStreamWriter.Flush();

                var result = _clientStreamReader.ReadLine();
                var categoryList = JsonConvert.DeserializeObject<IEnumerable<SelectListViewModel>>(result);
                return categoryList;
            }
            catch (Exception)
            {
                throw new Exception(message: Messages.BadRequest.GetDisplayName());
            }
        }

        /// <summary>
        /// Realiza una petición al servidor para obtener la información del restaurante necesaria para preparar un pedido.
        /// </summary>
        /// <param name="restaurantId">Id de restaurante.</param>
        /// <param name="customerId">Id de usuario.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DishRestaurantDetailViewModel GetRestaurantData(int restaurantId, string customerId)
        {
            try
            {
                ClientRequest<int> request = new ClientRequest<int> { TypeRequest = (int)Request.GetRestaurantData, UserId = customerId, Data = restaurantId };
                _clientStreamWriter.WriteLine(JsonConvert.SerializeObject(request));
                _clientStreamWriter.Flush();

                var result = _clientStreamReader.ReadLine();
                var model = JsonConvert.DeserializeObject<DishRestaurantDetailViewModel>(result);
                return model;
            }
            catch (Exception)
            {
                throw new Exception(message: Messages.BadRequest.GetDisplayName());
            }
        }

        #endregion Get restaurants

        #region Orders

        /// <summary>
        /// Solicita al servidos el listado de pedidos realizados por el cliente.
        /// </summary>
        /// <param name="customerId">Id de usuario.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static IEnumerable<OrderViewModel> GetOrdersByCustomer(string customerId)
        {
            try
            {
                ClientRequest<string> request = new ClientRequest<string> { TypeRequest = (int)Request.ListOrdersByClient, UserId = customerId };
                _clientStreamWriter.WriteLine(JsonConvert.SerializeObject(request));
                _clientStreamWriter.Flush();

                var result = _clientStreamReader.ReadLine();
                var model = JsonConvert.DeserializeObject<IEnumerable<OrderViewModel>>(result);
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Realiza una petición al servidor para agregar pedidos.
        /// </summary>
        /// <param name="customerId">Id de usuario.</param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static ServerConnectionResponseViewModel AddOrder(string customerId, CreateOrderViewModel model)
        {
            try
            {
                ClientRequest<CreateOrderViewModel> request = new ClientRequest<CreateOrderViewModel> { TypeRequest = (int)Request.AddDishOrder, UserId = customerId, Data = model };
                _clientStreamWriter.WriteLine(JsonConvert.SerializeObject(request));
                _clientStreamWriter.Flush();

                var result = _clientStreamReader.ReadLine();
                var response = JsonConvert.DeserializeObject<ServerConnectionResponseViewModel>(result);
                return response;
            }
            catch (Exception)
            {
                return new ServerConnectionResponseViewModel() { IsSuccessful = false, Messages = "Hubo un error, no se pudo realizar el pedido." };
            }
        }

        #endregion Orders
    }
}