using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using View.Elements;
using View.Elements.Invoice;
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

        public Form checkExist(Type fType)
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
    }
}
