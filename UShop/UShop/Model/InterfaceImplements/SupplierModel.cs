using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class SupplierModel : DataModel, ISupplier
    {
        public List<Model.SUPPLIER> loadSupplier()
        {
            return UShopDB.SUPPLIERs.Where(o => o.RECORD_STATUS.Equals("A")).ToList();
        }

        public void addSupplier(SUPPLIER obj)
        {
            try
            {
                UShopDB.SUPPLIERs.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();
                obj.SUPPLIER_CODE = getCODE("SUP",obj.SUPPLIER_ID);
                UShopDB.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }


        public void deleteSupplier(string id)
        {
            SUPPLIER obj = UShopDB.SUPPLIERs.Where(o => o.SUPPLIER_ID == Convert.ToInt32(id)).SingleOrDefault();
            obj.RECORD_STATUS = "D";
            UShopDB.SubmitChanges();
        }


        public void updateSupplier(SUPPLIER supplier)
        {
            SUPPLIER obj = UShopDB.SUPPLIERs.Where(o => o.SUPPLIER_ID == Convert.ToInt32(supplier.SUPPLIER_ID)).SingleOrDefault();
            obj.SUPPLIER_NAME = supplier.SUPPLIER_NAME;
            obj.TAX_CODE = supplier.TAX_CODE;
            obj.PHONE = supplier.PHONE;
            obj.ADDRESS = supplier.ADDRESS;

            UShopDB.SubmitChanges();
        }
    }
}
