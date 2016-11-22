using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class CategoryModel : DataModel, ICategory
    {
        public List<Model.Category> loadCategory()
        {
            return UShopDB.Categories.ToList();
        }

        public void addCategory(Category obj)
        {
            try
            {
                UShopDB.Categories.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }


        public void deleteCategory(string id)
        {
            Category obj = UShopDB.Categories.Where(o => o.CategoryID == Convert.ToInt32(id)).SingleOrDefault();
            UShopDB.Categories.DeleteOnSubmit(obj);
            UShopDB.SubmitChanges();
        }


        public void updateCategory(Category category)
        {
            Category obj = UShopDB.Categories.Where(o => o.CategoryID == Convert.ToInt32(category.CategoryID)).SingleOrDefault();
            obj.CategoryName = category.CategoryName;
            obj.CategoryDescription = category.CategoryDescription;
            UShopDB.SubmitChanges();
        }
    }
}
