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

            do
            {
                loggedOut = false;
                var login = new LoginForm();
                Application.Run(login);
                if (login.IsLoginSuccessful)
                {
                    Form form = login.CurrentLogin.UserType == (int)UserType.admin ?
                         new Main() : new FPOS();
                    
                    Application.Run(form);

                    if (form is ILogoutForm f)
                        loggedOut = f.IsLoggedout;
                }
            } while (loggedOut);

            //Application.Run(new ProductForm());
        }
    }
}