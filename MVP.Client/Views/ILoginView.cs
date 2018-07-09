using MVP.Client.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.Views
{
    public interface ILoginView
    {
        LoginPresenter LoginPresenter { set; }
        string Username { get; set; }
        string Password { get; set; }
        string Message { get; set; }
        bool IsLogin { get; set; }
        void ShowView();
    }
}
