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
    public partial class frmUShop : Form, IUShopView
    {
        private UShopPresenter preUShop;
        public frmUShop()
        {
            InitializeComponent();
            preUShop = new UShopPresenter(this);

            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SUPPLIER ushop = new SUPPLIER();
            ushop.SUPPLIER_NAME = tboxName.Text;
            ushop.ADDRESS = tboxAddress.Text;
            ushop.PHONE = tboxPhone.Text;
            ushop.TAX_CODE = tboxMST.Text;
            preUShop.updateUShop(ushop);
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
    }
}
