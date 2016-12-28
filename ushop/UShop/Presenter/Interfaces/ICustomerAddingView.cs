using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Presenter.Interfaces
{
    public interface ICustomerAddingView
    {
        void showInforComponents(CUSTOMER cus);
        void showMessageBox(string mB_SUCCESS, MessageBoxIcon information);
        void refreshAll();
        void backPreviousForm();
    }
}
