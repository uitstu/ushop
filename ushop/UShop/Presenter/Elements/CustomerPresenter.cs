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
    public class CustomerPresenter
    {
        ICustomer model;
        ICustomerView cusView;
        ICustomerAddingView cusAddingView;
        private bool isUpdated;
        private CUSTOMER cus;
        public ICustomerView CusView
        {
            get
            {
                return cusView;
            }

            set
            {
                cusView = value;
            }
        }

        public ICustomerAddingView CusAddingView
        {
            get
            {
                return cusAddingView;
            }

            set
            {
                cusAddingView = value;
            }
        }

        public CustomerPresenter()
        {
            cus = new CUSTOMER();
            this.model = new CustomerModel();
        }

        public void loadCustomerList()
        {
            DataTable table = model.getCustomerListBy(RECORD_STATUS.ACTIVE);
            this.cusView.showCustomerList(table);
        }

        public void loadExistedCustomer(string cusCode)
        {


            cus = model.getCustomerBy(cusCode, RECORD_STATUS.ACTIVE);

            if (cus != null)
            {
                isUpdated = true;
                cusAddingView.showInforComponents(cus);
            }
            else
                isUpdated = false;
        }

        public String getTemperatoryCode()
        {
            String tempCode = ((DataModel)model).getCODE("CUS", model.getCustomerCount() + 1);
            return tempCode;
        }

        public void removeCustomer(int index)
        {

            DataTable table = cusView.getCustomerTable();

            if (model.deleteCustomer(table.Rows[index]["CUS_CODE"] + ""))
            {
                loadCustomerList();
                //delete in grid
                //table.Rows.RemoveAt(index);
            }
            else
            {
                cusView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        public void removeCustomer(String code)
        {
            

            if (model.deleteCustomer(code))
            {
                loadCustomerList();
                //delete in grid
                //table.Rows.RemoveAt(index);
            }
            else
            {
                cusView.showMessageBox(Resources.MB_FAILURE, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        public void insertOrUpdateCustomer(string name, string address, string phone)
        {

            String error = "";
            try
            {
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
               
                if (!checkValidPhone(phone))
                {
                    error += "Số điện thoại không hợp lệ \n";//"Sev Date is empty or invalid\n";
                    throw new Exception();
                }
               

                cus.CUS_NAME = name;
                
                cus.ADDRESS = address;
                
                cus.PHONE = phone;
               
               
                cus.RECORD_STATUS = (char)RECORD_STATUS.ACTIVE + "";
                if (!isUpdated)
                {

                    if (model.addCustomer(cus))
                    {
                        cusAddingView.showMessageBox(Resources.MB_SUCCESS, MessageBoxIcon.Information);
                        cus = new CUSTOMER();
                        cusAddingView.refreshAll();
                    }
                    else
                    {
                        cusAddingView.showMessageBox(Resources.MB_FAILURE, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (model.updateCustomer(cus))
                    {
                        cusAddingView.showMessageBox(Resources.MB_SUCCESS, MessageBoxIcon.Information);
                        cusAddingView.backPreviousForm();
                    }
                    else
                    {
                        cusAddingView.showMessageBox(Resources.MB_FAILURE, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception e)
            {
                cusAddingView.showMessageBox(error, MessageBoxIcon.Error);
            }
        }

        

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
        }
    }
}
