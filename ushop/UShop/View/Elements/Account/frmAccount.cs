using DevExpress.XtraEditors.Controls;
using Model;
using Model.Properties;
using Presenter.Interface;
using Presenter.InterfaceImplement;
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
    public partial class frmAccount : Form,IAccountView
    {
        AccountPresenter presenter;
        DataTable table;
        public frmAccount()
        {
            
            InitializeComponent();
            presenter = new AccountPresenter();
            presenter.AccView = this;
            presenter.loadAccountList();
        }


        public void showAccountList(DataTable table)
        {
            this.table = table;
            grdconAMAccount.DataSource = table;
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


        private void btnAMUpdateAccount_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.ADDING_ACCOUNT))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            String accCode = table.Rows[gvAMAccount.FocusedRowHandle]["ACC_CODE"] + "";
            Form addAccForm = new frmAddAccount(this, presenter, accCode);
            addAccForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addAccForm.MdiParent = this.MdiParent;
            addAccForm.Dock = DockStyle.Fill;
            addAccForm.Show();
        }

        private void btnAMDeleteAccount_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int index = gvAMAccount.FocusedRowHandle;
            presenter.removeAccount(index);
        }


        public DataTable getAccountTable()
        {
            table = grdconAMAccount.DataSource as DataTable;
            return table;
        }

        
        

        private void bbtniAMAddAccount_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.ADDING_ACCOUNT))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form addAccForm = new frmAddAccount(this, presenter);
            addAccForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addAccForm.MdiParent = this.MdiParent;
            addAccForm.Dock = DockStyle.Fill;
            addAccForm.Show();
        }

        private void frmAccount_Activated(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadAccountList();
        }
    }
}
