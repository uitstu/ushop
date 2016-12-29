using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
    public interface IProductView
    {
        void loadProducts(List<PRODUCT> listObj);
        void loadProductList(DataTable dt);
    }
}
