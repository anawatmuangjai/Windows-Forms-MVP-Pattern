using MVP.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.Presenters
{
    public interface IMainPresenter
    {
        IMainView GetMainView();
        void ShowMainView();
        void ShowLoginView();
    }
}
