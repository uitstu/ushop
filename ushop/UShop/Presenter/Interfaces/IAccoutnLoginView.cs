using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interfaces
{
    public interface IAccountLoginView
    {
        void loadAccounts(List<ACCOUNT> listObj);
        void veryfyAccount(String message);
    }
}
