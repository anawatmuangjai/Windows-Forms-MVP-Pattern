using Autofac;
using MVP.Client.Container;
using MVP.Client.IoCContainer;
using MVP.Client.Presenters;
using MVP.Client.Views;
using MVP.Core.Entities;
using MVP.Infrastructure.Repository;
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
    public partial class LoginForm : Form, ILoginView
    {      
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

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginPresenter.Login();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowView()
        {
            this.Show();
        }
    }
}
