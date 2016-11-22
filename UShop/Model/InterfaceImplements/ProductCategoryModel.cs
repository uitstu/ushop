using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class ProductCategoryModel : DataModel, IProductCategory
    {

        public List<Model.ProductCategory> loadProductCategory()
        {
            return UShopDB.ProductCategories.ToList();
        }


        public void addProductCategory(ProductCategory obj)
        {
            try
            {
                UShopDB.ProductCategories.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }
    }
}
