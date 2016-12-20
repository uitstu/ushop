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
        
    }
}
