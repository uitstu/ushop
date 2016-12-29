using Model.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class ProductSizeModel : DataModel, IProductSize
    {
        public DataTable loadProductSize()
        {
            var result = from r in UShopDB.PRODUCT_SIZEs
                         join s in UShopDB.PRODUCTs
                         on r.PRODUCT_ID equals s.PRODUCT_ID
                         into final1
                         from x in final1.DefaultIfEmpty()

                         select new
                         {
                             r.PRODUCT_ID,
                             x.PRODUCT_CODE,
                             x.PRODUCT_NAME,
                             r.SIZE,
                             r.IN_STOCK_QUANTITY,
                             x.RECORD_STATUS
                         };

            DataTable dt = new DataTable();
            dt.Columns.Add("PRODUCT_ID");
            dt.Columns.Add("PRODUCT_CODE");
            dt.Columns.Add("PRODUCT_NAME");
            dt.Columns.Add("SIZE");
            dt.Columns.Add("IN_STOCK_QUANTITY");
            //dt.Columns.Add("RECORD_STATUS");

            foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
            {
                dt.Rows.Add(o.PRODUCT_ID, o.PRODUCT_CODE, o.PRODUCT_NAME, o.SIZE, o.IN_STOCK_QUANTITY);
            }

            return dt;
        }

        public void addProductSize(PRODUCT_SIZE obj)
        {
            try
            {
                UShopDB.PRODUCT_SIZEs.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();
                //obj.PRODUCT_CODE = getCODE("PRO",obj.PRODUCT_ID);
                //UShopDB.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }


        public void deleteProductSize(string id, string size)
        {
            PRODUCT_SIZE obj = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID == Convert.ToInt32(id) && o.SIZE.Equals(size)).SingleOrDefault();
            UShopDB.PRODUCT_SIZEs.DeleteOnSubmit(obj);
            UShopDB.SubmitChanges();
        }


        public void updateProductSize(PRODUCT_SIZE product)
        {
            PRODUCT_SIZE obj = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID == product.PRODUCT_ID && o.SIZE.Equals(product.SIZE)).SingleOrDefault();
            obj.IN_STOCK_QUANTITY = product.IN_STOCK_QUANTITY;
            obj.PRODUCT_ID = product.PRODUCT_ID;
            obj.SIZE = product.SIZE;

            UShopDB.SubmitChanges();
        }

        //

        public DataTable loadProductDT(bool isAll)
        {
            var result = from r in UShopDB.PRODUCTs
                         select new
                         {
                             r.PRODUCT_CODE,
                             r.PRODUCT_NAME,
                             r.RECORD_STATUS
                         };

            DataTable dt = new DataTable();

            dt.Columns.Add("PRODUCT_CODE");
            dt.Columns.Add("PRODUCT_NAME");
            dt.Columns.Add("RECORD_STATUS");

            if (isAll)
            {
                foreach (var o in result)
                {
                    dt.Rows.Add(o.PRODUCT_CODE, o.PRODUCT_NAME, o.RECORD_STATUS);
                }
            }
            else
            {
                foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
                {
                    dt.Rows.Add(o.PRODUCT_CODE, o.PRODUCT_NAME, o.RECORD_STATUS);
                }
            }

            return dt;
        }

        public List<String> getLstSize(int productID)
        {
            List<string> lst = new List<string>();
            lst.Add("S");
            lst.Add("M");
            lst.Add("L");
            lst.Add("XL");
            lst.Add("XXL");

            foreach (PRODUCT_SIZE s in UShopDB.PRODUCT_SIZEs)
            {
                if (s.PRODUCT_ID == productID)
                {
                    foreach (string str in lst)
                    {
                        if (str.Equals(s.SIZE))
                        {
                            lst.Remove(str);
                            break;
                        }
                    }
                }
            }

            return lst;
        }
    }
}
