using MVP.Client.Container;
using MVP.Client.Forms;
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

            IoC.Initialize(new IoCConfiguration());
            var mainPresenter = IoC.Get<MainPresenter>();
            var mainView = mainPresenter.GetMainView();

            Application.Run((MainForm)mainView);
        }
    }
}
