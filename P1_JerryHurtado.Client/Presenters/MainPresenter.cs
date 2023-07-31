using P1_JerryHurtado.Client.Views;
using P1_JerryHurtado.Client.Views.Interfaces;

namespace P1_JerryHurtado.Client.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
            _mainView.ShowMainView += ShowMainView;
            _mainView.ShowOrderView += ShowOrderView;
            SetViewInMainPanel();
        }

        #region Event handler methods

        private void ShowMainView(object sender, EventArgs e) => SetViewInMainPanel();

        private void ShowOrderView(object sender, EventArgs e)
        {
            IOrderView view = OrderView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);
            new OrderPresenter(view);
        }

        #endregion Event handler methods

        #region Methods

        private void SetViewInMainPanel() => UserControlMainView.GetInstance(parentContainer: (Panel)_mainView.MainPanel);

        #endregion Methods
    }
}