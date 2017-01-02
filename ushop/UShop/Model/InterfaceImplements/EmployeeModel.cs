using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model.InterfaceImplements
{
    public class EmployeeModel : DataModel,IEmployee
    {
        

        public DataTable getEmployeeListBy(RECORD_STATUS status)
        {
            DataTable table = new DataTable();
            var cols = table.Columns;
            cols.Add("EMP_CODE");
            cols.Add("EMP_NAME");
            cols.Add("GENDER");
            cols.Add("BIRTHDAY");
            cols.Add("ID_CARD_NO");
            cols.Add("ADDRESS");
            cols.Add("PHONE");
            cols.Add("APPROVE_DATE");
            cols.Add("WORK_STATUS");
            cols.Add("SEV_DATE");
            cols.Add("POSITION");

            var result = UShopDB.EMPLOYEEs.Where(o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)).DefaultIfEmpty();

            
            foreach (var o in result)
            {
                if (o != null)
                {
                    table.Rows.Add(
                        o.EMP_CODE,
                        o.EMP_NAME,
                        o.GENDER,
                        o.BIRTHDAY != null ? ((DateTime)o.BIRTHDAY).ToString("dd/MM/yyyy"):"",
                        o.ID_CARD_NO,
                        o.ADDRESS,
                        o.PHONE,
                        o.APPROVE_DATE != null ? ((DateTime)o.APPROVE_DATE).ToString("dd/MM/yyyy") : "",
                        o.WORK_STATUS,
                        o.SEV_DATE != null ? ((DateTime)o.SEV_DATE).ToString("dd/MM/yyyy") : "",
                        o.POSITION
                        );
                }
            }

            return table;
        }

        public bool addEmployee(EMPLOYEE emp)
        {
            try {
                UShopDB.EMPLOYEEs.InsertOnSubmit(emp);
                UShopDB.SubmitChanges();

                emp.EMP_CODE = getCODE("EMP", emp.EMP_ID);
                UShopDB.SubmitChanges();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool deleteEmployee(string code)
        {
            bool ret = false;
            try { 
                var result = UShopDB.EMPLOYEEs.Where(o => o.EMP_CODE.Equals(code));
                EMPLOYEE emp = result.SingleOrDefault();
                emp.RECORD_STATUS = ((char)RECORD_STATUS.INACTIVE)+"";
                UShopDB.SubmitChanges();
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;

        }

        public bool removeEmployee(int id)
        {
            bool ret = false;
            try
            {
                var result = UShopDB.EMPLOYEEs.Where(o => o.EMP_ID == id);
                EMPLOYEE emp = result.SingleOrDefault();
                emp.RECORD_STATUS = ((char)RECORD_STATUS.INACTIVE) + "";
                UShopDB.SubmitChanges();
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public bool updateEmployee(EMPLOYEE updatedEmp)
        {
            bool ret = false;
            try
            {
                var result = UShopDB.EMPLOYEEs.Where(o => o.EMP_ID== updatedEmp.EMP_ID);
                EMPLOYEE emp = result.SingleOrDefault();
                emp.ADDRESS = updatedEmp.ADDRESS;
                emp.APPROVE_DATE = updatedEmp.APPROVE_DATE;
                emp.BIRTHDAY = updatedEmp.BIRTHDAY;
                emp.EMP_NAME = updatedEmp.EMP_NAME;
                emp.GENDER = updatedEmp.GENDER;
                emp.ID_CARD_NO = updatedEmp.ID_CARD_NO;
                emp.PHONE = updatedEmp.PHONE;
                emp.POSITION = updatedEmp.POSITION;
                emp.SEV_DATE = updatedEmp.SEV_DATE;
                emp.RECORD_STATUS = updatedEmp.RECORD_STATUS;
                UShopDB.SubmitChanges();
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public int getEmployeeCount()
        {
            int ret = UShopDB.EMPLOYEEs.Count();
            return ret;
        }

        public EMPLOYEE getEmployeeBy(string empCode, RECORD_STATUS status)
        {
            EMPLOYEE emp = null;
            try
            {
                emp  = UShopDB.EMPLOYEEs.Where(o => o.EMP_CODE.Equals(empCode) 
                && o.RECORD_STATUS.Equals(((char)status)+"")
                ).SingleOrDefault();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return emp;
        }
    }
}
