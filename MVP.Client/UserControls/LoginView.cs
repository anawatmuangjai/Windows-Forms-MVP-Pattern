using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.Client.Views;
using MVP.Client.Presenters;

namespace MVP.Client.UserControls
{
    public partial class LoginView : UserControl, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string Username
        {
            get => UsernameTextBox.Text.Trim();
            set => UsernameTextBox.Text = value;
        }

        public string Password
        {
            get => PasswordTextBox.Text.Trim();
            set => PasswordTextBox.Text = value;
        }

        public string Message
        {
            get => MessageLabel.Text;
            set => MessageLabel.Text = value;
        }

        public bool IsLogin { get; set; }

        public LoginPresenter LoginPresenter { private get; set; }

        public void ShowView()
        {
            Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginPresenter.Login();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
