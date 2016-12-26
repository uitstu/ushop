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
    //this is an interface for invoice list form    (VIEW)
    public interface IInvoiceView
    {
        //show msg dialog box
        void showMessageBox(String msg, MessageBoxIcon type);
        //load into grid view
        void showInvoiceList(DataTable invoiceList);
       
    }
}
