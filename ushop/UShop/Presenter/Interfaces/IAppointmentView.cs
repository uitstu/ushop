using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Interfaces
{
    public interface IAppointmentView
    {
        void showAppointmentList(DataTable table);
        DataTable getApppointmentTable();
        void showMessageBox(string mB_FAILURE, MessageBoxIcon information);
    }
}
