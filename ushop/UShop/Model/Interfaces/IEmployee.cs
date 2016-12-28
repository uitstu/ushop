using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IEmployee
    {
        //get employeee table
        DataTable getEmployeeListBy(RECORD_STATUS status);
        //remove an employee with id
        bool removeEmployee(int id);

        //remove an employee with code
        bool deleteEmployee(String code);
        //update an employee
        bool updateEmployee(EMPLOYEE emp);
        //add new one
        bool addEmployee(EMPLOYEE emp);
        //get Employee list count
        int getEmployeeCount();
        EMPLOYEE getEmployeeBy(string empCode, RECORD_STATUS aCTIVE);
    }
}
