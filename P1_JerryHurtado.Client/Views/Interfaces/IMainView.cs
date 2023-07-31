namespace P1_JerryHurtado.Client.Views.Interfaces
{
    /// <summary>
    /// Define las propiedades, eventos y métodos que serán utilizados en la vista.
    /// </summary>
    public interface IMainView
    {
        #region Properties

        Panel MainPanel { get; }

        #endregion Properties

        #region Events

        event EventHandler ShowMainView;

        event EventHandler ShowOrderView;

        #endregion Events
    }
}