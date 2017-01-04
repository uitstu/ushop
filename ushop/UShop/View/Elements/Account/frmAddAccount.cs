using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter.InterfaceImplement;
using Presenter.Interfaces;
using Model;
using Model.Properties;
using View.Elements.Employee;

namespace View.Elements.Account
{
    public partial class frmAddAccount : Form,IAccountAddingView
    {
        private Form caller;
        private string updatedAccCode;
        private AccountPresenter presenter;
        
        public frmAddAccount(Form caller, AccountPresenter presenter)
        {
            InitializeComponent();
            this.caller = caller;
            this.presenter = presenter;
            presenter.AccAddingView = this;

            refreshAll();
        }

        public frmAddAccount(Form caller, AccountPresenter presenter, string accCode)
        {
            InitializeComponent();
            this.caller = caller;
            this.presenter = presenter;
            this.updatedAccCode = accCode;
        
            presenter.AccAddingView = this;

            refreshAll();

            presenter.loadExistedAccount(updatedAccCode);

        }


        private void bbtniAACAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string empCode = cmbAACEmployeeCodeName.Text.ToString().Split(new char[] { '-' })[0];
            string id = txteAACAccountCode.Text;
            string password = txteAACPassword.Text;
            presenter.insertOrUpdateAccount(empCode, id, password);
        }

        private void bbtniAACPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        

        
        public void showInforComponents(ACCOUNT acc, String cusCodeName)
        {
            try
            {
                txteAACAccountCode.Text = acc.ACC_CODE;
                txteAACPassword.Text = acc.PASSWORD;
                cmbAACEmployeeCodeName.Text = cusCodeName;
            }
            catch (Exception e)
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

        public void refreshAll()
        {
            txteAACAccountCode.ResetText();
            txteAACPassword.ResetText();
            cmbAACEmployeeCodeName.ResetText();

           
            presenter.loadEmployeeNames(null);

        }

        public void backPreviousForm()
        {

            this.Close();
            caller.Activate();
        }

        public void showEmployeeName(List<String> empCodeNameList)
        {

            var cmbItems = cmbAACEmployeeCodeName.Properties.Items;
            cmbItems.Clear();
            cmbItems.AddRange(empCodeNameList);
            //if (doShowPopup)
            //    cmbAICustomer.ShowPopup();

        }
        
        private void bbtniAACBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            backPreviousForm();
        }

        private void bbtniAACReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshAll();
        }

        private void btnAACNewEmployee_Click(object sender, EventArgs e)
        {
            Form addEmployForm = new frmAddEmployee(this, new Presenter.Elements.EmployeePresenter());
            addEmployForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addEmployForm.MdiParent = this.MdiParent;
            addEmployForm.Dock = DockStyle.Fill;
            addEmployForm.Show();
        }
    }
}
