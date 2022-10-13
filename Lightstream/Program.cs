using Lightstream.Forms;

namespace Lightstream

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            ApplicationConfiguration.Initialize();
            bool loggedOut = false;

            //do
            //{
            //    loggedOut = false;
            //    var login = new LoginForm();
            //    Application.Run(login);
            //    if (login.IsLoginSuccessful)
            //    {
            //        var main = new Main();
            //        Application.Run(main);
            //        loggedOut = main.IsLoggedOut;
            //    }
            //} while (loggedOut);

            Application.Run(new ProductForm());
        }
    }
}