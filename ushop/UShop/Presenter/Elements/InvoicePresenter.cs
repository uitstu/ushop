using Model;
using Model.Interfaces;
using Model.Properties;
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

        private DataTable gridDataInvoiceItems;
        private List<PRODUCT> productList;
        private List<PRODUCT_SIZE> proSizeList;
        private List<INVOICE_ITEM> invoiceItemList;
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
            this.model = model;
            productList = new List<PRODUCT>();
            proSizeList = new List<PRODUCT_SIZE>();
            invoiceItemList = new List<INVOICE_ITEM>();

            //initInvoiceItemDataTable();
        }

        private void initInvoiceItemDataTable()
        {
            //gridDataInvoiceItems = new DataTable();
            //var cols=  gridDataInvoiceItems.Columns;
            //cols.Add("")
        }

        public  bool isValidList<T>(List<T> list)
        {
            if (list != null && list.Count > 0)
                return true;
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
            List<String> cusNameList = model.getCustomerNameBy(RECORD_STATUS.ACTIVE);

            if (!isValidList(cusNameList))
            {
                cusNameList.Add(Resources.EMPTY_ITEM);
            }
            if (filter != null && !filter.Equals(""))
            {
                List<String> filterList = new List<String>();
                foreach (var customerName in cusNameList)
                {
                    if (customerName.Contains(filter))
                        filterList.Add(customerName);
                }
                invoiceAddingView.showCustomerName(filterList, doShowPopup);
            }
            else
                invoiceAddingView.showCustomerName(cusNameList, doShowPopup);
        }
        public void loadProductName(String filter,bool doShowPopup)
        {
            //true
            productList = model.getProductsBy(RECORD_STATUS.ACTIVE);
            List<String> productNameList = new List<string>();
            if (!isValidList(productList))
            {
                productNameList.Add(Resources.EMPTY_ITEM);
            }
            else
            {
                bool isFilter = ( filter != null && !filter.Equals(""));
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

            return ((DataModel)model).getCODE("INV", model.getInvoiceCount());
        }
        public void loadSizeOfProduct(String productCodeName)
        {
            List<String> sizeList = new List<string>();
            string code = productCodeName.Split(new char[] { '-' })[0];
            int id = -1;
            foreach (var item in productList)
            {
                if (item.PRODUCT_CODE.Equals(code))
                {
                    id = item.PRODUCT_ID;
                    break;
                }
            }
            if(id != -1)
                proSizeList = model.getProductSizeBy(id, RECORD_STATUS.ACTIVE);

            if (!isValidList(proSizeList))
            {
                sizeList.Add(Resources.EMPTY_ITEM);
            }
            else
            {
                foreach (var item in proSizeList)
                {
                    if(item != null &&  item.IN_STOCK_QUANTITY > 0)
                    {
                        sizeList.Add(item.SIZE);
                    }
                }

                if (!isValidList(sizeList))
                {
                    sizeList.Add(Resources.EMPTY_ITEM);
                }
            }
            invoiceAddingView.showSizeOfProduct(sizeList);
        }


        public void addItem(String productCodeName,String size)
        {
            if (productCodeName != null && !productCodeName.Equals("")
                && size != null && !size.Equals("")
                && isValidList(productList) 
                && isValidList(proSizeList))
            {
                
                //DataRow row = gridDataInvoiceItems.NewRow();
                
                List<String> paramList = new List<String>();
                paramList.Add("0");
                paramList.Add("");
                paramList.Add(productCodeName.Split(new char[] { '-' })[1]);
                paramList.Add(size);
                paramList.Add("");
                paramList.Add("");
                paramList.Add("0");
                paramList.Add("0");
                paramList.Add("0");
                paramList.Add("0");
                invoiceAddingView.addItemIntoGrid(paramList.ToArray());
            }
            else
            {
                invoiceAddingView.showMessageBox("Trường Tên sản phẩm hoặc Kích cỡ chưa được chọn", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
