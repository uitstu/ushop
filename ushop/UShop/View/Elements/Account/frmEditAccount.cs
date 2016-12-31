using Model;
using Model.Properties;
using Presenter.InterfaceImplement;
using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Elements.Account
{
    public partial class frmEditAccount : Form, IAccountAddingView
    {
        private Form caller;
        private string updatedAccCode;
        private AccountPresenter presenter;
        public frmEditAccount(Form caller, AccountPresenter presenter)
        {
            InitializeComponent();
            this.caller = caller;
            this.presenter = presenter;

            presenter.AccAddingView = this;

            refreshAll();

            presenter.loadExistedAccountByEmp(AccountPresenter.currentEmployee);

        }

      

        private void bbtniEAAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string empCode = txteEAEmployeeCodeName.Text.ToString().Split(new char[] { '-' })[0];
            string id = txteEAAccountCode.Text;
            string password = txteEACPassword.Text;
            presenter.insertOrUpdateAccount(empCode, id, password);
        }

        private void bbtniEABack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            backPreviousForm();
        }
        
        



        public void showInforComponents(ACCOUNT acc, String cusCodeName)
        {
            try
            {
                txteEAAccountCode.Text = acc.ACC_CODE;
                txteEACPassword.Text = acc.PASSWORD;
                txteEAEmployeeCodeName.Text = cusCodeName;
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
            txteEAAccountCode.ResetText();
            txteEACPassword.ResetText();
            txteEAEmployeeCodeName.ResetText();

            presenter.loadExistedAccount(updatedAccCode);


        }

        public void backPreviousForm()
        {
            foreach (var form in MdiParent.MdiChildren)
            {

                if (caller.Equals(form))
                {
                    caller.Activate();

                }
            }
            this.Close();
        }

        public void showEmployeeName(List<String> empCodeNameList)
        {
            if(empCodeNameList.Count >0)
                txteEAEmployeeCodeName.Text = empCodeNameList.ElementAt(0);
           

        }

       
    }
}
