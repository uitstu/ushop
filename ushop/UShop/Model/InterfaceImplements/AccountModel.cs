using Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void addAccount(ACCOUNT obj)
        {
            try
            {
                UShopDB.ACCOUNTs.InsertOnSubmit(obj);
                UShopDB.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            
        }


        public void deleteAccount(string id)
        {
            /*
            Category obj = UShopDB.Categories.Where(o => o.CategoryID == Convert.ToInt32(id)).SingleOrDefault();
            UShopDB.Categories.DeleteOnSubmit(obj);
            UShopDB.SubmitChanges();
             * */

        }


        public void updateAccount(ACCOUNT account)
        {
            /*
            Category obj = UShopDB.Categories.Where(o => o.CategoryID == Convert.ToInt32(category.CategoryID)).SingleOrDefault();
            obj.CategoryName = category.CategoryName;
            obj.CategoryDescription = category.CategoryDescription;
            UShopDB.SubmitChanges();
             * */
        }

        public EMPLOYEE getEmployeeBy(string accCode)
        {
            EMPLOYEE employee = null;
            var queryResult = from acc in UShopDB.ACCOUNTs
                              join emp in UShopDB.EMPLOYEEs
                              on acc.EMP_ID equals emp.EMP_ID
                              where acc.ACC_CODE.Equals(accCode)
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
    }
}
