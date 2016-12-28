using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Interfaces
{
    public interface IEmployeeView
    {
        //show msg dialog box
        void showMessageBox(String msg, MessageBoxIcon type);
        //get table
        DataTable getEmployeeTable();
        //show employee list
        void showEmployeeList(DataTable table);
         
    }
}
