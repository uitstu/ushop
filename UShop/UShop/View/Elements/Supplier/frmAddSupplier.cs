
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

namespace View.Elements.Supplier
{
    public partial class frmAddSupplier : Form
    {
        private SupplierPresenter preSupplier;
        private Model.SUPPLIER obj;

        public frmAddSupplier()
        {
        }

        public frmAddSupplier(SupplierPresenter preSupplier)
        {
            this.preSupplier = preSupplier;
            InitializeComponent();
        }

        public frmAddSupplier(SupplierPresenter preSupplier, Model.SUPPLIER obj)
        {
            this.preSupplier = preSupplier;
            this.obj = obj;
            InitializeComponent();

            tboxName.Text = obj.SUPPLIER_NAME;
            tboxTaxCode.Text = obj.TAX_CODE;
            tboxPhone.Text = obj.PHONE;
            tboxAddress.Text = obj.ADDRESS;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (obj == null)
            {
                obj = new Model.SUPPLIER();

                obj.SUPPLIER_NAME = tboxName.Text;
                obj.TAX_CODE = tboxTaxCode.Text;
                obj.PHONE = tboxPhone.Text;
                obj.ADDRESS = tboxAddress.Text;
                obj.RECORD_STATUS = "A";

                preSupplier.saveSupplier(obj);
            }
            else
            {
                obj.SUPPLIER_NAME = tboxName.Text;
                obj.TAX_CODE = tboxTaxCode.Text;
                obj.PHONE = tboxPhone.Text;
                obj.ADDRESS = tboxAddress.Text;
                obj.RECORD_STATUS = "A";

                preSupplier.updateSupplier(obj);
            }

            Close();
        }


    }
}
