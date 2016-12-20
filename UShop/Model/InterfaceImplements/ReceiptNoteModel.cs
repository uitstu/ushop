using Model.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class ReceiptNoteModel : DataModel, IReceiptNote
    {
        private static RECEIPT_NOTE receipt_note;

        public static RECEIPT_NOTE getReceiptNote()
        {
            return receipt_note;
        }

        public RECEIPT_NOTE findReceiptNote(string id)
        {
            receipt_note = null;

            return receipt_note;
        }

        public System.Data.DataTable loadReceiptNoteDT()
        {
            var result = from r in UShopDB.RECEIPT_NOTEs 
                         join s in UShopDB.SUPPLIERs 
                         on r.SUPPLIER_ID equals s.SUPPLIER_ID 
                         into final1 
                         from x in final1.DefaultIfEmpty()
                         
                         join e in UShopDB.EMPLOYEEs
                         on r.PREPARER_ID equals e.EMP_ID 
                         into final2
                         from y in final2.DefaultIfEmpty()
                         
                         select new
                         {
                             r.RN_ID,
                             r.RN_CODE,
                             r.SUPPLIER_ID,
                             x.SUPPLIER_NAME,
                             r.PREPARER_ID,
                             y.EMP_NAME,
                             r.ISSUED_DATE,
                             r.ACCOUNTING_DATE,
                             r.ACCOUNTED,
                             r.TOTAL,
                             r.NOTE,
                             r.RECORD_STATUS
                         };

            DataTable dt = new DataTable();
            dt.Columns.Add("RN_ID");
            dt.Columns.Add("RN_CODE");
            dt.Columns.Add("SUPPLIER_ID");
            dt.Columns.Add("SUPPLIER_NAME");
            dt.Columns.Add("PREPARER_ID");
            dt.Columns.Add("EMP_NAME");
            dt.Columns.Add("ISSUED_DATE");
            dt.Columns.Add("ACCOUNTING_DATE");
            dt.Columns.Add("ACCOUNTED");
            dt.Columns.Add("TOTAL");
            dt.Columns.Add("NOTE");
            dt.Columns.Add("RECORD_STATUS");

            foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
            {
                dt.Rows.Add(o.RN_ID,o.RN_CODE,o.SUPPLIER_ID,o.SUPPLIER_NAME,o.PREPARER_ID,o.EMP_NAME,
                    o.ISSUED_DATE, o.ACCOUNTING_DATE, o.ACCOUNTED, o.TOTAL, o.NOTE, o.RECORD_STATUS);
            }

            return dt;
        }

        public List<Model.RECEIPT_NOTE> loadReceiptNote()
        {
            return UShopDB.RECEIPT_NOTEs.ToList();
            
        }
        
        public List<Model.RECEIPT_NOTE_ITEM> loadReceiptNoteItem()
        {
            return UShopDB.RECEIPT_NOTE_ITEMs.ToList();
        }

        public void addReceiptNote(RECEIPT_NOTE obj)
        {
            try
            {
                UShopDB.RECEIPT_NOTEs.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }


        public void deleteReceiptNote(string id)
        {
            /*
            Category obj = UShopDB.Categories.Where(o => o.CategoryID == Convert.ToInt32(id)).SingleOrDefault();
            UShopDB.Categories.DeleteOnSubmit(obj);
            UShopDB.SubmitChanges();
             * */

        }


        public void updateReceiptNote(RECEIPT_NOTE receipt_note)
        {
            /*
            Category obj = UShopDB.Categories.Where(o => o.CategoryID == Convert.ToInt32(category.CategoryID)).SingleOrDefault();
            obj.CategoryName = category.CategoryName;
            obj.CategoryDescription = category.CategoryDescription;
            UShopDB.SubmitChanges();
             * */
        }





        public DataTable loadSupplierDT()
        {
            var result = from r in UShopDB.SUPPLIERs
                         select new
                         {
                             r.SUPPLIER_CODE,
                             r.SUPPLIER_NAME,
                             r.RECORD_STATUS
                         };

            DataTable dt = new DataTable();
            
            dt.Columns.Add("SUPPLIER_CODE");
            dt.Columns.Add("SUPPLIER_NAME");
            dt.Columns.Add("RECORD_STATUS");

            foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
            {
                dt.Rows.Add(o.SUPPLIER_CODE, o.SUPPLIER_NAME, o.RECORD_STATUS);
            }

            return dt;
        }

        public DataTable loadProductDT()
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

            foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
            {
                dt.Rows.Add(o.PRODUCT_CODE, o.PRODUCT_NAME, o.RECORD_STATUS);
            }

            return dt;
        }


        public void add(RECEIPT_NOTE obj, DataTable dtItems)
        {
            UShopDB.RECEIPT_NOTEs.InsertOnSubmit(obj);
            UShopDB.SubmitChanges();
            obj.RN_CODE = getCODE("RCN",obj.RN_ID);

            List<RECEIPT_NOTE_ITEM> lst = new List<RECEIPT_NOTE_ITEM>();

            foreach (DataRow r in dtItems.Rows)
            {
                RECEIPT_NOTE_ITEM item = new RECEIPT_NOTE_ITEM();
                item.RN_ID = obj.RN_ID;
                item.PRODUCT_ID = Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), 5));
                item.QUANTITY_STOCK_S = Int32.Parse(r[2].ToString());
                item.QUANTITY_VOUCHER_S = Int32.Parse(r[3].ToString());
                item.QUANTITY_STOCK_M = Int32.Parse(r[4].ToString());
                item.QUANTITY_VOUCHER_M = Int32.Parse(r[5].ToString());
                item.QUANTITY_STOCK_L = Int32.Parse(r[6].ToString());
                item.QUANTITY_VOUCHER_L = Int32.Parse(r[7].ToString());
                item.QUANTITY_STOCK_XL = Int32.Parse(r[8].ToString());
                item.QUANTITY_VOUCHER_XL = Int32.Parse(r[9].ToString());
                item.QUANTITY_STOCK_XXL = Int32.Parse(r[10].ToString());
                item.QUANTITY_VOUCHER_XXL = Int32.Parse(r[11].ToString());

                item.TOTAL_STOCK = Int32.Parse(r[12].ToString());
                item.TOTAL_VOUCHER = Int32.Parse(r[13].ToString());
                item.PRICE = Int32.Parse(r[14].ToString());
                item.AMOUNT = Int32.Parse(r[15].ToString());

                item.RECORD_STATUS = "A";

                lst.Add(item);

                foreach (PRODUCT p in UShopDB.PRODUCTs.Where(o => o.PRODUCT_ID == item.PRODUCT_ID))
                {
                    p.SIZE_S += item.QUANTITY_STOCK_S;
                    p.SIZE_M += item.QUANTITY_STOCK_M;
                    p.SIZE_L += item.QUANTITY_STOCK_L;
                    p.SIZE_XL += item.QUANTITY_STOCK_XL;
                    p.SIZE_XXL += item.QUANTITY_STOCK_XXL;
                }
            }

            UShopDB.RECEIPT_NOTE_ITEMs.InsertAllOnSubmit(lst);

            UShopDB.SubmitChanges();

            foreach (RECEIPT_NOTE_ITEM i in UShopDB.RECEIPT_NOTE_ITEMs.Where(o=> o.RN_ID == obj.RN_ID))
            {
                i.RN_ITEM_CODE = getCODE("RIT", i.RN_ITEM_ID) ;
            }

            UShopDB.SubmitChanges();
        }


        public PRODUCT getProductByCODE(string code)
        {
            PRODUCT i = new PRODUCT();

            foreach (PRODUCT item in UShopDB.PRODUCTs)
            {
                if (item.PRODUCT_CODE.Equals(code))
                {
                    i = item;
                    break;
                }
            }

            return i;
        }
    }
}
