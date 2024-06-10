using BarcodeCaseA.Model;
using BarcodeCaseA.Presenter;
using BarcodeCaseA.Repository;
using BarcodeCaseA.View;

namespace BarcodeCaseA
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm());

            ApplicationConfiguration.Initialize();
            ILoginView view = new LoginView();
            ILoginRepository repository = new LoginRepository();
            new LoginPresenter(view, repository);
            Application.Run((Form)view);
        }
    }
}