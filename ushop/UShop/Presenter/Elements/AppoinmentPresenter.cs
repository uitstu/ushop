using Model;
using Model.InterfaceImplements;
using Model.Interfaces;
using Model.Properties;
using Presenter.InterfaceImplement;
using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Elements
{
    public class AppoinmentPresenter
    {
        IAppointment model;
        IAppointmentView appView;
        IAppointmentAddingView appAddingView;
        private bool isUpdated;
        private APPOINTMENT app;
        private List<CUSTOMER> cusList;

        public IAppointmentView AppView
        {
            get
            {
                return appView;
            }

            set
            {
                appView = value;
            }
        }

        public IAppointmentAddingView AppAddingView
        {
            get
            {
                return appAddingView;
            }

            set
            {
                appAddingView = value;
            }
        }

        public AppoinmentPresenter()
        {
            app = new APPOINTMENT();
            this.model = new AppointmentModel();
            
        }

        public void loadAppointmentList()
        {
            DataTable table = model.getAppointmentListBy(RECORD_STATUS.ACTIVE);
            this.appView.showAppointmentList(table);
        }
        public void loadCustomerNames(String filter)
        {
            //true
            cusList = model.getCustomersBy(RECORD_STATUS.ACTIVE);

            List<String> cusNameList = generateCustomerNameList(filter);
            if (!isValidList(cusNameList))
            {
                cusNameList.Add(Resources.EMPTY_ITEM);
            }
            appAddingView.showCustomerName(cusNameList);
        }
        public List<String> generateCustomerNameList(String filter)
        {

            bool isFilter = (filter != null && !filter.Equals(""));
            List<String> cusNameList = new List<String>();
            foreach (var cus in cusList)
            {

                if (isFilter)
                {
                    if (cus.CUS_NAME.Contains(filter) || cus.CUS_CODE.Contains(filter))
                    {
                        cusNameList.Add(cus.CUS_CODE + "-" + cus.CUS_NAME);
                    }
                }
                else
                    cusNameList.Add(cus.CUS_CODE + "-" + cus.CUS_NAME);

            }

            if (!isValidList(cusNameList))
            {
                cusNameList.Add(Resources.EMPTY_ITEM);
            }
            return cusNameList;
        }

        private bool isValidList(List<string> cusNameList)
        {
            if (cusNameList != null && cusNameList.Count > 0)
                return true;
            return false;
        }

        public void loadExistedAppointment(string appCode)
        {


            app = model.getAppointmentBy(appCode, RECORD_STATUS.ACTIVE);
            
            if (app != null)
            {
                CUSTOMER cus=  findCustomerInListBy( (int)app.CUS_ID);
                String cusCodeName = cus.CUS_CODE + "-" + cus.CUS_NAME;
                String empName =  AccountPresenter.currentEmployee.EMP_NAME;
                isUpdated = true;
                appAddingView.showInforComponents(app, cusCodeName, empName);
            }
            else
                isUpdated = false;
        }

        public String getTemperatoryCode()
        {
            String tempCode = ((DataModel)model).getCODE("APP", model.getAppointmentCount()+1);
            return tempCode;
        }

        public void removeAppointment(int index)
        {

            DataTable table = appView.getApppointmentTable();
            string code = (table.Rows[index]["APP_CODE"]).ToString().Split(new char[] { '-' })[0];
            if (model.deleteAppointment(code))
            {
                //delete in grid
                table.Rows.RemoveAt(index);
            }
            else
            {
                appView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        CUSTOMER findCustomerInListBy(int id)
        {
            if (id >= 0)
            {
                foreach (var cus in cusList)
                {
                    if (cus.CUS_ID == id)
                        return cus;
                }
            }
            return null;
        }
        CUSTOMER findCustomerInListBy(string cusCode)
        {
            if (cusCode != null && !cusCode.Equals(""))
            {
                foreach (var cus in cusList)
                {
                    if (cus.CUS_CODE.Equals(cusCode))
                        return cus;
                }
            }
            return null;
        }

        public string getCurrentEmployeeName()
        {
            return AccountPresenter.currentEmployee.EMP_NAME;
        }

        public void insertOrUpdateAppointment(string cusCode,DateTime createdDT,DateTime appDT,string description, string note)
        {

            String error = "";
            try
            {


                CUSTOMER currentCus = null;
                if ((currentCus =  checkValidCustomerCode(cusCode))== null)
                {
                    error += "Tên khách hàng rỗng hoặc không hợp lệ \n";//"Name is empty or invalid\n";
                    throw new Exception();
                }
                if (!checkValidContent(description))
                {
                    error += "Nội dung rỗng hoặc không hợp lệ \n";//"Name is empty or invalid\n";
                    throw new Exception();
                }
               
                if (!checkValidCreatedDate(createdDT))
                {
                    error += "Ngày lập phiếu không hợp lệ \n";//"Address is empty or invalid\n";
                    throw new Exception();
                }

                if (!checkValidAppDate(createdDT,appDT))
                {
                    error += "Ngày trả phiếu không hợp lệ \n";//"Sev Date is empty or invalid\n";
                    throw new Exception();
                }
                app.CUS_ID = currentCus.CUS_ID;
                app.PREPARER_ID = AccountPresenter.currentEmployee.EMP_ID;
                app.CREATED_DATE = createdDT;
                app.APP_DATE = appDT;
                app.DESCRIPTION = description;
                app.NOTE = note;

                app.RECORD_STATUS = (char)RECORD_STATUS.ACTIVE + "";
                if (!isUpdated)
                {

                    if (model.addAppointment(app))
                    {
                        appAddingView.showMessageBox(Resources.MB_SUCCESS, MessageBoxIcon.Information);
                        app = new APPOINTMENT();
                        appAddingView.refreshAll();
                    }
                    else
                    {
                        appAddingView.showMessageBox(Resources.MB_FAILURE, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (model.updateAppointment(app))
                    {
                        appAddingView.showMessageBox(Resources.MB_SUCCESS, MessageBoxIcon.Information);
                        appAddingView.backPreviousForm();
                    }
                    else
                    {
                        appAddingView.showMessageBox(Resources.MB_FAILURE, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception e)
            {
                appAddingView.showMessageBox(error, MessageBoxIcon.Error);
            }
        }

        private bool checkValidContent(string description)
        {
            if (description != null && !description.Equals(""))
            {
                return true;
            }
            return false;
        }

        private CUSTOMER checkValidCustomerCode(string cusCode)
        {
            if(cusCode != null && !cusCode.Equals(""))
            {
                CUSTOMER cus = findCustomerInListBy(cusCode);
                if (cus != null)
                    return cus;
            }
            return null;
        }

        private bool checkValidAppDate(DateTime createdDate, DateTime appDate)
        {

            DateTime now = DateTime.Now;
            if (appDate != null
                && createdDate.CompareTo(appDate) < 0
                && appDate.CompareTo(now) <= 0)
            {
                return true;
            }
            return false;
        }

        private bool checkValidCreatedDate(DateTime createdDate)
        {
            DateTime now = DateTime.Now;
            if (createdDate != null && createdDate.CompareTo(now) <= 0)
            {
                return true;
            }
            return false;
        }
        /*
        private bool checkValidPhone(string phone)
        {
            if (phone != null && !phone.Equals(""))
            {
                Regex regex = new Regex("^[0-9]{8,}$");
                if (regex.IsMatch(phone))
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
            if (name != null && !name.Equals(""))
            {
                Regex regex = new Regex(@"^[.&\D]+$");
                if (regex.IsMatch(name))
                    return true;
            }
            return false;
        }*/
    }
}
