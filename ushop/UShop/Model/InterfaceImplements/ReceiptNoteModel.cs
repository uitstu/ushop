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
                if (item.RN_CODE!=null && item.RN_CODE.Equals(code))
                {
                    r = item;
                    break;
                }
            }

            return r;
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
                             r.STATUS,
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
            dt.Columns.Add("STATUS");
            dt.Columns.Add("RECORD_STATUS");

            foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
            {
                dt.Rows.Add(o.RN_ID,o.RN_CODE,o.SUPPLIER_ID,o.SUPPLIER_NAME,o.PREPARER_ID,o.EMP_NAME,
                    ((DateTime)(o.ISSUED_DATE)).ToString("dd/MM/yyyy"), ((DateTime)(o.ACCOUNTING_DATE)).ToString("dd/MM/yyyy"), o.ACCOUNTED, o.TOTAL, o.NOTE, o.STATUS, o.RECORD_STATUS);

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
            var result = from r in UShopDB.RECEIPT_NOTE_ITEMs
                         join s in UShopDB.PRODUCTs
                         on r.PRODUCT_ID equals s.PRODUCT_ID
                         into final1
                         from x in final1.DefaultIfEmpty()

                         select new
                         {
                             r.RN_ID,
                             x.PRODUCT_CODE,
                             x.PRODUCT_NAME,
                             r.QUANTITY_STOCK_S,
                             r.QUANTITY_VOUCHER_S,
                             /*
                             r.QUANTITY_STOCK_M,
                             r.QUANTITY_VOUCHER_M,
                             r.QUANTITY_STOCK_L,
                             r.QUANTITY_VOUCHER_L,
                             r.QUANTITY_STOCK_XL,
                             r.QUANTITY_VOUCHER_XL,
                             r.QUANTITY_STOCK_XXL,
                             r.QUANTITY_VOUCHER_XXL,
                             r.TOTAL_STOCK,
                             r.TOTAL_VOUCHER,
                              * */
                             r.SIZE,
                             r.PRICE,
                             r.AMOUNT,
                             r.RECORD_STATUS
                         };

            DataTable dt = new DataTable();

            dt.Columns.Add("PRODUCT_CODE");
            dt.Columns.Add("PRODUCT_NAME");
            dt.Columns.Add("STOCK_S");
            dt.Columns.Add("VOUCHER_S");
            /*
            dt.Columns.Add("STOCK_M");
            dt.Columns.Add("VOUCHER_M");
            dt.Columns.Add("STOCK_L");
            dt.Columns.Add("VOUCHER_L");
            dt.Columns.Add("STOCK_XL");
            dt.Columns.Add("VOUCHER_XL");
            dt.Columns.Add("STOCK_XXL");
            dt.Columns.Add("VOUCHER_XXL");
            dt.Columns.Add("STOCK_TOTAL");
            dt.Columns.Add("VOUCHER_TOTAL");
             * */
            dt.Columns.Add("SIZE");
            dt.Columns.Add("PRICE");
            dt.Columns.Add("AMOUNT");

            foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A") && o.RN_ID.Equals(RN_ID)))
            {
                dt.Rows.Add(o.PRODUCT_CODE, o.PRODUCT_NAME, o.QUANTITY_STOCK_S, o.QUANTITY_VOUCHER_S
                    /*, o.QUANTITY_STOCK_M, o.QUANTITY_VOUCHER_M, o.QUANTITY_STOCK_L, o.QUANTITY_VOUCHER_L
                    , o.QUANTITY_STOCK_XL, o.QUANTITY_VOUCHER_XL, o.QUANTITY_STOCK_XXL, o.QUANTITY_VOUCHER_XXL
                    , o.TOTAL_STOCK, o.TOTAL_VOUCHER*/, o.SIZE, o.PRICE, o.AMOUNT);

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
                item.PRODUCT_ID = Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), r[0].ToString().Length - r[0].ToString().IndexOf('0')));
                item.QUANTITY_STOCK_S = Int32.Parse(r[2].ToString());
                item.QUANTITY_VOUCHER_S = Int32.Parse(r[3].ToString());

                item.SIZE = r[4].ToString();

                item.PRICE = Int32.Parse(r[5].ToString());
                item.AMOUNT = Int32.Parse(r[6].ToString());
                
                item.RECORD_STATUS = "A";

                lst.Add(item);

                //
                foreach (RECEIPT_NOTE_ITEM i in lst)
                {
                    if (UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(i.PRODUCT_ID) && o.SIZE.Equals(i.SIZE)).Count() > 0)
                    {
                        PRODUCT_SIZE p = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(i.PRODUCT_ID) && o.SIZE.Equals(i.SIZE)).First();
                        p.IN_STOCK_QUANTITY += item.QUANTITY_STOCK_S;
                    }
                    else
                    {
                        PRODUCT_SIZE p = new PRODUCT_SIZE();
                        p.PRODUCT_ID = i.PRODUCT_ID??1;
                        p.SIZE = i.SIZE;
                        p.IN_STOCK_QUANTITY = item.QUANTITY_STOCK_S;
                        UShopDB.PRODUCT_SIZEs.InsertOnSubmit(p);
                    }
                }
            }

            UShopDB.RECEIPT_NOTE_ITEMs.InsertAllOnSubmit(lst);

            UShopDB.SubmitChanges();

            foreach (RECEIPT_NOTE_ITEM i in UShopDB.RECEIPT_NOTE_ITEMs.Where(o=> o.RN_ID == obj.RN_ID))
            {
                i.RN_ITEM_CODE = getCODE("RIT", i.RN_ITEM_ID);
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

            //list update
            foreach (DataRow r in dtItems.Rows)
            {
                int id = Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), r[0].ToString().Length - r[0].ToString().IndexOf('0')));
                string size = r[4].ToString();

                foreach (RECEIPT_NOTE_ITEM i in UShopDB.RECEIPT_NOTE_ITEMs.Where(o => o.RN_ID.Equals(obj.RN_ID) && o.RECORD_STATUS.Equals("A")))
                {
                    if (id.Equals(i.PRODUCT_ID) && i.RN_ID.Equals(obj.RN_ID) && i.SIZE.Equals(size))
                    {
                        lstUpdated.Add(i);
                        break;
                    }
                }
            }


            //list insert
            foreach (DataRow r in dtItems.Rows)
            {
                int id = Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), r[0].ToString().Length - r[0].ToString().IndexOf('0')));
                string size = r[4].ToString();

                bool isFounded = false;
                foreach (RECEIPT_NOTE_ITEM i in UShopDB.RECEIPT_NOTE_ITEMs.Where(o => o.RN_ID.Equals(obj.RN_ID) && o.RECORD_STATUS.Equals("A")))
                {
                    if (id.Equals(i.PRODUCT_ID) && i.RN_ID.Equals(obj.RN_ID) && i.SIZE.Equals(size))
                    {
                        isFounded = true;
                        break;
                    }
                }

                if (!isFounded)
                {
                    RECEIPT_NOTE_ITEM re_i = new RECEIPT_NOTE_ITEM();

                    re_i.RN_ID = obj.RN_ID;
                    re_i.PRODUCT_ID = getProductByCODE(r[0].ToString()).PRODUCT_ID; 
                    re_i.QUANTITY_STOCK_S = Int32.Parse(r[2].ToString());

                    re_i.QUANTITY_VOUCHER_S = Int32.Parse(r[3].ToString());

                    re_i.SIZE = r[4].ToString();

                    re_i.PRICE = Int32.Parse(r[5].ToString());
                    re_i.AMOUNT = Int32.Parse(r[6].ToString());

                    lstInserted.Add(re_i);
                    
                }
            }

            //list delete
            foreach (RECEIPT_NOTE_ITEM i in UShopDB.RECEIPT_NOTE_ITEMs.Where(o => o.RN_ID.Equals(obj.RN_ID) && o.RECORD_STATUS.Equals("A")))
            {

                bool isFounded = false;
                foreach (DataRow r in dtItems.Rows)
                {
                    int id = Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), r[0].ToString().Length - r[0].ToString().IndexOf('0')));
                    string size = r[4].ToString();

                    if (id.Equals(i.PRODUCT_ID) && i.RN_ID.Equals(obj.RN_ID) && i.SIZE.Equals(size))
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
            foreach (RECEIPT_NOTE_ITEM re in lstDeleted)
            {
                int count = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID == re.PRODUCT_ID && o.SIZE.Equals(re.SIZE)).Count();

                if (count > 0)
                {
                    PRODUCT_SIZE p = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID == re.PRODUCT_ID && o.SIZE.Equals(re.SIZE)).First();
                    if (p.IN_STOCK_QUANTITY - re.QUANTITY_STOCK_S < 0)
                    {
                        PRODUCT pro = null;
                        pro = UShopDB.PRODUCTs.Where(o => o.PRODUCT_ID == p.PRODUCT_ID).SingleOrDefault();
                        strError += "\nSo luong " + pro.PRODUCT_NAME + "khong du de delete.";
                    }
                    break;
                }
                else
                {
                    //ko co thi sao?
                }
            } 
            
            //kiem tra update
            foreach (DataRow r in dtItems.Rows)
            {
                int id = Int32.Parse(r[0].ToString().Substring(r[0].ToString().IndexOf('0'), r[0].ToString().Length - r[0].ToString().IndexOf('0')));
                string size = r[4].ToString();
                string name = r[1].ToString();

                foreach (RECEIPT_NOTE_ITEM re in lstUpdated)
                {
                    if (re.PRODUCT_ID == id)
                    {
                        int sub = Int32.Parse(r[2].ToString());
                        RECEIPT_NOTE_ITEM i = new RECEIPT_NOTE_ITEM();

                        foreach (RECEIPT_NOTE_ITEM rr in lstUpdated)
                        {
                            if (rr.PRODUCT_ID == id)
                            {
                                i = rr;
                                break;
                            }
                        }


                        int count = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID == id && o.SIZE.Equals(size)).Count();

                        if (count > 0)
                        {
                            PRODUCT_SIZE p = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID == id && o.SIZE.Equals(size)).First();
                            if (p.IN_STOCK_QUANTITY + (sub - i.QUANTITY_STOCK_S) < 0)
                            {
                                strError += "\nSo luong " + name + "khong du de delete.";
                            }
                            break;
                        }
                        else
                        {
                            //ko co thi sao?
                        }
                    }
                }
                
            }
            
            //insert khong can quan tam so luong luc truoc nen khong can kiem tra

            //

            if (!strError.Equals(""))
            {
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
                int count = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(r.PRODUCT_ID) && o.SIZE.Equals(r.SIZE)).Count();
                if (count > 0)
                {
                    /*
                    int sub = 0;
                    foreach (DataRow ro in dtItems.Rows)
                    {
                        int id = Int32.Parse(ro[0].ToString().Substring(ro[0].ToString().IndexOf('0'), ro[0].ToString().Length - ro[0].ToString().IndexOf('0')));
                        string size = ro[4].ToString();
                        string name = ro[1].ToString();

                        if (id.Equals(r.PRODUCT_ID) && size.Equals(r.SIZE) && r.RN_ID.Equals(obj.RN_ID) && r.RECORD_STATUS.Equals("A"))
                        {
                            sub = Int32.Parse(ro[2].ToString());
                        }
                    }
                    Console.WriteLine("sub = "+sub);
                     * */
                    if (UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(r.PRODUCT_ID) && o.SIZE.Equals(r.SIZE)).Count()>0)
                        UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(r.PRODUCT_ID) && o.SIZE.Equals(r.SIZE)).First().IN_STOCK_QUANTITY -= r.QUANTITY_STOCK_S;
                }
                r.RECORD_STATUS = "D";
            }

            //update
            foreach (RECEIPT_NOTE_ITEM r in lstUpdated)
            {
                foreach (DataRow ro in dtItems.Rows)
                {
                    int id = Int32.Parse(ro[0].ToString().Substring(ro[0].ToString().IndexOf('0'), ro[0].ToString().Length - ro[0].ToString().IndexOf('0')));
                    string size = ro[4].ToString();
                    string name = ro[1].ToString();
                    int sub = Int32.Parse(ro[2].ToString());

                    if (id == r.PRODUCT_ID)
                    {
                        int count = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(r.PRODUCT_ID) && o.SIZE.Equals(r.SIZE)).Count();
                        if (count > 0)
                        {
                            UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(r.PRODUCT_ID) && o.SIZE.Equals(r.SIZE)).First().IN_STOCK_QUANTITY += (sub-r.QUANTITY_STOCK_S);
                        }
                        r.QUANTITY_STOCK_S += (sub - r.QUANTITY_STOCK_S);
                        break;
                    }
                }

                
            }
            
            //insert
            foreach (RECEIPT_NOTE_ITEM r in lstInserted)
            {
                int count = UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(r.PRODUCT_ID) && o.SIZE.Equals(r.SIZE)).Count();
                if (count > 0)
                {
                    UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(r.PRODUCT_ID) && o.SIZE.Equals(r.SIZE)).First().IN_STOCK_QUANTITY += r.QUANTITY_STOCK_S;
                }
                else
                {
                    PRODUCT_SIZE pro = new PRODUCT_SIZE();
                    pro.PRODUCT_ID = r.PRODUCT_ID??1;
                    pro.SIZE = r.SIZE;
                    pro.IN_STOCK_QUANTITY = r.QUANTITY_STOCK_S;
                    UShopDB.PRODUCT_SIZEs.InsertOnSubmit(pro);
                }
                r.RECORD_STATUS = "A";
                UShopDB.RECEIPT_NOTE_ITEMs.InsertOnSubmit(r);
            }
            /*
            foreach (RECEIPT_NOTE_ITEM r in lstInserted)
            {
                
                r.RECORD_STATUS = "A";
                UShopDB.RECEIPT_NOTE_ITEMs.InsertOnSubmit(r);

                foreach (PRODUCT p in UShopDB.PRODUCTs)
                {
                    if (p.PRODUCT_ID.Equals(r.PRODUCT_ID))
                    {
                        //
                        if (UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("S")).Count() > 0)
                            UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("S")).First().IN_STOCK_QUANTITY += r.QUANTITY_STOCK_S;
                        else
                        {
                            if (r.QUANTITY_STOCK_S>0)
                                UShopDB.PRODUCT_SIZEs.InsertOnSubmit(new PRODUCT_SIZE { PRODUCT_ID = p.PRODUCT_ID, SIZE = "S", IN_STOCK_QUANTITY = r.QUANTITY_STOCK_S });
                        }

                        if (UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("M")).Count() > 0)
                            UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("M")).First().IN_STOCK_QUANTITY += r.QUANTITY_STOCK_M;
                        else
                        {
                            if (r.QUANTITY_STOCK_M > 0)
                                UShopDB.PRODUCT_SIZEs.InsertOnSubmit(new PRODUCT_SIZE { PRODUCT_ID = p.PRODUCT_ID, SIZE = "M", IN_STOCK_QUANTITY = r.QUANTITY_STOCK_M });
                        }

                        if (UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("L")).Count() > 0)
                            UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("L")).First().IN_STOCK_QUANTITY += r.QUANTITY_STOCK_L;
                        else
                        {
                            if (r.QUANTITY_STOCK_L > 0)
                                UShopDB.PRODUCT_SIZEs.InsertOnSubmit(new PRODUCT_SIZE { PRODUCT_ID = p.PRODUCT_ID, SIZE = "L", IN_STOCK_QUANTITY = r.QUANTITY_STOCK_L });
                        }

                        if (UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("XL")).Count() > 0)
                            UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("XL")).First().IN_STOCK_QUANTITY += r.QUANTITY_STOCK_XL;
                        else
                        {
                            if (r.QUANTITY_STOCK_XL > 0)
                                UShopDB.PRODUCT_SIZEs.InsertOnSubmit(new PRODUCT_SIZE { PRODUCT_ID = p.PRODUCT_ID, SIZE = "XL", IN_STOCK_QUANTITY = r.QUANTITY_STOCK_XL });
                        }

                        if (UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("XXL")).Count() > 0)
                            UShopDB.PRODUCT_SIZEs.Where(o => o.PRODUCT_ID.Equals(p.PRODUCT_ID) && o.SIZE.Equals("XXL")).First().IN_STOCK_QUANTITY += r.QUANTITY_STOCK_XXL;
                        else
                        {
                            if (r.QUANTITY_STOCK_XXL > 0)
                                UShopDB.PRODUCT_SIZEs.InsertOnSubmit(new PRODUCT_SIZE { PRODUCT_ID = p.PRODUCT_ID, SIZE = "XXL", IN_STOCK_QUANTITY = r.QUANTITY_STOCK_XXL });
                        }
                        //

                    }
                    break;
                }
            }
            */
            UShopDB.SubmitChanges();

            return "";
        }

        public SUPPLIER getSupplierByCODE(string code)
        {
            SUPPLIER s = new SUPPLIER();
            if (UShopDB.SUPPLIERs.Where(o => o.SUPPLIER_CODE.Equals(code)).Count()>0)
            {
                s = UShopDB.SUPPLIERs.Where(o => o.SUPPLIER_CODE.Equals(code)).First();
            }
            return s;
        }
    }
}
