using MVP.Client.Views;
using MVP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.Presenters
{
    public class ProductPresenter : IProductPresenter
    {
        private readonly IProductView _view;
        private readonly IProductRepository _producRepository;

        public ProductPresenter(IProductView view, IProductRepository producRepository)
        {
            _view = view;
            _producRepository = producRepository;
        }

        public IProductView GetProductView()
        {
            return _view;
        }

        public void ShowProductView()
        {
            _view.ShowView();
        }
    }
}
