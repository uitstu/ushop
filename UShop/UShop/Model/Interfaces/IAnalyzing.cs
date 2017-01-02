using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IAnalyzing
    {
        List<string> getEmpList();
        List<string> getCusList();
        List<INVOICE> getInvoiceList(DateTime begin, DateTime end, int empID, int cusID);
        List<INVOICE> getInvoiceList(DateTime begin, DateTime end, int empID, bool isEmp);
        List<INVOICE> getInvoiceList(DateTime begin, DateTime end, int cusID);
        List<INVOICE> getInvoiceList(DateTime begin, DateTime end);
    }
}
