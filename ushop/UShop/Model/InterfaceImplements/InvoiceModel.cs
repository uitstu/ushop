using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Model.InterfaceImplements
{
    public class InvoiceModel : DataModel, IInvoice
    {
        public INVOICE getInvoiceByCode(string code)
        {

            INVOICE invoice = new INVOICE();

            foreach (INVOICE item in UShopDB.INVOICEs)
            {
                if (item.Equals(code))
                {
                    invoice = item;
                    break;
                }
            }

            return invoice;
        }

        public bool addInvoice(INVOICE invoice)
        {
            try
            {
                UShopDB.INVOICEs.InsertOnSubmit(invoice);
                UShopDB.SubmitChanges();
                return  true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool updateInvoice(INVOICE updated)
        {
            int queryid = updated.INVOICE_ID;
            if (queryid > 0)
            {
                try { 
                    var item = UShopDB.INVOICEs.Where(o => o.INVOICE_ID == queryid).SingleOrDefault();

                    item.INVOICE_CODE = updated.INVOICE_CODE;
                    item.BUYER_ID = updated.BUYER_ID;
                    item.DATE = updated.DATE;
                    item.NOTE = updated.NOTE;
                    item.PAYMENT_METHOD = updated.PAYMENT_METHOD;
                    item.TOTAL_AMOUNT = updated.TOTAL_AMOUNT;
                    item.TOTAL_PAYMENT = updated.TOTAL_PAYMENT;
                    item.VAT_AMOUNT = updated.VAT_AMOUNT;
                    item.VAT_RATE = updated.VAT_RATE;
                    item.SELLER_ID = updated.SELLER_ID;

                    UShopDB.SubmitChanges();
                    return true;
                }catch(ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }catch(InvalidCastException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return false;
        }
        public bool deleteInvoice(int id)
        {
            int queryid = id;
            if (queryid > 0)
            {
                try
                {
                    var item = UShopDB.INVOICEs.Where(o => o.INVOICE_ID == queryid).SingleOrDefault();
                    item.RECORD_STATUS = RECORD_STATUS.INACTIVE +"";
                    UShopDB.SubmitChanges();
                    return true;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return false;
        }

        public bool deleteInvoice(string code)
        {
            try
            {
                var item = UShopDB.INVOICEs.Where(o => o.INVOICE_CODE == code).SingleOrDefault();
                item.RECORD_STATUS = RECORD_STATUS.INACTIVE + "";
                UShopDB.SubmitChanges();
                return true;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
        
            return false;
        }

        public List<INVOICE_ITEM> getInvoiceItems(int invoiceId)
        {
            return null;
        }

        public List<INVOICE> getInvoicesBy(String byEmployee, String date, RECORD_STATUS status)
        {
            List<INVOICE> invoiceList = null;
            //try
            //{

            //    var queryResult = UShopDB.INVOICEs.Where
            //        (o =>
            //          (byEmployee != null? o.SELLER_ID == byEmployee: true)         
            //          && (date != null ? o.DATE.ToString().Equals(date): true)
            //          && (status != 0 ? o.RECORD_STATUS.Equals(status+""): true )       //if status = 0 -> independent record status
            //        );
            //    invoiceList = queryResult.ToList();
            //}
            //catch (ArgumentNullException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            return invoiceList;
        }

        public DataTable getInvoiceListBy(int empId, string date, RECORD_STATUS status)
        {
            DataTable table = null;
            try {
                var result = from inv in UShopDB.INVOICEs
                             join emp in UShopDB.EMPLOYEEs
                             on inv.SELLER_ID equals emp.EMP_ID
                             into final1
                             from empinv in final1.DefaultIfEmpty()

                             join cus in UShopDB.CUSTOMERs
                             on inv.BUYER_ID equals cus.CUS_ID
                             into final2
                             from empinvcus in final2.DefaultIfEmpty()

                             where
                             (empId != 0 ? empinv.EMP_ID == empId : true) 
                             && (date != null ? inv.DATE.ToString().Equals(date) : true)
                             && (status != 0 ? inv.RECORD_STATUS.Equals((char)status) : true) 
                             select new
                             {
                                 inv.INVOICE_CODE,
                                 inv.TOTAL_AMOUNT,
                                 inv.TOTAL_PAYMENT,
                                 inv.PAYMENT_METHOD,
                                 empinv.EMP_NAME,
                                 empinvcus.CUS_NAME,
                                 inv.DATE
                             };
                table = new DataTable();
                var collumns = table.Columns;
                collumns.Add("Mã hóa đơn");
                collumns.Add("Tổng tiền");
                collumns.Add("Đã thanh toán");
                collumns.Add("PTTT");
                collumns.Add("Tên KH");
                collumns.Add("Tên NVBH");
                collumns.Add("Ngày lập HĐ");

                var rows = table.Rows;
                foreach(var item in result)
                {
                    rows.Add(item);   
                }
            }catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                
            }
            //DataTable dt = new DataTable();
            //dt.Columns.Add("RN_ID");
            //dt.Columns.Add("RN_CODE");
            //dt.Columns.Add("SUPPLIER_ID");
            //dt.Columns.Add("SUPPLIER_NAME");
            //dt.Columns.Add("PREPARER_ID");
            //dt.Columns.Add("EMP_NAME");
            //dt.Columns.Add("ISSUED_DATE");
            //dt.Columns.Add("ACCOUNTING_DATE");
            //dt.Columns.Add("ACCOUNTED");
            //dt.Columns.Add("TOTAL");
            //dt.Columns.Add("NOTE");
            //dt.Columns.Add("RECORD_STATUS");

            //foreach (var o in result.Where(o => o.RECORD_STATUS.Equals("A")))
            //{
            //    dt.Rows.Add(o.RN_ID, o.RN_CODE, o.SUPPLIER_ID, o.SUPPLIER_NAME, o.PREPARER_ID, o.EMP_NAME,
            //        o.ISSUED_DATE, o.ACCOUNTING_DATE, o.ACCOUNTED, o.TOTAL, o.NOTE, o.RECORD_STATUS);
            //}
            return table;
        }

        public List<String> getProductNameBy(RECORD_STATUS status)
        {
            List<String> productList = null;
            try
            {

                var queryResult = UShopDB.PRODUCTs
                    .Where
                    (o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)       //if status = 0 -> independent record status
                    )
                    .Select(o => o.PRODUCT_NAME);
                productList = queryResult.ToList();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return productList;
        }

        public int getInvoiceCount()
        {
            var queryResult = UShopDB.INVOICEs.Count();
            return queryResult;
        }

        public List<String> getCustomerNameBy(RECORD_STATUS status)
        {
            List<String> cusList = null;
            try
            {

                var queryResult = UShopDB.CUSTOMERs
                    .Where
                    (o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)       //if status = 0 -> independent record status
                    )
                    .Select(o => o.CUS_NAME);
                cusList = queryResult.ToList();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return cusList;
        }

        //public DataTable getProductsBy(RECORD_STATUS status)
        //{
        //    DataTable table = null;
        //    try
        //    {
        //        var result = UShopDB.PRODUCTs
        //            .Where(o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)).DefaultIfEmpty();
        //        table = new DataTable();
        //        table.Rows.Add(result.ToArray());
        //        table.Columns.Add("PRODUCT_ID");
        //        table.Columns.Add("PRODUCT_CODE");
        //        table.Columns.Add("PRODUCT_NAME");
        //        table.Columns.Add("CATEGORY_ID");
        //        table.Columns.Add("SELLING_PRICE");
        //        table.Columns.Add("COST_PRICE");
        //        table.Columns.Add("DISCOUNT_AMOUNT");
        //        table.Columns.Add("DESCRIPTION");
        //        table.Columns.Add("PRODUCER");
        //        table.Columns.Add("ORIGIN");
        //        table.Columns.Add("IMAGE_SRC");
        //        table.Columns.Add("RECORD_STATUS");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);

        //    }
        //    return table;
        //}

        //public DataTable getSizeBy(int proid, RECORD_STATUS status)
        //{
        //    throw new NotImplementedException();
        //}


        public List<PRODUCT_SIZE> getProductSizeBy(int proid, RECORD_STATUS status)
        {
            List<PRODUCT_SIZE> prosizeList = null;
            try
            {

                var queryResult = UShopDB.PRODUCT_SIZEs
                    .Where
                    (o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)
                           &&(proid >= 0 ? o.PRODUCT_ID == proid : true)
                    ).DefaultIfEmpty();
                prosizeList = queryResult.ToList();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return prosizeList;
        }

        public List<PRODUCT> getProductsBy(RECORD_STATUS status)
        {
            List<PRODUCT> proList = null;
            try
            {

                var queryResult = UShopDB.PRODUCTs
                    .Where
                    (o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)       //if status = 0 -> independent record status
                    ).DefaultIfEmpty();
                proList = queryResult.ToList();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return proList;
        }
    }
}
