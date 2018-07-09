﻿using MVP.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.Presenters
{
    public interface IProductPresenter
    {
        IProductView GetProductView();
        void ShowProductView();
    }
}
