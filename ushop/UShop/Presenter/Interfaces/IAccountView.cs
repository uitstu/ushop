using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Interface
{
    public interface IAccountView
    {
        //C changed them to IAccountLoginView 
        //void loadAccounts(List<ACCOUNT> listObj);
        //void veryfyAccount(String message);

        //new for account listing
        void showAccountList(DataTable table);
        DataTable getAccountTable();
        void showMessageBox(string mB_FAILURE, MessageBoxIcon information);
    }
}
