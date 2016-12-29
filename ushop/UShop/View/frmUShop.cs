using Model;
using Presenter.InterfaceImplement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using View.Elements;
using View.Elements.Account;
using View.Elements.Appointment;
using View.Elements.Customer;
using View.Elements.Employee;
using View.Elements.frmProductSize;
using View.Elements.Invoice;
using View.Elements.Product;
using View.Elements.ReceiptNote;

namespace View
{
    public partial class frmUShop : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public frmUShop()
        {
            InitializeComponent();
        }
        private void btnProductManagement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private Form checkExist(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.CATEGORY))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form frm = this.checkExist(typeof(frmCategory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCategory f = new frmCategory();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmUShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void frmUShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReceiptNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.RECEIPTNOTE))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form frm = this.checkExist(typeof(frmReceiptNote));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmReceiptNote f = new frmReceiptNote();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barbtnInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.INVOICE))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form invoiceListForm = this.checkExist(typeof(frmInvoice));

            if(invoiceListForm != null)
            {
                invoiceListForm.Activate();
            }
            else
            {
                //create new one
                invoiceListForm = new frmInvoice();
                invoiceListForm.MdiParent = this;
                //set fill parent
                invoiceListForm.Dock = DockStyle.Fill;
                //turn off border style
                invoiceListForm.FormBorderStyle = FormBorderStyle.None;
                //show
                invoiceListForm.Show();
            }
        }

        private void barbtnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.EMPLOYEE))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form empListForm = this.checkExist(typeof(frmEmployee));

            if (empListForm != null)
            {
                empListForm.Activate();
            }
            else
            {
                //create new one
                empListForm = new frmEmployee();
                empListForm.MdiParent = this;
                //set fill parent
                empListForm.Dock = DockStyle.Fill;
                //turn off border style
                empListForm.FormBorderStyle = FormBorderStyle.None;
                //show
                empListForm.Show();
            }
        }

        private void barbtniCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.CUSTOMER))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form cusListForm = this.checkExist(typeof(frmCustomer));

            if (cusListForm != null)
            {
                cusListForm.Activate();
            }
            else
            {
                //create new one
                cusListForm = new frmCustomer();
                cusListForm.MdiParent = this;
                //set fill parent
                cusListForm.Dock = DockStyle.Fill;
                //turn off border style
                cusListForm.FormBorderStyle = FormBorderStyle.None;
                //show
                cusListForm.Show();
            }
        }
        
        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmProduct));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmProduct f = new frmProduct();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnProductSize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmProductSize));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmProductSize f = new frmProductSize();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExist(typeof(frmSupplier));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSupplier f = new frmSupplier();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barbtniAppointment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.APPOINTMENT))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form appListForm = this.checkExist(typeof(frmAppointment));

            if (appListForm != null)
            {
                appListForm.Activate();
            }
            else
            {
                //create new one
                appListForm = new frmAppointment();
                appListForm.MdiParent = this;
                //set fill parent
                appListForm.Dock = DockStyle.Fill;
                //turn off border style
                appListForm.FormBorderStyle = FormBorderStyle.None;
                //show
                appListForm.Show();
            }
        }

        private void barbtniAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.ACCOUNT))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form accListForm = this.checkExist(typeof(frmAccount));

            if (accListForm != null)
            {
                accListForm.Activate();
            }
            else
            {
                //create new one
                accListForm = new frmAccount();
                accListForm.MdiParent = this;
                //set fill parent
                accListForm.Dock = DockStyle.Fill;
                //turn off border style
                accListForm.FormBorderStyle = FormBorderStyle.None;
                //show
                accListForm.Show();
            }
        }
    }
}
