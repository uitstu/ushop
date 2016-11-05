using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
    public interface IProductCategoryView
    {
        List<ProductCategory> ProductCategories {set;}
        event EventHandler loadProductCategories;
    }
}
