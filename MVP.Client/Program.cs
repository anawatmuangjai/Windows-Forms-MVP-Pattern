using MVP.Client.Container;
using MVP.Client.Forms;
using MVP.Client.IoCContainer;
using MVP.Client.Presenters;
using MVP.Client.Views;
using MVP.Infrastructure.Context;
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

            //var mvpContext = new MvpDbContext();
            //var userRepository = new UserRepository(mvpContext);
            //var loginView = new LoginForm();
            //var loginPresenter = new LoginPresenter(loginView, userRepository);

            // Autoface
            //IoC.Initialize(AutofacConfig.RegisterComponents());
            //var loginView = IoC.Resolve<LoginForm>();

            IoCFactory.Initialize(new NinjectConfig());

            var loginPresenter = IoCFactory.Get<LoginPresenter>();
            var loginView = loginPresenter.GetLoginView();

            Application.Run((LoginForm)loginView);
        }
    }
}
