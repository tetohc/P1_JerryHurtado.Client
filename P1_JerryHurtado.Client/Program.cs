using P1_JerryHurtado.Client.Presenters;
using P1_JerryHurtado.Client.Views;
using P1_JerryHurtado.Client.Views.Interfaces;

namespace P1_JerryHurtado.Client
{
    /*
     * Jerry Alonso Hurtado Castillo
     * Proyecto 1 - 00830 Programación Avanzada
     */

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            IMainView view = new MainView();
            new MainPresenter(view);
            Application.Run((Form)view);
        }
    }
}