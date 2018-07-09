using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP.Client.Views;

namespace MVP.Client.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView _mainView;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
        }

        public IMainView GetMainView()
        {
            return _mainView;
        }

        public void ShowMainView()
        {
            _mainView.ShowView();
        }

        public void ShowLoginView()
        {
            throw new NotImplementedException();
        }

    }
}
