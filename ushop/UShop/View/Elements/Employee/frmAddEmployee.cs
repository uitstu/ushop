using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter.Elements;
using Presenter.Interfaces;
using Model.Properties;
using Model;

namespace View.Elements.Employee
{
    public partial class frmAddEmployee : Form, IEmployeeAddingView
    {
        private Form caller;
        private EmployeePresenter presenter;
        String updatedEmpCode;
        
        public frmAddEmployee(Form caller, EmployeePresenter presenter)
        {
            InitializeComponent();

            this.caller = caller;
            this.presenter = presenter;
            presenter.EmpAddingView = this;

            refreshAll();
        }
        public frmAddEmployee(Form caller, EmployeePresenter presenter,String empCode)
        {
            InitializeComponent();

            this.caller = caller;
            this.presenter = presenter;
            presenter.EmpAddingView = this;

            refreshAll();

            //should load employee infor into components
            updatedEmpCode = empCode;
            presenter.loadExistedEmployee(updatedEmpCode);
        }
        
        public void backPreviousForm()
        {
            //foreach (var form in MdiParent.MdiChildren)
            //{

            //    if (caller.Equals(form))
            //    {
            //        caller.Activate();

            //    }
            //}

            this.Close();
            caller.Activate();
        }

        public void refreshAll()
        {
            cmbAEGender.ResetText();
            cmbAEWorkStatus.ResetText();
            cmbAEPosition.ResetText();
            txteAEPhone.ResetText();
            txteAEIDNo.ResetText();
            txteAEEmpName.ResetText();
            txteAEEmpCode.ResetText();
            txteAEAddress.ResetText();
            dpickAEBirthday.Value = DateTime.Now;
            dpkAEApproveDate.Value = DateTime.Now;
            dpkAESevDate.Value = DateTime.Now;

            //load basic into cmb
            cmbAEGender.Properties.Items.AddRange(new String[] {
                Resources.GENDER_MALE,
                Resources.GENDER_FEMALE });

            cmbAEWorkStatus.Properties.Items.AddRange(new String[]
            {
                Resources.WS_IN_WORK,
                Resources.WS_SEVERANCE
            });

            cmbAEPosition.Properties.Items.AddRange(new String[]
            {
                Resources.POS_MANGER,
                Resources.POS_EMPLOYEE
            });
            txteAEEmpCode.Text = presenter.getTemperatoryCode();
        }

        public void showInforComponents(EMPLOYEE emp)
        {
            try {
                txteAEAddress.Text = emp.ADDRESS;
                txteAEEmpCode.Text = emp.EMP_CODE;
                txteAEEmpName.Text = emp.EMP_NAME;
                dpickAEBirthday.Value = emp.BIRTHDAY != null ? (DateTime)emp.BIRTHDAY : DateTime.Now;
                dpkAEApproveDate.Value = emp.APPROVE_DATE != null ? (DateTime)emp.APPROVE_DATE : DateTime.Now;
                dpkAESevDate.Value = emp.SEV_DATE!= null ? (DateTime)emp.SEV_DATE:DateTime.Now;
                cmbAEGender.Text = emp.GENDER;
                cmbAEWorkStatus.Text = emp.WORK_STATUS;
                txteAEPhone.Text = emp.PHONE;
                cmbAEPosition.Text = emp.POSITION;
                txteAEIDNo.Text = emp.ID_CARD_NO;

                String workStatus = cmbAEWorkStatus.Text;
                if (workStatus.Equals(Resources.WS_SEVERANCE))
                {
                    dpkAESevDate.Enabled = true;
                }
                else
                    dpkAESevDate.Enabled = false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void showMessageBox(string msg, MessageBoxIcon type)
        {
            switch (type)
            {
                case MessageBoxIcon.Error:

                    MessageBox.Show(msg, Resources.ERROR_CAPTION, MessageBoxButtons.OK, type);
                    break;
                case MessageBoxIcon.Information:

                    MessageBox.Show(msg, Resources.INFOR_CAPTION, MessageBoxButtons.OK, type);
                    break;
            }
        }

        private void bbtniAEAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String name = txteAEEmpName.Text;
            String address = txteAEAddress.Text;
            DateTime birthday = dpickAEBirthday.Value;
            DateTime approveDt = dpkAEApproveDate.Value;
            DateTime sevDt = dpkAESevDate.Value;
            String gender = cmbAEGender.Text;
            String workStatus = cmbAEWorkStatus.Text;
            String phone = txteAEPhone.Text;
            String position = cmbAEPosition.Text;
            String idno = txteAEIDNo.Text;
            presenter.insertOrUpdateEmployee(name,address,birthday,approveDt,sevDt,idno,gender,workStatus,phone,position);
        }

        private void bbtniAEBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            backPreviousForm();
            this.Close();
        }

        private void bbtniAEReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshAll();
        }

        private void dpkAESevDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dpkAEApproveDate_ValueChanged(object sender, EventArgs e)
        {
            dpkAESevDate.MinDate = dpkAEApproveDate.Value;
        }

        private void dpickAEBirthday_ValueChanged(object sender, EventArgs e)
        {
            dpkAEApproveDate.MinDate = dpickAEBirthday.Value;
        }

        private void cmbAEWorkStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            String workStatus = cmbAEWorkStatus.Text;
            if (workStatus.Equals(Resources.WS_SEVERANCE))
            {
                dpkAESevDate.Enabled = true;
            }
            else
                dpkAESevDate.Enabled = false;
        }
    }
}
