using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface ICustomer
    {
        DataTable getCustomerListBy(RECORD_STATUS aCTIVE);
        CUSTOMER getCustomerBy(string cusCode, RECORD_STATUS aCTIVE);
        int getCustomerCount();
        bool deleteCustomer(string v);
        bool addCustomer(CUSTOMER cus);
        bool updateCustomer(CUSTOMER cus);
    }
}
