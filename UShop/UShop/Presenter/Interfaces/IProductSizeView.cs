﻿using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
    public interface IProductSizeView
    {
        void loadProductSizes(DataTable dt);

    }
}
