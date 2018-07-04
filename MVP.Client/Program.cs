using MVP.Client.Forms;
using MVP.Client.Presenters;
using MVP.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginView = new LoginForm();
            var userRepository = new UserRepository();
            var loginPresenter = new LoginPresenter(loginView, userRepository);

            Application.Run(loginView);
        }
    }
}
