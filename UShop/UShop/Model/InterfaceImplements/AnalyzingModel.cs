using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfaceImplement
{
    public class AnalyzingModel : DataModel, IAnalyzing
    {
        public List<string> getEmpList()
        {
            List<string> lst = new List<string>();

            foreach (EMPLOYEE e in UShopDB.EMPLOYEEs)
            {
                string str;
                str = e.EMP_CODE + " - " + e.EMP_NAME;
                lst.Add(str);
            }

            return lst;
        }

        public List<string> getCusList()
        {
            List<string> lst = new List<string>();

            foreach (CUSTOMER c in UShopDB.CUSTOMERs)
            {
                string str;
                str = c.CUS_CODE + " - " + c.CUS_NAME;
                lst.Add(str);
            }

            return lst;
        }

        public List<INVOICE> getInvoiceList(DateTime begin, DateTime end, int empID, int cusID)
        {
            DateTime b = new DateTime(begin.Year, begin.Month, begin.Day, 0, 0, 0);
            DateTime e = new DateTime(end.Year, end.Month, end.Day, 23, 59, 59);

            return UShopDB.INVOICEs.Where(o => o.DATE >= b && o.DATE <= e && o.SELLER_ID.Equals(empID) && o.BUYER_ID.Equals(cusID)).ToList();
        }

        public List<INVOICE> getInvoiceList(DateTime begin, DateTime end, int empID, bool isEmp)
        {
            DateTime b = new DateTime(begin.Year, begin.Month, begin.Day, 0, 0, 0);
            DateTime e = new DateTime(end.Year, end.Month, end.Day, 23, 59, 59);

            return UShopDB.INVOICEs.Where(o => o.DATE >= b && o.DATE <= e && o.SELLER_ID.Equals(empID)).ToList();
        }

        public List<INVOICE> getInvoiceList(DateTime begin, DateTime end, int cusID)
        {
            DateTime b = new DateTime(begin.Year, begin.Month, begin.Day, 0, 0, 0);
            DateTime e = new DateTime(end.Year, end.Month, end.Day, 23, 59, 59);

            return UShopDB.INVOICEs.Where(o => o.DATE >= b && o.DATE <= e && o.BUYER_ID.Equals(cusID)).ToList();
        }

        public List<INVOICE> getInvoiceList(DateTime begin, DateTime end)
        {
            DateTime b = new DateTime(begin.Year,begin.Month,begin.Day,0,0,0);
            DateTime e = new DateTime(end.Year, end.Month, end.Day, 23, 59, 59);

            return UShopDB.INVOICEs.Where(o => o.DATE >= b && o.DATE <= e).ToList();
        }
    }
}
