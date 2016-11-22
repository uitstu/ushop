using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using View.Elements;

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
            Form frm = this.checkExist(typeof(frmProductCategory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmProductCategory f = new frmProductCategory();
                f.MdiParent = this;
                f.Show();
            }
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

    }
}
