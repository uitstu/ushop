using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Presenter.Interfaces
{
    public interface IAccountAddingView
    {
        void showInforComponents(ACCOUNT acc, String cusCodeName);
        void refreshAll();
        void showMessageBox(string mB_SUCCESS, MessageBoxIcon information);
        void backPreviousForm();
        void showEmployeeName(List<string> empNameList);
    }
}
