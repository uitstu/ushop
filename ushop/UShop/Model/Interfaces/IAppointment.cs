using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IAppointment
    {
        List<CUSTOMER> getCustomersBy(RECORD_STATUS status);
        List<EMPLOYEE> getEmployeesBy(RECORD_STATUS status);
        APPOINTMENT getAppointmentBy(string appCode, RECORD_STATUS status);
        DataTable getAppointmentListBy(RECORD_STATUS status);
        int getAppointmentCount();
        bool deleteAppointment(string code);
        bool addAppointment(APPOINTMENT app);
        bool updateAppointment(APPOINTMENT app);
    }
}
