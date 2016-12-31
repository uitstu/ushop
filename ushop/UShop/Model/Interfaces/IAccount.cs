using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IAccount
    {
        List<ACCOUNT> loadAccount();
        bool addAccount(ACCOUNT obj);
        bool deleteAccount(String id);
        bool updateAccount(ACCOUNT obj);

        ACCOUNT findAccount(String id, String password);
        EMPLOYEE getEmployeeBy(string accCode,RECORD_STATUS status);
        DataTable getAccountListBy(RECORD_STATUS aCTIVE);

        ACCOUNT getAccountByEmpCode(string empCode, RECORD_STATUS status);
        ACCOUNT getAccountBy(string accCode, RECORD_STATUS aCTIVE);
        List<EMPLOYEE> getEmployeesBy(RECORD_STATUS aCTIVE);
    }
}
