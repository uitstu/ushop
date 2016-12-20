using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IAccount
    {
        List<ACCOUNT> loadAccount();
        void addAccount(ACCOUNT obj);
        void deleteAccount(String id);
        void updateAccount(ACCOUNT obj);

        ACCOUNT findAccount(String id, String password);
    }
}
