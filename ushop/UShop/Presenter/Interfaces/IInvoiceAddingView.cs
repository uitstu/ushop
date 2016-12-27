using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Interfaces
{
    public interface IInvoiceAddingView
    { 
        //show msg dialog box
        void showMessageBox(String msg, MessageBoxIcon type);
        //load product into combo box
        void showProductName(List<String> productNames, bool doShowPopup);
        //load size of product into combo box
        void showSizeOfProduct(List<String> sizeList);
        //load cus name into combo box
        void showCustomerName(List<String> customerNames, bool doShowPopup);
        //reset item adding components
        void resetItemAddingComponents();
        //reset all components
        void resetAll();

        //add new item into grid item
        void addItemIntoGrid(String[] invoiceItem);

        //set value for textbox
        void showTotalPayment(double totalPayment);
        //set value for textbox
        void showTotalAmount(double totalAmount);
        //put table into gridview
        void showInvoiceItemGrid(DataTable table);
        //load existed invoice information
        void showInfoComponents(INVOICE invoice);
        //get DataTable of Invoice Items grid view 
        DataTable getInvoiceItemDataTable();
    }
}
