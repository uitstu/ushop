using DevExpress.XtraEditors.Controls;
using Model.Properties;
using Presenter.Elements;
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

namespace View.Elements.Customer
{
    public partial class frmCustomer : Form,ICustomerView
    {

        CustomerPresenter presenter;
        DataTable table;

        public frmCustomer()
        {
            InitializeComponent();
            presenter = new CustomerPresenter();
            presenter.CusView = this;
            presenter.loadCustomerList();
        }

        public DataTable getCustomerTable()
        {
            table = grdconCLCustomer.DataSource as DataTable;
            return table;
        }

        public void showCustomerList(DataTable table)
        {
            this.table = table;
            grdconCLCustomer.DataSource = table;
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

        private void bbtniELAddInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form addCusForm = new frmAddCustomer(this, presenter);
            addCusForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addCusForm.MdiParent = this.MdiParent;
            addCusForm.Dock = DockStyle.Fill;
            addCusForm.Show();
        }

        private void btnELUpdateInvoice_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            Form addCusForm = new frmAddCustomer(this, presenter, table.Rows[gvCLCustomer.FocusedRowHandle]["CUS_CODE"] + "");
            addCusForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addCusForm.MdiParent = this.MdiParent;
            addCusForm.Dock = DockStyle.Fill;
            addCusForm.Show();
        }

        private void btnELDeleteInvoice_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int index = gvCLCustomer.FocusedRowHandle;
            presenter.removeCustomer(index);
        }

        private void frmEmployee_Activated(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadCustomerList();
        }
    }
}
