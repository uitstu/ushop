using Model;
using Model.InterfaceImplement;
using Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.InterfaceImplement
{
    public class AccountPresenter
    {
        public static //Get EMPLOYEE ACCOUNT CODE to query later
        EMPLOYEE currentEmployee;
        private AccountModel _model;
        private IAccountView _view;

        public AccountPresenter()
        { 
        }

        public AccountPresenter(IAccountView view)
            : this(view, new AccountModel())
        {
        }

        public AccountPresenter(IAccountView view, AccountModel model)
        {
            _view = view;
            _model = model;
        }

        public void verifyAccount(String id, String password)
        {
            /* ACCOUNT account = _model.findAccount(id, password);
             if (account != null)
             {
                 _view.veryfyAccount(account.ACC_CODE);
             }
             else
             {
                 _view.veryfyAccount(null);
             }*/

            //real
            currentEmployee =  _model.getEmployeeBy(id);
          
            _view.veryfyAccount("Fuckin Tester");
        }

        /*
        public void loadCategories()
        {
            _view.loadCategories(_model.loadCategory());
        }

        public void saveCategory(Category obj)
        {
            _model.addCategory(obj);
            _view.loadCategories(_model.loadCategory());
        }

        public void deleteCategory(String id)
        {
            _model.deleteCategory(id);
            _view.loadCategories(_model.loadCategory());
        }

        public void updateCategory(Category obj)
        {
            _model.updateCategory(obj);
            _view.loadCategories(_model.loadCategory());
        }
        */
    }
}
