﻿using Model;
using Model.Interfaces;
using Model.Properties;
using Presenter.InterfaceImplement;
using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Elements
{
    public class InvoicePresenter
    {
        private IInvoice model;
        private IInvoiceView invoiceView;
        private IInvoiceAddingView invoiceAddingView;

        private INVOICE updateInvoice;
        private List<INVOICE> invoiceList;
        private List<INVOICE_ITEM> invoiceItemList;

        private List<CUSTOMER> customerList;
        private List<PRODUCT> productList;
        private List<PRODUCT_SIZE> proSizeList;

        private bool isUpdated;
        public IInvoiceView InvoiceView
        {
            get
            {
                return invoiceView;
            }

            set
            {
                invoiceView = value;
            }
        }

        public IInvoiceAddingView InvoiceAddingView
        {
            get
            {
                return invoiceAddingView;
            }

            set
            {
                invoiceAddingView = value;
            }
        }

        

        public InvoicePresenter(IInvoice model)
        {
            isUpdated = false;
            this.model = model;
            productList = new List<PRODUCT>();
            proSizeList = new List<PRODUCT_SIZE>();
            invoiceItemList = new List<INVOICE_ITEM>();
            updateInvoice = new INVOICE();

            invoiceList = new List<INVOICE>();
        }
        //add existed invoice
        public void loadExistedInvoice(String code)
        {

            if (code != null && !code.Equals(""))
            {
                updateInvoice = model.getInvoiceByCode(code,RECORD_STATUS.ACTIVE);
                DataTable table = model.getInvoiceItemListBy(updateInvoice.INVOICE_ID, RECORD_STATUS.ACTIVE);
                if (table == null)
                {
                    table = new DataTable();
                    table = new DataTable();
                    var collumns = table.Columns;
                    collumns.Add("INVOICE_ITEM_CODE");
                    collumns.Add("PRODUCT_NAME");
                    collumns.Add("SIZE");
                    collumns.Add("UNIT");
                    collumns.Add("DISCOUNT_AMOUNT");
                    collumns.Add("QUANTITY");
                    collumns.Add("UNIT_PRICE");
                    collumns.Add("AMOUNT");
                    collumns.Add("NOTE");
                }
                else
                    isUpdated = true;
                invoiceAddingView.showInfoComponents(updateInvoice);
                invoiceAddingView.showInvoiceItemGrid(table);
            }
            else
                invoiceView.showMessageBox("Có lỗi xảy ra! Thử lại sau!", System.Windows.Forms.MessageBoxIcon.Error);
            
        }

        public  bool isValidList<String>(List<String> list)
        {
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    if (item == null || item.Equals("") || item.Equals(Resources.EMPTY_ITEM))
                        return false;
                }
                return true;
            }
            return false;
        }
        public  void loadInvoiceList()
        {
            //List<INVOICE> invoiceList =  model.getInvoicesBy(null, null, RECORD_STATUS.ACTIVE);
            DataTable invoiceTable = model.getInvoiceListBy(0, null, RECORD_STATUS.ACTIVE);
           
            invoiceView.showInvoiceList(invoiceTable);
           
        }
        public void loadCustomerName(String filter, bool doShowPopup)
        {
            //true
            customerList = model.getCustomerBy(RECORD_STATUS.ACTIVE);

            List<String> cusNameList = generateCustomerNameList(filter);
            if (!isValidList(cusNameList))
            {
                cusNameList.Add(Resources.EMPTY_ITEM);
            }
          
            invoiceAddingView.showCustomerName(cusNameList, doShowPopup);
        }

        public void removeInvoice(int indexOfGrid)
        {
            DataTable table = invoiceView.getDataTable();

            string code = table.Rows[indexOfGrid]["INVOICE_CODE"] + "";
            if (code != null && !code.Equals(""))
            {
                if (model.deleteInvoice(code))
                {
                    //delete in grid
                    table.Rows.RemoveAt(indexOfGrid);
                }
                else
                {
                    invoiceView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            else
            {
                invoiceView.showMessageBox(Resources.MB_FAILURE+": mã hóa đơn rỗng.", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public void removeInvoice(String code)
        {
            DataTable table = invoiceView.getDataTable();
            
            if (code != null && !code.Equals(""))
            {
                if (model.deleteInvoice(code))
                {
                    //delete in grid-try loading
                    loadInvoiceList();
                }
                else
                {
                    invoiceView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
                }
            }
            else
            {
                invoiceView.showMessageBox(Resources.MB_FAILURE + ": mã hóa đơn rỗng.", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public void loadSizeOfProduct(String productCodeName)
        {
            List<String> sizeList = new List<string>();
            string code = productCodeName.Split(new char[] { '-' })[0];
            int id = -1;
            PRODUCT current = findProductBy(code);
            id = current.PRODUCT_ID;
            if (id != -1)
                proSizeList = model.getProductSizeBy(id, RECORD_STATUS.ACTIVE);

            if (proSizeList == null || proSizeList.Count <= 0)
            {
                sizeList.Add(Resources.EMPTY_ITEM);
            }
            else
            {
                sizeList = generateSizeList();
            }
            invoiceAddingView.showSizeOfProduct(sizeList);
        }
        public void loadProductName(String filter,bool doShowPopup)
        {
            //true
            productList = model.getProductsBy(RECORD_STATUS.ACTIVE);
            List<String> productNameList = new List<string>();
            if (productList == null || productList.Count <= 0)
            {
                productNameList.Add(Resources.EMPTY_ITEM);
            }
            else
            {
                productNameList = generateProductNameList(filter);
            }
            invoiceAddingView.showProductName(productNameList, doShowPopup);

            /*
            List<String> productNameList = (from DataRow row in productTable.Rows
                                            where Convert.ToString(row["PRODUCT_NAME"]).Contains(filter)
                                            select (String)row["PRODUCT_NAME"]).ToList();*/
            /*
            if (!isValidList(productNameList))
            {
                productNameList.Add(Resources.EMPTY_ITEM);
            }
            if (filter != null && !filter.Equals(""))
            {
                List<String> filterList = new List<String>();
                foreach (var productName in productNameList)
                {
                    if (productName.Contains(filter))
                        filterList.Add(productName);
                }
                invoiceAddingView.showProductName(filterList, doShowPopup);
            }
            else
                invoiceAddingView.showProductName(productNameList, doShowPopup);*/
        }
       
        public String getTemperatoryCode()
        {

            return ((DataModel)model).getCODE("INV", model.getInvoiceCount() + 1);
        }

        public PRODUCT findProductBy(String code)
        {
            PRODUCT ret = null;
            foreach (var item in productList)
            {
                if (item.PRODUCT_CODE.Equals(code))
                {
                    ret = item;
                    break;
                }
            }
            return ret;
        }

        public PRODUCT_SIZE findProductSizeBy(int id, String size)
        {
            PRODUCT_SIZE ret = null;
            foreach (var item in proSizeList)
            {
                if (item.PRODUCT_ID == id && item.SIZE.Equals(size))
                {
                    ret = item;
                    break;
                }
            }
            return ret;
        }
        public CUSTOMER findCustomerBy(String code)
        {
            CUSTOMER ret = null;
            foreach (var item in customerList)
            {
                if (item.CUS_CODE.Equals(code))
                {
                    ret = item;
                    break;
                }
            }
            return ret;
        }
        public CUSTOMER findCustomerBy(int id)
        {
            CUSTOMER ret = null;
            foreach (var item in customerList)
            {
                if (item.CUS_ID.Equals(id))
                {
                    ret = item;
                    break;
                }
            }
            return ret;
        }


        public List<String> generateProductNameList(String filter)
        {

            bool isFilter = (filter != null && !filter.Equals(""));
            List<String> productNameList = new List<string>();
            foreach (var pro in productList)
            {
               
                    if (isFilter )
                    {
                        if (pro.PRODUCT_NAME.Contains(filter))
                        {
                            productNameList.Add(pro.PRODUCT_CODE+"-"+pro.PRODUCT_NAME);
                        }
                    }
                    else
                        productNameList.Add(pro.PRODUCT_CODE + "-"+ pro.PRODUCT_NAME);
               
            }

            if (!isValidList(productNameList))
            {
                productNameList.Add(Resources.EMPTY_ITEM);
            }
            return productNameList;
        }

        public List<String> generateSizeList()
        {
            List<String> sizeList = new List<string>();
            foreach (var item in proSizeList)
            {
                if (item != null && item.IN_STOCK_QUANTITY > 0)
                {
                    sizeList.Add(item.SIZE);
                }
            }

            if (!isValidList(sizeList))
            {
                sizeList.Add(Resources.EMPTY_ITEM);
            }
            return sizeList;
        }
        public List<String> generateCustomerNameList(String filter)
        {

            bool isFilter = (filter != null && !filter.Equals(""));
            List<String> cusNameList = new List<String>();
            foreach (var cus in customerList)
            {

                if (isFilter)
                {
                    if (cus.CUS_NAME.Contains(filter) || cus.CUS_CODE.Contains(filter))
                    {
                        cusNameList.Add(cus.CUS_CODE+"-"+cus.CUS_NAME);
                    }
                }
                else
                    cusNameList.Add(cus.CUS_CODE + "-" + cus.CUS_NAME);

            }

            if (!isValidList(cusNameList))
            {
                cusNameList.Add(Resources.EMPTY_ITEM);
            }
            return cusNameList;
        }
        
        private bool checkValidPaymentMethod(string paymentMethod)
        {
            if (paymentMethod != null && !paymentMethod.Equals("") && !paymentMethod.Equals(Resources.EMPTY_ITEM))
                return true;
            return false;
        }

        private bool checkValidCusCode(string cuscode)
        {
            if(cuscode != null && !cuscode.Equals(""))
            {
                return true;
            }
            return false;
        }
        private bool checkValidVAT(string vat) {
            try { 
                double ret = Convert.ToDouble(vat);
                if (ret >= 0)
                    return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            return false;
        }
        private bool checkValidDate(DateTime date)
        {
            try
            {
                if(date.CompareTo(DateTime.Now) <= 0)
                {
                    return true;
                }
            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return false;
        }

        private bool checkValidTotalPayment(string totalPayment)
        {

            try
            {
                double ret = Convert.ToDouble(totalPayment);
                if (ret >= 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return false;
        }

        private bool checkValidTotalAmount(string totalAmount)
        {

            try
            {
                double ret = Convert.ToDouble(totalAmount);
                if (ret >= 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return false;
        }

        public void insertInvoice(string cusCode, string paymentMethod, string vAT, string note, DateTime date,string totalPayment,string totalAmount)
        {
            String error = Resources.MB_FAILURE;
            try {

                int cusId = 0;
                if (!checkValidCusCode(cusCode))
                {
                    error += ": Không tìm thấy khách hàng này trong CSDL.";
                    throw new Exception();
                }
                else if(!checkValidVAT(vAT))
                {
                    error += ": VAT không thể chứa kí tự đặc biệt, chữ và luôn >=0.";
                    throw new Exception();
                }
                else if (!checkValidDate(date))
                {
                    error += ": Ngày lập phiếu không thể lớn hơn ngày hiện tại.";
                    throw new Exception();
                }
                else if (!checkValidTotalPayment(totalPayment))
                {
                    error += ": tổng trả không thể chứa kí tự đặc biệt, chữ và luôn >=0.";
                    throw new Exception();
                }
                else if (!checkValidTotalAmount(totalAmount))
                {
                    error += ": tổng tiền không thể chứa kí tự đặc biệt, chữ và luôn >=0.";
                    throw new Exception();
                }

                cusId = findCustomerBy(cusCode).CUS_ID;
                INVOICE invoice = new INVOICE();
                invoice.SELLER_ID = AccountPresenter.currentEmployee.EMP_ID;
                invoice.BUYER_ID = cusId;
                invoice.PAYMENT_METHOD = paymentMethod;
                invoice.DATE = date;
                invoice.NOTE = note;
                invoice.TOTAL_AMOUNT = Convert.ToDouble(totalAmount);
                invoice.TOTAL_PAYMENT = Convert.ToDouble(totalPayment);
                invoice.TOTAL_SALE = 0;
                invoice.VAT_AMOUNT = 0;
                invoice.VAT_RATE = Convert.ToDouble(vAT);
                invoice.RECORD_STATUS = ((char)RECORD_STATUS.ACTIVE) + "";
                //put into invoiceItemList
                DataTable table = InvoiceAddingView.getInvoiceItemDataTable();
                invoiceItemList.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    var currRow = table.Rows[i];
                    String proCodeName = currRow["PRODUCT_NAME"] + "";
                    String proCode = proCodeName.Split(new char[] { '-' })[0];
                    INVOICE_ITEM item = new INVOICE_ITEM();
                    item.PRICE = Convert.ToSingle(currRow["UNIT_PRICE"]);
                    item.QUANTITY = Convert.ToInt16(currRow["QUANTITY"]);
                    item.SIZE = currRow["SIZE"] + "";
                    item.DISCOUNT = Convert.ToSingle(currRow["DISCOUNT_AMOUNT"]);
                    item.AMOUNT = Convert.ToDouble(currRow["AMOUNT"]);
                    item.RECORD_STATUS = ((char)RECORD_STATUS.ACTIVE) + "";
                    item.PRODUCT_ID = findProductBy(proCode).PRODUCT_ID;
                    invoiceItemList.Add(item);
                }
                //update or insert
                if (!isUpdated)
                {
                


                    if (model.addInvoice(invoice, invoiceItemList))
                    {
                        invoice = new INVOICE();
                        invoiceItemList.Clear();
                        invoiceAddingView.showMessageBox(Resources.MB_SUCCESS, System.Windows.Forms.MessageBoxIcon.Information);
                        invoiceAddingView.resetAll();
                    }
                    else
                    {
                        invoiceAddingView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
                    }
                }
                else
                {
                    updateInvoice.BUYER_ID = invoice.BUYER_ID;
                    updateInvoice.DATE = invoice.DATE;
                    updateInvoice.NOTE = invoice.NOTE;
                    updateInvoice.PAYMENT_METHOD = invoice.PAYMENT_METHOD;
                    updateInvoice.SELLER_ID = invoice.SELLER_ID;
                    updateInvoice.TOTAL_AMOUNT = invoice.TOTAL_AMOUNT;
                    updateInvoice.TOTAL_PAYMENT = invoice.TOTAL_PAYMENT;
                    updateInvoice.TOTAL_SALE = invoice.TOTAL_SALE;
                    updateInvoice.VAT_AMOUNT = invoice.VAT_AMOUNT;
                    updateInvoice.VAT_RATE = invoice.VAT_RATE;
                    updateInvoice.RECORD_STATUS = invoice.RECORD_STATUS;
                    
                    if (model.updateInvoice(updateInvoice, invoiceItemList))
                    {
                        invoice = new INVOICE();
                        invoiceItemList.Clear();
                        invoiceAddingView.showMessageBox(Resources.MB_SUCCESS, System.Windows.Forms.MessageBoxIcon.Information);
                        invoiceAddingView.resetAll();
                    }
                    else
                    {
                        invoiceAddingView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                invoiceAddingView.showMessageBox(error, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }



        public void addItem(String productCodeName,String size)
        {
            if (productCodeName != null && !productCodeName.Equals("") && !productCodeName.Equals(Resources.EMPTY_ITEM)
                && size != null && !size.Equals("") && !size.Equals(Resources.EMPTY_ITEM)
                && productList != null && productList.Count > 0
                && proSizeList != null && proSizeList.Count > 0)
            {
                
                
                List<String> paramList = new List<String>();
                String[] splitString = productCodeName.Split(new char[] { '-' });
                String proCode = splitString[0];
                String proName = splitString[1];
                PRODUCT curProduct = findProductBy(proCode);
                PRODUCT_SIZE currProSize = findProductSizeBy(curProduct.PRODUCT_ID,size);
                DataTable table = InvoiceAddingView.getInvoiceItemDataTable();
                
               //check instock quanntity
                if(currProSize.IN_STOCK_QUANTITY <= 0)
                {
                    invoiceAddingView.showMessageBox("Sản phẩm đã hết hàng!", System.Windows.Forms.MessageBoxIcon.Information);
                    return;
                }
                //minus taken
                currProSize.IN_STOCK_QUANTITY--;
                //check exist rows
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    String itemProCodeName = table.Rows[i]["PRODUCT_NAME"] + "";
                    String itemSize = table.Rows[i]["SIZE"]+"";
                    if (itemProCodeName.Equals(productCodeName) && size.Equals(itemSize))
                    {
                        int itemQuantity = Convert.ToInt16(table.Rows[i]["QUANTITY"]);
                        float sale= Convert.ToSingle(table.Rows[i]["DISCOUNT_AMOUNT"]);
                        itemQuantity++;
                        table.Rows[i]["QUANTITY"] = itemQuantity;
                        table.Rows[i]["AMOUNT"] = calculateAmount(itemQuantity,(float) curProduct.COST_PRICE, sale);
                        sumTotalAmount();
                        return;
                    }
                }

               /* INVOICE_ITEM item = null;
                if ((item = isExistItem(curProduct.PRODUCT_ID, size) ) != null)
                {
                    item.QUANTITY = item.QUANTITY + 1;
                    item.AMOUNT = item.QUANTITY * item.PRICE;
                }
                
                item = new INVOICE_ITEM();
                // miss ITEM_ID, ITEM_CODE, INVOICE_ID
                item.PRICE = curProduct.COST_PRICE;
                item.PRODUCT_ID = curProduct.PRODUCT_ID;
                item.QUANTITY = 1;
                item.SIZE = size;
                item.AMOUNT = item.QUANTITY * item.PRICE;
                item.DISCOUNT = 0;
                item.RECORD_STATUS = RECORD_STATUS.ACTIVE+"";

                //add into list
                invoiceItemList.Add(item);*/


                //create params
                float discount = (float)curProduct.SALE_AMOUNT;
                int quantity = 1;
                double amount = calculateAmount(quantity, (float)curProduct.COST_PRICE,discount);
                String note = "";

                paramList.Add(table.Rows.Count+1+"");
                paramList.Add(productCodeName);
                paramList.Add(size);
                paramList.Add(curProduct.UNIT);

                paramList.Add(discount + "");
                paramList.Add(quantity + "");
                paramList.Add(curProduct.COST_PRICE + "");
                paramList.Add(amount+"");
                paramList.Add(note);

                //add into grid
                invoiceAddingView.addItemIntoGrid(paramList.ToArray());
                sumTotalAmount();

                //remove this product out of product list 
                //productList.Remove(curProduct);
                //remove this size out of prosize list
                //proSizeList.Remove(currProSize);

                //update ui
                //invoiceAddingView.showProductName(generateProductNameList(null), false);
                //update ui
                //invoiceAddingView.showSizeOfProduct(generateSizeList());

            }
            else
            {
                invoiceAddingView.showMessageBox("Trường Tên sản phẩm, Kích cỡ chưa được chọn hoặc không hợp lệ", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public double calculateAmount( int quantity, float unitPrice, float discount)
        {
            return (unitPrice * quantity) - (discount * quantity);
        }

        public void sumTotalAmount()
        {
            DataTable table = invoiceAddingView.getInvoiceItemDataTable();
            double totalAmount = 0;
            for(int i = 0; i < table.Rows.Count; i++)
            {
                totalAmount += Convert.ToDouble( table.Rows[i]["AMOUNT"]);
            }
            invoiceAddingView.showTotalAmount(totalAmount);
        }

        private INVOICE_ITEM isExistItem(int pRODUCT_ID, string size)
        {
            foreach (var item in invoiceItemList)
            {
                if (item.PRODUCT_ID == pRODUCT_ID && item.SIZE.Equals(size))
                    return item;
            }
            return null;
        }

        public void removeItem(int indexOfGrid)
        {
            DataTable table = invoiceAddingView.getInvoiceItemDataTable();

            //resort
            for(int i= indexOfGrid+1; i < table.Rows.Count; i++)
            {
                table.Rows[i][0] = Convert.ToInt16( table.Rows[i][0]) - 1;
            }
            //delete in list
            //invoiceItemList.RemoveAt(indexOfGrid);
            //delete in grid
            table.Rows.RemoveAt(indexOfGrid);
        }
        public void checkValidPayment(String payment, String total)
        {
            try { 
                double totalAmount = Convert.ToDouble(total);
                double totalPayment = Convert.ToDouble(payment);
            
                if (totalPayment > totalAmount)
                {
                    invoiceAddingView.showTotalPayment(totalAmount);
                }
                else if(totalPayment <= 0)
                {
                    invoiceAddingView.showTotalPayment(0);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                invoiceAddingView.showTotalPayment(0);
            }
        }
    }
}
