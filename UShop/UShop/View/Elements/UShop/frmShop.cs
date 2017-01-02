using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Model;
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
using View.Elements.Supplier;

namespace View.Elements
{
    public partial class frmShop : Form, IUShopView
    {
        Form beforeForm;
        private UShopPresenter preUShop;

        public frmShop()
        {
            InitializeComponent();
            preUShop = new UShopPresenter(this);
        }

        public frmShop(Form beforeForm)
        {
            InitializeComponent();
            preUShop = new UShopPresenter(this);
            this.beforeForm = beforeForm;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (tboxAddress.Text.Equals("") || tboxMST.Text.Equals("") || tboxName.Text.Equals("") || tboxPhone.Text.Equals(""))
                {
                    MessageBox.Show("Hãy nhập đủ thông tin");
                    return;
                }
                SUPPLIER ushop = new SUPPLIER();
                ushop.SUPPLIER_NAME = tboxName.Text;
                ushop.ADDRESS = tboxAddress.Text;
                ushop.PHONE = tboxPhone.Text;
                ushop.TAX_CODE = tboxMST.Text;
                preUShop.updateUShop(ushop);

                MessageBox.Show("Đã lưu");
            }
            catch (Exception ex)
            { }
        }

        public void loadUShop(Model.SUPPLIER ushop)
        {
            tboxName.Text = ushop.SUPPLIER_NAME;
            tboxAddress.Text = ushop.ADDRESS;
            tboxPhone.Text = ushop.PHONE;
            tboxMST.Text = ushop.TAX_CODE;
        }

        private void frmUShop_Activated(object sender, EventArgs e)
        {
            preUShop.loadUShop();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tboxAddress.Text = "";
            tboxMST.Text = "";
            tboxName.Text = "";
            tboxPhone.Text = "";
        }

    }
}
