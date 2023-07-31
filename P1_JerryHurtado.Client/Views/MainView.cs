using P1_JerryHurtado.Client.Views.Interfaces;

namespace P1_JerryHurtado.Client.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        #region Properties

        public Panel MainPanel { get => mainPanel; }

        #endregion Properties

        #region Events

        public event EventHandler ShowMainView;

        public event EventHandler ShowOrderView;

        #endregion Events

        #region Methods

        private void AssociateAndRaiseViewEvents()
        {
            btnHome.Click += delegate { ShowMainView?.Invoke(this, EventArgs.Empty); };
            btnOrder.Click += delegate { ShowOrderView?.Invoke(this, EventArgs.Empty); };
        }

        #endregion Methods
    }
}