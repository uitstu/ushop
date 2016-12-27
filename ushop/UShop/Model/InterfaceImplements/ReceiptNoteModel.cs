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
        public RECEIPT_NOTE getReceiptNoteByCODE(string code)
        {
            RECEIPT_NOTE r = new RECEIPT_NOTE();

            foreach (RECEIPT_NOTE item in UShopDB.RECEIPT_NOTEs)
            {
                if (item.RN_CODE.Equals(code))
                {
                    r = item;
                    break;
                }
            }

            return r;
        }

        public System.Data.DataTable loadReceiptNoteDT()
        {
            //var result = from r in UShopDB.RECEIPT_NOTEs 
            //             join s in UShopDB.SUPPLIERs 
            //             on r.SUPPLIER_ID equals s.SUPPLIER_ID 
            //             into final1 
            //             from x in final1.DefaultIfEmpty()
                         
            //             join e in UShopDB.EMPLOYEEs
            //             on r.PREPARER_ID equals e.EMP_ID 
            //             into final2
            //             from y in final2.DefaultIfEmpty()
                         
            //             select new
            //             {
            //                 r.RN_ID,
            //                 r.RN_CODE,
            //                 r.SUPPLIER_ID,
            //                 x.SUPPLIER_NAME,
            //                 r.PREPARER_ID,
            //                 y.EMP_NAME,
            //                 r.ISSUED_DATE,
            //                 r.ACCOUNTING_DATE,
            //                 r.ACCOUNTED,
            //                 r.TOTAL,
            //                 r.NOTE,
            //                 r.RECORD_STATUS
            //             };

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

            //foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
            //{
            //    dt.Rows.Add(o.RN_ID,o.RN_CODE,o.SUPPLIER_ID,o.SUPPLIER_NAME,o.PREPARER_ID,o.EMP_NAME,
            //        o.ISSUED_DATE, o.ACCOUNTING_DATE, o.ACCOUNTED, o.TOTAL, o.NOTE, o.RECORD_STATUS);
            //}

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





        public DataTable loadSupplierDT(bool isAll)
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

            if (isAll)
            {
                foreach (var o in result)
                {
                    dt.Rows.Add(o.SUPPLIER_CODE, o.SUPPLIER_NAME, o.RECORD_STATUS);
                }
            }
            else
            {
                foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
                {
                    dt.Rows.Add(o.SUPPLIER_CODE, o.SUPPLIER_NAME, o.RECORD_STATUS);
                }
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

        public DataTable loadRN_ITEM(int RN_ID)
        {
            //var result = from r in UShopDB.RECEIPT_NOTE_ITEMs
            //             join s in UShopDB.PRODUCTs
            //             on r.PRODUCT_ID equals s.PRODUCT_ID
            //             into final1
            //             from x in final1.DefaultIfEmpty()

            //             select new
            //             {
            //                 r.RN_ID,
            //                 x.PRODUCT_CODE,
            //                 x.PRODUCT_NAME,
            //                 r.QUANTITY_STOCK_S,
            //                 r.QUANTITY_VOUCHER_S,
            //                 r.QUANTITY_STOCK_M,
            //                 r.QUANTITY_VOUCHER_M,
            //                 r.QUANTITY_STOCK_L,
            //                 r.QUANTITY_VOUCHER_L,
            //                 r.QUANTITY_STOCK_XL,
            //                 r.QUANTITY_VOUCHER_XL,
            //                 r.QUANTITY_STOCK_XXL,
            //                 r.QUANTITY_VOUCHER_XXL,
            //                 r.TOTAL_STOCK,
            //                 r.TOTAL_VOUCHER,
            //                 r.PRICE,
            //                 r.AMOUNT,
            //                 r.RECORD_STATUS
            //             };

            DataTable dt = new DataTable();

            //dt.Columns.Add("CODE");
            //dt.Columns.Add("NAME");
            //dt.Columns.Add("STOCK_S");
            //dt.Columns.Add("VOUCHER_S");
            //dt.Columns.Add("STOCK_M");
            //dt.Columns.Add("VOUCHER_M");
            //dt.Columns.Add("STOCK_L");
            //dt.Columns.Add("VOUCHER_L");
            //dt.Columns.Add("STOCK_XL");
            //dt.Columns.Add("VOUCHER_XL");
            //dt.Columns.Add("STOCK_XXL");
            //dt.Columns.Add("VOUCHER_XXL");
            //dt.Columns.Add("STOCK_TOTAL");
            //dt.Columns.Add("VOUCHER_TOTAL");
            //dt.Columns.Add("PRICE");
            //dt.Columns.Add("AMOUNT");

            //foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A") && o.RN_ID.Equals(RN_ID)))
            //{
            //    dt.Rows.Add(o.PRODUCT_CODE, o.PRODUCT_NAME, o.QUANTITY_STOCK_S, o.QUANTITY_VOUCHER_S
            //        , o.QUANTITY_STOCK_M, o.QUANTITY_VOUCHER_M, o.QUANTITY_STOCK_L, o.QUANTITY_VOUCHER_L
            //        , o.QUANTITY_STOCK_XL, o.QUANTITY_VOUCHER_XL, o.QUANTITY_STOCK_XXL, o.QUANTITY_VOUCHER_XXL
            //        , o.TOTAL_STOCK, o.TOTAL_VOUCHER, o.PRICE, o.AMOUNT);
            //}

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
                item.RN_ID =  obj.RN_ID;
                //item.PRODUCT_ID = Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), 5));
                //item.QUANTITY_STOCK_S = Int32.Parse(r[2].ToString());
                //item.QUANTITY_VOUCHER_S = Int32.Parse(r[3].ToString());
                //item.QUANTITY_STOCK_M = Int32.Parse(r[4].ToString());
                //item.QUANTITY_VOUCHER_M = Int32.Parse(r[5].ToString());
                //item.QUANTITY_STOCK_L = Int32.Parse(r[6].ToString());
                //item.QUANTITY_VOUCHER_L = Int32.Parse(r[7].ToString());
                //item.QUANTITY_STOCK_XL = Int32.Parse(r[8].ToString());
                //item.QUANTITY_VOUCHER_XL = Int32.Parse(r[9].ToString());
                //item.QUANTITY_STOCK_XXL = Int32.Parse(r[10].ToString());
                //item.QUANTITY_VOUCHER_XXL = Int32.Parse(r[11].ToString());

                //item.TOTAL_STOCK = Int32.Parse(r[12].ToString());
                //item.TOTAL_VOUCHER = Int32.Parse(r[13].ToString());
                //item.PRICE = Int32.Parse(r[14].ToString());
                item.AMOUNT = Int32.Parse(r[15].ToString());

                item.RECORD_STATUS = "A";

                lst.Add(item);

                //foreach (PRODUCT p in UShopDB.PRODUCTs.Where(o => o.PRODUCT_ID == item.PRODUCT_ID))
                //{
                //    p.SIZE_S += item.QUANTITY_STOCK_S;
                //    p.SIZE_M += item.QUANTITY_STOCK_M;
                //    p.SIZE_L += item.QUANTITY_STOCK_L;
                //    p.SIZE_XL += item.QUANTITY_STOCK_XL;
                //    p.SIZE_XXL += item.QUANTITY_STOCK_XXL;
                //}
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


        public string update(RECEIPT_NOTE obj, DataTable dtItems)
        {
            String strError = "";

            List<RECEIPT_NOTE_ITEM> lstDeleted = new List<RECEIPT_NOTE_ITEM>();
            List<RECEIPT_NOTE_ITEM> lstUpdated = new List<RECEIPT_NOTE_ITEM>();
            List<RECEIPT_NOTE_ITEM> lstInserted = new List<RECEIPT_NOTE_ITEM>();

            //update
            foreach (DataRow r in dtItems.Rows)
            {
                foreach (RECEIPT_NOTE_ITEM i in UShopDB.RECEIPT_NOTE_ITEMs.Where(o => o.RN_ID.Equals(obj.RN_ID)))
                {
                    if (Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'),5)).Equals(i.PRODUCT_ID) && i.RN_ID.Equals(obj.RN_ID) && i.RECORD_STATUS.Equals("A"))
                    {
                        lstUpdated.Add(i);
                        break;
                    }
                }
            }


            //insert
            foreach (DataRow r in dtItems.Rows)
            {
                bool isFounded = false;
                foreach (RECEIPT_NOTE_ITEM i in UShopDB.RECEIPT_NOTE_ITEMs.Where(o => o.RN_ID.Equals(obj.RN_ID)))
                {
                    if (Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), 5)).Equals(i.PRODUCT_ID) && i.RECORD_STATUS.Equals("A"))
                    {
                        isFounded = true;
                        break;
                    }
                }

                if (!isFounded)
                {
                    //RECEIPT_NOTE_ITEM re_i = new RECEIPT_NOTE_ITEM();

                    //re_i.RN_ID = obj.RN_ID;
                    //re_i.PRODUCT_ID = getProductByCODE(r[0].ToString()).PRODUCT_ID; 
                    //re_i.QUANTITY_STOCK_S = Int32.Parse(r[2].ToString());

                    //re_i.QUANTITY_VOUCHER_S = Int32.Parse(r[3].ToString());

                    //re_i.QUANTITY_STOCK_M = Int32.Parse(r[4].ToString());
                    //re_i.QUANTITY_VOUCHER_M = Int32.Parse(r[5].ToString());
                    //re_i.QUANTITY_STOCK_L = Int32.Parse(r[6].ToString());
                    //re_i.QUANTITY_VOUCHER_L = Int32.Parse(r[7].ToString());
                    //re_i.QUANTITY_STOCK_XL = Int32.Parse(r[8].ToString());
                    //re_i.QUANTITY_VOUCHER_XL = Int32.Parse(r[9].ToString());
                    //re_i.QUANTITY_STOCK_XXL = Int32.Parse(r[10].ToString());
                    //re_i.QUANTITY_VOUCHER_XXL = Int32.Parse(r[11].ToString());
                    //re_i.TOTAL_STOCK = Int32.Parse(r[12].ToString());
                    //re_i.TOTAL_VOUCHER = Int32.Parse(r[13].ToString());
                    //re_i.PRICE = Int32.Parse(r[14].ToString());
                    //re_i.AMOUNT = Int32.Parse(r[15].ToString());

                    //lstInserted.Add(re_i);
                }
            }

            //delete
            foreach (RECEIPT_NOTE_ITEM i in UShopDB.RECEIPT_NOTE_ITEMs.Where(o => o.RN_ID.Equals(obj.RN_ID)))
            {
                bool isFounded = false;
                foreach (DataRow r in dtItems.Rows)
                {
                    if (Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'),5)).Equals(i.PRODUCT_ID) && i.RN_ID.Equals(obj.RN_ID) && i.RECORD_STATUS.Equals("A"))
                    {
                        isFounded = true;
                        break;
                    }
                }
                if (!isFounded)
                {
                    lstDeleted.Add(i);
                }
            }

            // Sau khi tim duoc lstInsert-Delete-Update, tien hanh kiem tra co loi hay khong

            //kiem tra delete
            foreach (RECEIPT_NOTE_ITEM r in lstDeleted)
            {
                foreach (PRODUCT p in UShopDB.PRODUCTs)
                {
                    //if (p.PRODUCT_ID.Equals(r.PRODUCT_ID) && (p.SIZE_S < r.QUANTITY_STOCK_S || p.SIZE_M < r.QUANTITY_STOCK_M
                    //    || p.SIZE_L < r.QUANTITY_STOCK_L || p.SIZE_XL < r.QUANTITY_STOCK_XL || p.SIZE_XXL < r.QUANTITY_STOCK_XXL))
                    //{
                    //    strError += "\nSo luong " + p.PRODUCT_NAME + "khong du de delete.";
                    //    break;
                    //}
                }
            } 

            //kiem tra update
            foreach (RECEIPT_NOTE_ITEM i in lstUpdated)
            {
                //DataRow rForCheck = new DataRow();
                foreach (DataRow r in dtItems.Rows)
                {
                    if (i.PRODUCT_ID.Equals(Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), 5))))
                    {
                        //rForCheck = r;

                        //i.RN_ID = obj.RN_ID;
                        //i.PRODUCT_ID = getProductByCODE(r[0].ToString()).PRODUCT_ID;
                        int sTotal = Int32.Parse(r[2].ToString());
                        int mTotal = Int32.Parse(r[4].ToString());
                        int lTotal = Int32.Parse(r[6].ToString());
                        int xlTotal = Int32.Parse(r[8].ToString());
                        int xxlTotal = Int32.Parse(r[10].ToString());

                        foreach (PRODUCT p in UShopDB.PRODUCTs)
                        {
                            //if (p.PRODUCT_ID.Equals(i.PRODUCT_ID) && (p.SIZE_S + (sTotal - i.QUANTITY_STOCK_S) < 0
                            //    || p.SIZE_M + (mTotal - i.QUANTITY_STOCK_M) < 0 || p.SIZE_L + (lTotal - i.QUANTITY_STOCK_L) < 0
                            //    || p.SIZE_XL + (xlTotal - i.QUANTITY_STOCK_XL) < 0 || p.SIZE_XXL + (xxlTotal - i.QUANTITY_STOCK_XXL) < 0))
                            //{
                            //    strError += "\nSo luong " + p.PRODUCT_NAME + "khong du de update.";
                            //    break;
                            //}
                        }

                        break;
                    }
                    
                }

            }

            //insert khong can quan tam so luong luc truoc nen khong can kiem tra

            //

            if (!strError.Equals(""))
            {
                Console.WriteLine("loi roi hixx "+strError);
                return strError;
            }

            //
            if (dtItems.Rows.Count == 0) //chuc nang xoa RECEIPT_NOTE
            {
                obj.RECORD_STATUS = "D";
            }
            //
            //delete
            foreach (RECEIPT_NOTE_ITEM r in lstDeleted)
            {
                UShopDB.RECEIPT_NOTE_ITEMs.DeleteOnSubmit(r);

                //cap nhat PRODUCT table
                foreach (PRODUCT p in UShopDB.PRODUCTs)
                {
                    if (p.PRODUCT_ID.Equals(r.PRODUCT_ID))
                    {
                        //p.SIZE_S -= r.QUANTITY_STOCK_S;
                        //p.SIZE_M -= r.QUANTITY_STOCK_M;
                        //p.SIZE_L -= r.QUANTITY_STOCK_L;
                        //p.SIZE_XL -= r.QUANTITY_STOCK_XL;
                        //p.SIZE_XXL -= r.QUANTITY_STOCK_XXL;
                        //break;
                    }
                }
            }    

            //update
            foreach (RECEIPT_NOTE_ITEM i in lstUpdated)
            {
                foreach (DataRow r in dtItems.Rows)
                {
                    if (i.PRODUCT_ID.Equals(Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), 5))))
                    {
                        int sTotal = Int32.Parse(r[2].ToString());
                        int mTotal = Int32.Parse(r[4].ToString());
                        int lTotal = Int32.Parse(r[6].ToString()); Console.WriteLine("lTotal aaa: "+lTotal);
                        int xlTotal = Int32.Parse(r[8].ToString());
                        int xxlTotal = Int32.Parse(r[10].ToString());

                        foreach (PRODUCT p in UShopDB.PRODUCTs)
                        {
                            Console.WriteLine("chay ko du");
                            if (p.PRODUCT_ID.Equals(i.PRODUCT_ID))
                            {
                                //p.SIZE_S += (sTotal - i.QUANTITY_STOCK_S);
                                //p.SIZE_M += (mTotal - i.QUANTITY_STOCK_M); Console.WriteLine("QUANTITY_STOCK_L aaa: " + i.QUANTITY_STOCK_L);
                                //p.SIZE_L += (lTotal - i.QUANTITY_STOCK_L); Console.WriteLine("Tang " + (lTotal - i.QUANTITY_STOCK_L));
                                //p.SIZE_XL += (xlTotal - i.QUANTITY_STOCK_XL);
                                //p.SIZE_XXL += (xxlTotal - i.QUANTITY_STOCK_XXL);
                                //break;
                            }
                            
                        }

                        //i.RN_ID = obj.RN_ID;
                        //i.PRODUCT_ID = getProductByCODE(r[0].ToString()).PRODUCT_ID;
                        //i.QUANTITY_STOCK_S = Int32.Parse(r[2].ToString());

                        //i.QUANTITY_VOUCHER_S = Int32.Parse(r[3].ToString());

                        //i.QUANTITY_STOCK_M = Int32.Parse(r[4].ToString());
                        //i.QUANTITY_VOUCHER_M = Int32.Parse(r[5].ToString());
                        //i.QUANTITY_STOCK_L = Int32.Parse(r[6].ToString());
                        //i.QUANTITY_VOUCHER_L = Int32.Parse(r[7].ToString());
                        //i.QUANTITY_STOCK_XL = Int32.Parse(r[8].ToString());
                        //i.QUANTITY_VOUCHER_XL = Int32.Parse(r[9].ToString());
                        //i.QUANTITY_STOCK_XXL = Int32.Parse(r[10].ToString());
                        //i.QUANTITY_VOUCHER_XXL = Int32.Parse(r[11].ToString());
                        //i.TOTAL_STOCK = Int32.Parse(r[12].ToString());
                        //i.TOTAL_VOUCHER = Int32.Parse(r[13].ToString());
                        //i.PRICE = Int32.Parse(r[14].ToString());
                        i.AMOUNT = Int32.Parse(r[15].ToString());

                        break;
                    }
                }

            }

            //insert

            foreach (RECEIPT_NOTE_ITEM r in lstInserted)
            {
                r.RECORD_STATUS = "A";
                UShopDB.RECEIPT_NOTE_ITEMs.InsertOnSubmit(r);

                foreach (PRODUCT p in UShopDB.PRODUCTs)
                {
                    if (p.PRODUCT_ID.Equals(r.PRODUCT_ID))
                    {
                        //p.SIZE_S += r.QUANTITY_STOCK_S;
                        //p.SIZE_M += r.QUANTITY_STOCK_M;
                        //p.SIZE_L += r.QUANTITY_STOCK_L;
                        //p.SIZE_XL += r.QUANTITY_STOCK_XL;
                        //p.SIZE_XXL += r.QUANTITY_STOCK_XXL;
                    }
                    break;
                }
            }

            UShopDB.SubmitChanges();

            return "";
        }
    }
}
