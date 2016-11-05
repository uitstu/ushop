using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class ProductCategoryModel : IModel, IProductCategory
    {
        public UShopDBDataContext UShopDB
        {
            get { return new UShopDBDataContext(); }
        }

        public List<Model.ProductCategory> loadProductCategory()
        {
            return UShopDB.ProductCategories.ToList();
        }
    }
}
