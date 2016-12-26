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
        public List<Model.CATEGORY> loadCategory()
        {
            return UShopDB.CATEGORies.Where(o => o.RECORD_STATUS.Equals("A")).ToList();
        }

        public void addCategory(CATEGORY obj)
        {
            try
            {
                UShopDB.CATEGORies.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();
                obj.CATEGORY_CODE = getCODE("CAT",obj.CATEGORY_ID);
                UShopDB.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }


        public void deleteCategory(string id)
        {
            CATEGORY obj = UShopDB.CATEGORies.Where(o => o.CATEGORY_ID == Convert.ToInt32(id)).SingleOrDefault();
            obj.RECORD_STATUS = "D";
            //UShopDB.CATEGORies.DeleteOnSubmit(obj);
            UShopDB.SubmitChanges();
        }


        public void updateCategory(CATEGORY category)
        {
            CATEGORY obj = UShopDB.CATEGORies.Where(o => o.CATEGORY_ID == Convert.ToInt32(category.CATEGORY_ID)).SingleOrDefault();
            obj.CATEGORY_NAME = category.CATEGORY_NAME;
            obj.DESCRIPTION = category.DESCRIPTION;
            UShopDB.SubmitChanges();
        }
    }
}
