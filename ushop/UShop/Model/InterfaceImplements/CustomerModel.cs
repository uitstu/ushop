using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model.InterfaceImplements
{
    public class CustomerModel : DataModel, ICustomer
    {
        public bool addCustomer(CUSTOMER cus)
        {
            try
            {
                UShopDB.CUSTOMERs.InsertOnSubmit(cus);
                UShopDB.SubmitChanges();

                cus.CUS_CODE = getCODE("CUS", cus.CUS_ID);
                UShopDB.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool deleteCustomer(string code)
        {
            bool ret = false;
            try
            {
                var result = UShopDB.CUSTOMERs.Where(o => o.CUS_CODE.Equals(code));
                CUSTOMER cus = result.SingleOrDefault();
                cus.RECORD_STATUS = ((char)RECORD_STATUS.INACTIVE) + "";
                UShopDB.SubmitChanges();
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public CUSTOMER getCustomerBy(string cusCode, RECORD_STATUS status)
        {
            CUSTOMER cus = null;
            try
            {
                cus = UShopDB.CUSTOMERs.Where(o => o.CUS_CODE.Equals(cusCode)
                    && o.RECORD_STATUS.Equals(((char)status) + "")        
                ).SingleOrDefault();

                var boughtAmountResult =
                         (
                           from c in UShopDB.CUSTOMERs
                           join inv in UShopDB.INVOICEs on c.CUS_ID equals inv.SELLER_ID
                           select (inv.TOTAL_AMOUNT)
                         );

                cus.BOUGHT_AMOUNT = boughtAmountResult.Sum();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return cus;
        }

        public int getCustomerCount()
        {
            int ret = UShopDB.CUSTOMERs.Count();
            return ret;
        }

        public DataTable getCustomerListBy(RECORD_STATUS status)
        {
            DataTable table = new DataTable();
            var cols = table.Columns;
            cols.Add("CUS_CODE");
            cols.Add("CUS_NAME");
            cols.Add("PHONE");
            cols.Add("ADDRESS");
            cols.Add("BOUGHT_AMOUNT");

            var result = UShopDB.CUSTOMERs.Where
                (o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)).DefaultIfEmpty();
            
            foreach (var o in result)
            {
                if (o != null)
                {
                    var boughtAmountResult =
                          UShopDB.INVOICEs.Where
                          (i => i.SELLER_ID == o.CUS_ID
                          &&  i.RECORD_STATUS.Equals((char)RECORD_STATUS.ACTIVE)
                          )
                          .Select(i => i.TOTAL_AMOUNT).Sum();
                        

                    table.Rows.Add(
                        o.CUS_CODE,
                        o.CUS_NAME,
                        o.PHONE,
                        o.ADDRESS,
                        boughtAmountResult > 0? boughtAmountResult: 0
                        );
                }
            }

            return table;
        }

        public bool updateCustomer(CUSTOMER updateCus)
        {
            bool ret = false;
            try
            {
                var result = UShopDB.CUSTOMERs.Where(o => o.CUS_ID == updateCus.CUS_ID);
                CUSTOMER cus = result.SingleOrDefault();
                cus.ADDRESS = updateCus.ADDRESS;
                cus.CUS_NAME = updateCus.CUS_NAME;
                cus.PHONE = updateCus.PHONE;
                cus.RECORD_STATUS = updateCus.RECORD_STATUS;
                UShopDB.SubmitChanges();
                var boughtAmountResult =
                          (
                            from c in UShopDB.CUSTOMERs
                            join inv in UShopDB.INVOICEs on c.CUS_ID equals inv.SELLER_ID
                            select (inv.TOTAL_AMOUNT)
                          );

                cus.BOUGHT_AMOUNT = boughtAmountResult.Sum();
                UShopDB.SubmitChanges();
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }
    }
}
