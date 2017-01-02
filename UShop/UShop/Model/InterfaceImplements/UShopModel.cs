using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class UShopModel : DataModel, IUShop
    {

        public SUPPLIER getUShop()
        {
            int count = UShopDB.SUPPLIERs.Where(o=>o.RECORD_STATUS.Equals("U")).Count();
            if (count == 0)
            {
                SUPPLIER ushop = new SUPPLIER();
                ushop.TAX_CODE = "0000";
                ushop.ADDRESS = "Địa chỉ rỗng!";
                ushop.SUPPLIER_NAME = "UShop";
                ushop.RECORD_STATUS = "U";
                ushop.PHONE = "0000";
                UShopDB.SUPPLIERs.InsertOnSubmit(ushop);
                UShopDB.SubmitChanges();
                ushop.SUPPLIER_CODE = getCODE("NCC",ushop.SUPPLIER_ID);
                UShopDB.SubmitChanges();
            }
            return UShopDB.SUPPLIERs.Where(o => o.RECORD_STATUS.Equals("U")).First();
        }

        public void updateUShop(SUPPLIER obj)
        {
            getUShop();
            SUPPLIER ushop = UShopDB.SUPPLIERs.Where(o => o.RECORD_STATUS.Equals("U")).First();
            ushop.TAX_CODE = obj.TAX_CODE;
            ushop.ADDRESS = obj.ADDRESS;
            ushop.SUPPLIER_NAME = obj.SUPPLIER_NAME;
            ushop.PHONE = obj.PHONE;
            UShopDB.SubmitChanges();
        }
    }
}
