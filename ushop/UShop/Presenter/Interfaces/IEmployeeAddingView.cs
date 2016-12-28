using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interfaces
{
    public interface IEmployeeAddingView
    {
        //show msg dialog box
        void showMessageBox(String msg, System.Windows.Forms.MessageBoxIcon type);
        //back to caller
        void backPreviousForm();
        //refresh all components
        void refreshAll();
        //show employee infor
        void showInforComponents(EMPLOYEE emp);
    }
}
