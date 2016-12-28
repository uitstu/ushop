using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Interfaces
{
    public interface ICustomerView
    {
        void showCustomerList(DataTable table);
        DataTable getCustomerTable();
        void showMessageBox(string mB_FAILURE, MessageBoxIcon information);
    }
}
