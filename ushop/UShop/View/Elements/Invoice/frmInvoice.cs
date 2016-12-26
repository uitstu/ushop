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

namespace View.Elements.Invoice
{
    public partial class frmInvoice : Form, IInvoiceView
    {
        //will put into Resources
        public static String ERROR_CAPTION  =   "Lỗi";
        public static String INFOR_CAPTION  =   "Thông báo";

        InvoicePresenter presenter;
        public frmInvoice()
        {
            presenter = new InvoicePresenter(new InvoiceModel());
            presenter.InvoiceView = this;
            InitializeComponent();
        }

        public void showInvoiceList(DataTable invoiceTable)
        {
            grdvILInvoice.DataSource = invoiceTable;
        }

        public void showInvoiceList(List<INVOICE> invoiceList)
        {
            

            grdvILInvoice.DataSource = invoiceList;
        }

        public void showMessageBox(string msg, MessageBoxIcon type)
        {
            switch(type)
            {
                case MessageBoxIcon.Error:

                    MessageBox.Show(msg, ERROR_CAPTION, MessageBoxButtons.OK, type);
                    break;
                case MessageBoxIcon.Information:

                    MessageBox.Show(msg, INFOR_CAPTION, MessageBoxButtons.OK, type);
                    break;
            }
        }

        private void bbtniILAddInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form addInvoiceForm = new frmAddInvoice(this,presenter);
            addInvoiceForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addInvoiceForm.MdiParent = this.MdiParent;
            addInvoiceForm.Dock = DockStyle.Fill;
            addInvoiceForm.Show();
        }
    }
}
