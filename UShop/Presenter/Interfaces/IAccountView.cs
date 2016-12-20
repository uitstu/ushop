using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
    public interface IAccountView
    {
        void loadAccounts(List<ACCOUNT> listObj);
        void veryfyAccount(String message);
        //void saveCategory(Category obj);
        //void deleteCategory(String id);
    }
}
