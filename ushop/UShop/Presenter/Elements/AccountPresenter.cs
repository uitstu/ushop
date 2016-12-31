using Model;
using Model.InterfaceImplement;
using Model.Properties;
using Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interface;
using Presenter.Interfaces;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Presenter.InterfaceImplement
{
    public class AccountPresenter
    {
        public static EMPLOYEE currentEmployee; //Get EMPLOYEE ACCOUNT CODE to query later
        public static bool checkPermission(FORM_TYPE type)
        {
            if (currentEmployee != null)
            {
                if (currentEmployee.POSITION == Resources.POS_MANGER)
                    return true;
                else
                {
                    switch (type)
                    {
                        case FORM_TYPE.ADDING_ACCOUNT:
                        case FORM_TYPE.ADDING_APPOINTMENT:
                        case FORM_TYPE.ADDING_EMPLOYEE:
                        case FORM_TYPE.ADDING_CUSTOMER:
                        case FORM_TYPE.ADDING_INVOICE:
                        case FORM_TYPE.ACCOUNT:
                            return false;

                        case FORM_TYPE.CATEGORY:
                        case FORM_TYPE.RECEIPTNOTE:
                        case FORM_TYPE.APPOINTMENT:
                        case FORM_TYPE.CUSTOMER:
                        case FORM_TYPE.EMPLOYEE:
                        case FORM_TYPE.INVOICE:
                        default: // some function is not implementation
                            return true;
                    }
                }
            }
            return false;
        }
        private IAccount model;
        private IAccountView accView;
        private IAccountAddingView accAddingView;

        private IAccountLoginView loginView;

        bool isUpdated;
        ACCOUNT acc;
        private List<EMPLOYEE> empList;
        public IAccountView AccView
        {
            get
            {
                return accView;
            }

            set
            {
                accView = value;
            }
        }

        
        public IAccountAddingView AccAddingView
        {
            get
            {
                return accAddingView;
            }

            set
            {
                accAddingView = value;
            }
        }
        

        public AccountPresenter()
        {
            model = new AccountModel();
            isUpdated = false;
            empList = new List<EMPLOYEE>();

            acc = new ACCOUNT();
        }

        public AccountPresenter(IAccountLoginView view)
        {
            model = new AccountModel();
            loginView = view;
            isUpdated = false;

            acc = new ACCOUNT();
            empList = new List<EMPLOYEE>();
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
            try
            {

                //check valid
                String error = "";
                if (!checkValidId(id))
                {
                    error += "Tên đăng nhập không được để trống!";
                    throw new Exception();
                }
                if (!checkValidPassword(password))
                {
                    error += "Mật khẩu không được để trống!";
                    throw new Exception();
                }
                //get employee by ACC_CODE 

                /*add new RECORD_STATUS param to check some misstake:
                 * _Employee had be deleted, he should be not active program by his account
                 * _Account had be deleted, someone cannot sign in system 
                 */
                currentEmployee = model.getEmployeeBy(id,RECORD_STATUS.ACTIVE);

                if(currentEmployee == null)
                {
                    throw new Exception();
                }

                //show welcome msg
                loginView.veryfyAccount(Resources.MB_WELCOME); // sai chinh ta verify ??Huy sua lai nhe
            }
            catch(Exception e)
            {
                Console.WriteLine("Check validation failure");
                loginView.veryfyAccount(null);
            }
        }
        public void loadExistedAccountByEmp(EMPLOYEE emp)
        {
            acc = model.getAccountByEmpCode(emp.EMP_CODE, RECORD_STATUS.ACTIVE);

            if (acc != null)
            {
                isUpdated = true;
                accAddingView.showInforComponents(acc, emp.EMP_CODE + "-" + emp.EMP_NAME);
                empList.Add(emp);
            }
            else
                isUpdated = false;

        }
        

        public void loadEmployeeNames(String filter)
        {
            //true
            empList = model.getEmployeesBy(RECORD_STATUS.ACTIVE);

            List<String> empNameList = generateEmployeeNameList(filter);
            if (!isValidList(empNameList))
            {
                empNameList.Add(Resources.EMPTY_ITEM);
            }
            accAddingView.showEmployeeName(empNameList);
        }

        private bool isValidList(List<string> empNameList)
        {
            if (empNameList != null && empNameList.Count > 0)
                return true;
            return false;
        }

        private List<String> generateEmployeeNameList(string filter)
        {
            bool isFilter = (filter != null && !filter.Equals(""));
            List<String> empNameList = new List<String>();
            foreach (var emp in empList)
            {

                if (isFilter)
                {
                    if (emp.EMP_NAME.Contains(filter) || emp.EMP_CODE.Contains(filter))
                    {
                        empNameList.Add(emp.EMP_CODE + "-" + emp.EMP_NAME);
                    }
                }
                else
                    empNameList.Add(emp.EMP_CODE + "-" + emp.EMP_NAME);

            }

            if (!isValidList(empNameList))
            {
                empNameList.Add(Resources.EMPTY_ITEM);
            }
            return empNameList;
        }

        public void loadAccountList()
        {
            DataTable table = model.getAccountListBy(RECORD_STATUS.ACTIVE);
            this.accView.showAccountList(table);
        }

        public void loadExistedAccount(string accCode)
        {


            acc = model.getAccountBy(accCode, RECORD_STATUS.ACTIVE);

            if (acc != null)
            {
                isUpdated = true;
                EMPLOYEE emp = findEmployeeInListBy((int)acc.EMP_ID);
                accAddingView.showInforComponents(acc, emp.EMP_CODE+"-"+emp.EMP_NAME);
            }
            else
                isUpdated = false;
        }

       
        public void removeAccount(int index)
        {

            DataTable table = accView.getAccountTable();

            if (model.deleteAccount(table.Rows[index]["ACC_CODE"] + ""))
            {
                //delete in grid
                table.Rows.RemoveAt(index);
            }
            else
            {
                accView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        public void insertOrUpdateAccount(string empCode,string id,string password)
        {

            String error = Resources.MB_FAILURE +"\n";
            try
            {
                //check valid

                EMPLOYEE signupEmp = null;
                if ((signupEmp = checkValidEmployeeCode(empCode)) == null)
                {
                    error += "Nhân viên không hợp lệ hoặc không tồn tại trong hệ thống \n";//"Name is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidId(id))
                {
                    error += "Tên đăng nhập không được để trống !\nCó nhiều hơn 4 kí tự và ít hơn 15 kí tự\nKhông có khoảng trắng";
                    throw new Exception();
                }
                if (!checkValidPassword(password))
                {
                    error += "Mật khẩu không được để trống !\nCó nhiều hơn 4 kí tự và ít hơn 15 kí tự\nKhông có khoảng trắng";
                    throw new Exception();
                }

                acc.ACC_CODE = id;
                acc.PASSWORD = password;
                acc.EMP_ID = signupEmp.EMP_ID;
                acc.RECORD_STATUS = (char)RECORD_STATUS.ACTIVE + "";

                if (!isUpdated)
                {

                    if (model.addAccount(acc))
                    {
                        accAddingView.showMessageBox(Resources.MB_SUCCESS, MessageBoxIcon.Information);
                        acc = new ACCOUNT();
                        isUpdated = false;
                        accAddingView.refreshAll();
                    }
                    else
                    {
                       accAddingView.showMessageBox(Resources.MB_FAILURE, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (model.updateAccount(acc))
                    {

                        isUpdated = false;
                        accAddingView.showMessageBox(Resources.MB_SUCCESS, MessageBoxIcon.Information);
                        accAddingView.backPreviousForm();
                        
                    }
                    else
                    {
                       accAddingView.showMessageBox(Resources.MB_FAILURE, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception e)
            {
                accAddingView.showMessageBox(error, MessageBoxIcon.Error);
            }
        }

        private EMPLOYEE checkValidEmployeeCode(string empCode)
        {
            return findEmployeeInListBy(empCode);
        }

        private EMPLOYEE findEmployeeInListBy(string empCode)
        {
            if (empCode != null && !empCode.Equals(""))
            {
                foreach (var emp in empList)
                {
                    if (emp.EMP_CODE.Equals(empCode))
                        return emp;
                }
            }
            return null;
        }
        private EMPLOYEE findEmployeeInListBy(int empId)
        {
            if (empId >=0)
            {
                foreach (var emp in empList)
                {
                    if (emp.EMP_ID == empId)
                        return emp;
                }
            }
            return null;
        }

        private bool checkValidPassword(string password)
        {
            if (password != null && !password.Equals(""))
            {
                Regex reg = new Regex(@"^.\S{4,15}$");
                if (reg.IsMatch(password))
                    return true;
            }
            return false;
        }

        private bool checkValidId(string id)
        {
            if (id != null && !id.Equals(""))
            {
                Regex reg = new Regex(@"^.\S{4,15}$"); 
                if(reg.IsMatch(id))
                    return true;
            }
            return false;   
        }
    }
}
