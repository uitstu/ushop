using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model.InterfaceImplement
{
    public class AccountModel : DataModel, IAccount
    {
        private static ACCOUNT account;

        public static ACCOUNT getTaiKhoan()
        {
            return account;
        }

        public ACCOUNT findAccount(string id, string password)
        {
            account = null;

            List<Model.ACCOUNT> lstAccounts = UShopDB.ACCOUNTs.ToList();
            for (int i = 0; i < lstAccounts.Count; i++)
            {
                if (lstAccounts.ElementAt(i).ACC_CODE.Equals(id)
                    && lstAccounts.ElementAt(i).PASSWORD.Equals(password))
                {
                    account = lstAccounts.ElementAt(i);
                    break;
                }
            }

            return account;
        }

        public List<Model.ACCOUNT> loadAccount()
        {
            return UShopDB.ACCOUNTs.ToList();
        }

        public bool addAccount(ACCOUNT obj)
        {
            try
            {
                UShopDB.ACCOUNTs.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {
                //wtf ???
                //throw new Exception();

                Console.WriteLine(ex.Message);
               

            }
            return false;
        }
        public EMPLOYEE getEmployeeBy(string accCode,RECORD_STATUS status)
        {
            EMPLOYEE employee = null;
            var queryResult = from acc in UShopDB.ACCOUNTs
                              join emp in UShopDB.EMPLOYEEs
                              on acc.EMP_ID equals emp.EMP_ID
                              where (  
                              (status != 0 ? emp.RECORD_STATUS.Equals(((char)status) + "") : true)
                              && (status != 0 ? acc.RECORD_STATUS.Equals(((char)status) + "") : true)
                              && acc.ACC_CODE.Equals(accCode))
                              select emp;
            try
            {
                employee = queryResult.SingleOrDefault();
            }catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return employee;
                              


        }

        

        bool IAccount.deleteAccount(string code)
        {
            bool ret = false;
            try
            {
                var result = UShopDB.ACCOUNTs.Where(o => o.ACC_CODE.Equals(code));
                ACCOUNT acc = result.SingleOrDefault();
                acc.RECORD_STATUS = ((char)RECORD_STATUS.INACTIVE) + "";
                UShopDB.SubmitChanges();
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        bool IAccount.updateAccount(ACCOUNT updateAcc)
        {
            bool ret = false;
            try
            {
                var result = UShopDB.ACCOUNTs.Where(o => o.ACC_ID == updateAcc.ACC_ID);
                ACCOUNT acc = result.SingleOrDefault();
                acc.ACC_CODE = updateAcc.ACC_CODE;
                acc.PASSWORD = updateAcc.PASSWORD;
                acc.RECORD_STATUS = updateAcc.RECORD_STATUS;
                UShopDB.SubmitChanges();

                
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public DataTable getAccountListBy(RECORD_STATUS status)
        {
            DataTable table = new DataTable();
            var cols = table.Columns;
            cols.Add("EMP_CODE");
            cols.Add("ACC_CODE");
            cols.Add("PASSWORD");
            cols.Add("POSITION");

            var result = from acc in UShopDB.ACCOUNTs
                         join emp in UShopDB.EMPLOYEEs
                         on acc.EMP_ID equals emp.EMP_ID
                         where (status != 0 ? acc.RECORD_STATUS.Equals(((char)status) + "") : true)
                         select new
                         {
                             emp.EMP_CODE,
                             emp.EMP_NAME,
                             acc.ACC_CODE,
                             acc.PASSWORD,
                             emp.POSITION
                         };

            foreach (var o in result)
            {
                if (o != null)
                {
                    table.Rows.Add(
                        o.EMP_CODE+"-"+o.EMP_NAME,
                        o.ACC_CODE,
                        o.PASSWORD,
                        o.POSITION
                        );
                }
            }

            return table;
        }

        public ACCOUNT getAccountBy(string accCode, RECORD_STATUS status)
        {
            ACCOUNT acc = null;
            try
            {
                acc = UShopDB.ACCOUNTs.Where(o => o.ACC_CODE.Equals(accCode)
                    && o.RECORD_STATUS.Equals(((char)status) + "")
                ).SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return acc;
        }

        public List<EMPLOYEE> getEmployeesBy(RECORD_STATUS status)
        {
            List<EMPLOYEE> empList = null;
            try
            {

                var queryResult = UShopDB.EMPLOYEEs
                    .Where
                    (o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)       //if status = 0 -> independent record status
                    ).DefaultIfEmpty();
                empList = queryResult.ToList();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return empList;
        }

        public ACCOUNT getAccountByEmpCode(string empCode, RECORD_STATUS status)
        {
            ACCOUNT account = null;
            try
            {
                var result = from acc in UShopDB.ACCOUNTs
                          join emp in UShopDB.EMPLOYEEs
                          on acc.EMP_ID equals emp.EMP_ID
                          where (emp.EMP_CODE.Equals(empCode)
                           && (status != 0 ? emp.RECORD_STATUS.Equals((char)status) : true)
                           && (status != 0 ? acc.RECORD_STATUS.Equals((char)status) : true)
                          )
                          select acc;
                account = result.SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return account;
        }
    }
}
