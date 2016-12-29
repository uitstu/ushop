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
using Model;
using Presenter.Elements;
using Model.InterfaceImplements;
using Model.Properties;
using DevExpress.XtraEditors.Controls;
using Presenter.InterfaceImplement;

namespace View.Elements.Invoice
{
    public partial class frmInvoice : Form, IInvoiceView
    {
        DataTable table;
        InvoicePresenter presenter;
        public frmInvoice()
        {
            presenter = new InvoicePresenter(new InvoiceModel());
            presenter.InvoiceView = this;
            InitializeComponent();
            presenter.loadInvoiceList();
        }

        public void showInvoiceList(DataTable invoiceTable)
        {
            table = invoiceTable;
            grdconILInvoice.DataSource = table;
        }

        public void showInvoiceList(List<INVOICE> invoiceList)
        {
            

            grdconILInvoice.DataSource = invoiceList;
        }

        public void showMessageBox(string msg, MessageBoxIcon type)
        {
            switch(type)
            {
                case MessageBoxIcon.Error:

                    MessageBox.Show(msg, Resources.ERROR_CAPTION, MessageBoxButtons.OK, type);
                    break;
                case MessageBoxIcon.Information:

                    MessageBox.Show(msg, Resources.INFOR_CAPTION, MessageBoxButtons.OK, type);
                    break;
            }
        }

        private void bbtniILAddInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Check permission for INVOICE ! Look it and just change form type for current form
            if (!AccountPresenter.checkPermission(FORM_TYPE.ADDING_INVOICE))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form addInvoiceForm = new frmAddInvoice(this,presenter);
            addInvoiceForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addInvoiceForm.MdiParent = this.MdiParent;
            addInvoiceForm.Dock = DockStyle.Fill;
            addInvoiceForm.Show();
        }

        private void btnILUpdateInvoice_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //Check permission for INVOICE ! Look it and just change form type for current form
            if (!AccountPresenter.checkPermission(FORM_TYPE.ADDING_INVOICE))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            int row = gvILInvoice.FocusedRowHandle;
            String invoiceCode =  table.Rows[row]["INVOICE_CODE"] + "";
            Form addInvoiceForm = new frmAddInvoice(this, presenter, invoiceCode);
            addInvoiceForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addInvoiceForm.MdiParent = this.MdiParent;
            addInvoiceForm.Dock = DockStyle.Fill;
            addInvoiceForm.Show();
            // presenter.loadExistedInvoice(invoiceId);
        }
        private void btnILDeleteInvoice_ButtonClick(object sender,ButtonPressedEventArgs e)
        {
            int indexOfGrid = gvILInvoice.FocusedRowHandle;
            presenter.removeInvoice(indexOfGrid);
        }

        public DataTable getDataTable()
        {
            return table;
        }

        private void frmInvoice_Activated(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadInvoiceList();
        }
    }
}
