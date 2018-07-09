using MVP.Client.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.Views
{
    public interface IProductView
    {
        ProductPresenter ProductPresenter { set; }
        void ShowView();
    }
}
