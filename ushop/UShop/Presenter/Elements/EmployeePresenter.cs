using Model;
using Model.InterfaceImplements;
using Model.Interfaces;
using Model.Properties;
using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Elements
{
    public class EmployeePresenter
    {
        IEmployee model;
        IEmployeeView empView;
        IEmployeeAddingView empAddingView;
        private bool isUpdated;
        private EMPLOYEE emp;
        public IEmployeeView EmpView
        {
            get
            {
                return empView;
            }

            set
            {
                empView = value;
            }
        }

        public IEmployeeAddingView EmpAddingView
        {
            get
            {
                return empAddingView;
            }

            set
            {
                empAddingView = value;
            }
        }

        public EmployeePresenter()
        {
            emp = new EMPLOYEE();
            this.model = new EmployeeModel();
        }

        public void loadEmployeList()
        {
            DataTable table = model.getEmployeeListBy(RECORD_STATUS.ACTIVE);
            this.empView.showEmployeeList(table);
        }

        public void loadExistedEmployee(string empCode)
        {
           

            emp = model.getEmployeeBy(empCode, RECORD_STATUS.ACTIVE);

            if (emp != null)
            {
                isUpdated = true;
                empAddingView.showInforComponents(emp);
            }
            else
                isUpdated = false;
        }

        public String getTemperatoryCode()
        {
            String tempCode = ((DataModel)model).getCODE("EMP", model.getEmployeeCount());
            return tempCode;
        }

        public void removeEmployee(int index)
        {

            DataTable table = empView.getEmployeeTable();

            if (model.deleteEmployee(table.Rows[index]["EMP_CODE"] + ""))
            {
                //delete in grid
                table.Rows.RemoveAt(index);
            }
            else
            {
                empView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        public void insertOrUpdateEmployee(string name, string address, DateTime birthday, DateTime approveDt, DateTime sevDt,string idno, string gender, string workStatus, string phone, string position)
        {
            
            String error = "";
            try {
                if (!checkValidName(name))
                {
                    error += "Tên rỗng hoặc không hợp lệ \n";//"Name is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidAddress(address))
                {
                    error += "Địa chỉ rỗng hoặc không hợp lệ \n";//"Address is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidBirthday(birthday))
                {
                    error += "Ngày sinh rỗng hoặc không hợp lệ \n";//"Birthday is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidApproveDT(birthday,approveDt))
                {
                    error += "Ngày vào làm rỗng hoặc không hợp lệ \n";//"Approve Date is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidIDNo(idno))
                {
                    error += "CMND rỗng hoặc không hợp lệ ( >=10 số )\n";
                    throw new Exception();
                }
                if (!checkValidGender(gender))
                {
                    error += "Giới tính không hợp lệ \n";//"Gender is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidWorkStatus(workStatus))
                {
                    error += "Trạng thái không hợp lệ \n";//"workStatus is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidSevDT(approveDt, sevDt,workStatus))
                {
                    error += "Ngày nghỉ việc làm rỗng hoặc không hợp lệ \n";//"Sev Date is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidPhone(phone))
                {
                    error += "Số điện thoại không hợp lệ \n";//"Sev Date is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidPosition(position))
                {
                    error += "Vị trí làm việc không hợp lệ \n";//"Sev Date is empty or invalid\n";
                    throw new Exception();
                }

                emp.EMP_NAME = name;
                emp.BIRTHDAY = birthday;
                emp.APPROVE_DATE = approveDt;
                emp.ADDRESS = address;
                emp.GENDER = gender;
                emp.ID_CARD_NO = idno;
                emp.PHONE = phone;
                emp.POSITION = position;
                emp.SEV_DATE = sevDt;
                emp.WORK_STATUS = workStatus;
                emp.RECORD_STATUS = (char)RECORD_STATUS.ACTIVE+"";
                if (!isUpdated)
                {

                    if (model.addEmployee(emp))
                    {
                        empAddingView.showMessageBox(Resources.MB_SUCCESS, MessageBoxIcon.Information);
                        emp = new EMPLOYEE();
                        empAddingView.refreshAll();
                    }
                    else
                    {
                        empAddingView.showMessageBox(Resources.MB_FAILURE, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (model.updateEmployee(emp))
                    {
                        empAddingView.showMessageBox(Resources.MB_SUCCESS, MessageBoxIcon.Information);
                        empAddingView.backPreviousForm();
                    }
                    else
                    {
                        empAddingView.showMessageBox(Resources.MB_FAILURE, MessageBoxIcon.Information);
                    }
                }

            }catch(Exception e)
            {
                empAddingView.showMessageBox(error,MessageBoxIcon.Error);
            }
        }

        private bool checkValidIDNo(string idno)
        {
            if (idno != null && !idno.Equals(""))
            {
                Regex regex = new Regex("^[0 - 9]{ 10, }$");
                if (regex.IsMatch(idno))
                    return true;
                return true;
            }
            return false;
        }
        private bool checkValidPosition(string position)
        {
            if (position != null && !position.Equals(""))
            {
                if (position.Equals(Resources.POS_EMPLOYEE)
                    || position.Equals(Resources.POS_MANGER))
                    return true;
            }
            return false;
        }

        private bool checkValidPhone(string phone)
        {
            if (phone != null && !phone.Equals(""))
            {
                Regex regex = new Regex("^[0-9]{8,}$");
                if(regex.IsMatch(phone))
                    return true;
            }
            return false;
        }

        private bool checkValidWorkStatus(string workStatus)
        {
            if (workStatus != null && !workStatus.Equals(""))
            {
                if (workStatus.Equals(Resources.WS_IN_WORK) || workStatus.Equals(Resources.WS_SEVERANCE))
                    return true;
            }
            return false;
        }

        private bool checkValidGender(string gender)
        {
            if (gender != null && !gender.Equals(""))
            {
                if(gender.Equals(Resources.GENDER_MALE) || gender.Equals(Resources.GENDER_FEMALE)) 
                    return true;
            }
            return false;
        }

        private bool checkValidSevDT(DateTime approveDt, DateTime sevDt, string workStatus)
        {
            DateTime now = DateTime.Now;
            if (workStatus.Equals(Resources.WS_SEVERANCE))
            {
                if (approveDt != null
                    && approveDt.CompareTo(sevDt) < 0
                    && sevDt.CompareTo(now) < 0)
                {
                    return true;
                }

                return false;
            }
            else
                return true;
        }

        private bool checkValidApproveDT(DateTime birthday,DateTime approveDt)
        {
            
            DateTime now = DateTime.Now;
            if (approveDt != null 
                && birthday.CompareTo(approveDt) < 0 
                && approveDt.CompareTo(now) < 0)
            {
                return true;
            }
            return false;
        }

        private bool checkValidBirthday(DateTime birthday)
        {
            DateTime now = DateTime.Now;
            if (birthday != null && birthday.CompareTo(now)< 0)
            {
                return true;
            }
            return false;
        }

        private bool checkValidAddress(string address)
        {
            if (address != null && !address.Equals(""))
            {
                 return true;
            }
            return false;
        }

        private bool checkValidName(string name)
        {
            if(name != null && !name.Equals(""))
            {
                Regex regex = new Regex(@"^[.&\D]+$");
                if(regex.IsMatch(name))
                    return true;
            }
            return false;
        }
    }
}
