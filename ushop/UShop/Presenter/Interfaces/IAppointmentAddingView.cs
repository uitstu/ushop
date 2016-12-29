using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Presenter.Interfaces
{
    public interface IAppointmentAddingView
    {
        void showMessageBox(string mB_FAILURE, MessageBoxIcon information);
        void refreshAll();
        void backPreviousForm();
        void showInforComponents(APPOINTMENT app, string cusCodeName, string empName);
        void showCustomerName(List<String> cusNameList);
    }
}
