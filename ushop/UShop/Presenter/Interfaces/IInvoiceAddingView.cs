using System;
using System.Collections.Generic;
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
        //load cus name into combo box
        void showCustomerName(List<String> customerNames, bool doShowPopup);
    }
}
