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

        public void loadProductName(String filter,bool doShowPopup)
        {
            //true
            List<String> productNameList = model.getProductNameBy(RECORD_STATUS.ACTIVE);
            //test
            productNameList.Add("Ao thun");
            productNameList.Add("Ao dam");
            productNameList.Add("Ao dai");
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
                invoiceAddingView.showProductName(productNameList, doShowPopup);
        }
        public void loadCustomerName(String filter,bool doShowPopup)
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
        public String getTemperatoryCode()
        {
            
            return ((DataModel)model).getCODE("INV", model.getInvoiceCount());
        }

    }
}
