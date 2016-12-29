using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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

namespace View.Elements.frmProductSize
{
    public partial class frmProductSize : Form, IProductSizeView
    {
        private ProductSizePresenter preProductSize;
        public frmProductSize()
        {
            InitializeComponent();
            preProductSize = new ProductSizePresenter(this);

            GridView gridView = gridProductSize.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }

            gridView.BeginSort();
            try
            {
                gridView.ClearGrouping();
                gridView.Columns["PRODUCT_NAME"].GroupIndex = 0;
            }
            finally
            {
                gridView1.EndSort();
            }

            this.WindowState = FormWindowState.Maximized;
        }

        //functions from interface
        public void loadProductSizes(DataTable dt)
        {
            gridProductSize.DataSource = dt;
        }

        //functions

        //events

        private void frmProductSize_Load(object sender, EventArgs e)
        {
            preProductSize.loadProductSizes();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddProductSize frmAdd = new frmAddProductSize(preProductSize);
            frmAdd.ShowDialog();
        }

        //btnUpdate
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridProductSize.FocusedView as GridView;
            Model.PRODUCT_SIZE obj = new Model.PRODUCT_SIZE();

            obj.PRODUCT_ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("PRODUCT_ID").ToString());
            obj.SIZE = gridView.GetFocusedRowCellValue("SIZE").ToString();
            obj.IN_STOCK_QUANTITY = Convert.ToInt32(gridView.GetFocusedRowCellValue("IN_STOCK_QUANTITY").ToString());

            frmAddProductSize frmAdd = new frmAddProductSize(preProductSize, obj);
            frmAdd.ShowDialog();
        }

        //btnDelete
        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete it?", "Deleting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            GridView gridView = gridProductSize.FocusedView as GridView;

            preProductSize.deleteProductSize(gridView.GetFocusedRowCellValue("PRODUCT_ID").ToString(), gridView.GetFocusedRowCellValue("SIZE").ToString());
        }

        private void frmProductSize_Activated(object sender, EventArgs e)
        {
            preProductSize.loadProductSizes();
        }

    }
}
