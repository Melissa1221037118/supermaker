using supermarket.Views;
using supermarket.Models;
using supermarket.Repositories;
using supermarket.Properties;
using supermarket.Presenters;

namespace supermarket
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string sqlConnection = Settings.Default.SqlConnection;
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnection);
            new PayModePresenter(view, repository);
            Application.Run((Form) view );
        }
    }
}