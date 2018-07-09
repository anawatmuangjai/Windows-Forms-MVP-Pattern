using MVP.Client.Container;
using MVP.Client.Presenters;
using MVP.Client.UserControls;
using MVP.Client.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Client.Forms
{
    public partial class MainForm : Form, IMainView
    {
        public MainPresenter MainPresenter { private get; set; }

        public MainForm()
        {
            InitializeComponent();
        }
        
        public void ShowView()
        {
            this.Show();
        }

        private void DisplayView(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
        }

        private void ProductMenuButton_Click(object sender, EventArgs e)
        {
            var productPresenter = IoC.Get<ProductPresenter>();
            DisplayView((UserControl)productPresenter.GetProductView());
        }

        private void LoginMenuButton_Click(object sender, EventArgs e)
        {
            var loginPresenter = IoC.Get<LoginPresenter>();
            DisplayView((UserControl)loginPresenter.GetLoginView());
        }
    }
}
