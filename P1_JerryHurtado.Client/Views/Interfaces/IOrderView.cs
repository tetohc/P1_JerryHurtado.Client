using P1_JerryHurtado.Client.Models.ViewModels;

namespace P1_JerryHurtado.Client.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que serán utilizados en la vista.
    /// </summary>
    public interface IOrderView
    {
        #region Properties

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ConnectionStatus { get; set; }
        public string SearchValue { get; set; }
        public int RestaurantId { get; set; }
        public int CategoryId { get; set; }
        public CreateOrderViewModel OrderPrepared { get; set; }
        List<DishViewModel> DishList { get; set; }
        List<ExtraViewModel> ExtraList { get; set; }
        List<DishViewModel> SelectedDishList { get; set; }
        List<ExtraViewModel> SelectedExtraList { get; set; }
        bool IsSuccessful { get; set; }

        bool IsConnectedServer { get; set; }

        string Message { get; set; }
        public ComboBox ComboBoxCategories { get; }

        #endregion Properties

        #region Events

        event EventHandler ConnectToServerEvent;

        event EventHandler DisconnectFromServerEvent;

        event EventHandler AddNewEvent;

        event EventHandler CancelEvent;

        event EventHandler LoadRestaurantDataEvent;

        event EventHandler LoadRestaurantSelectListEvent;

        event EventHandler ChangeCategoryEvent;

        event EventHandler PrepareOrderEvent;

        event EventHandler SendOrderEvent;

        event EventHandler SearchEvent;

        #endregion Events

        #region Methods

        void SetOrderBindingSource(BindingSource orderList);

        void SetDishBindingSource(BindingSource dishList);

        void SetExtraBindingSource(BindingSource dishList);

        void SetRestaurantSelectList(IEnumerable<SelectListViewModel> restaurants);

        void SetCategorySelectList(IEnumerable<SelectListViewModel> categories);

        void DisableBtnSelectRestaurant();

        void EnableBtnSelectRestaurant();

        void Show();

        #endregion Methods
    }
}