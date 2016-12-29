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

namespace View.Elements.Product
{
    public partial class frmProduct : Form, IProductView
    {
        private ProductPresenter preProduct;
        public frmProduct()
        {
            InitializeComponent();
            preProduct = new ProductPresenter(this);

            GridView gridView = gridProduct.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }
        }

        //functions from interface
        public void loadProducts(List<Model.PRODUCT> listObj)
        {
            gridProduct.DataSource = listObj;
        }

        public void loadProductList(DataTable dt)
        {
            gridProduct.DataSource = dt;
        }

        //functions

        //events

        private void frmProduct_Load(object sender, EventArgs e)
        {
            //preProduct.loadProducts();
            preProduct.loadProductList();
        }

        //btnUpdate
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridProduct.FocusedView as GridView;
            Model.PRODUCT obj = new Model.PRODUCT();

            obj.PRODUCT_ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("PRODUCT_ID").ToString());
            obj.PRODUCT_CODE = gridView.GetFocusedRowCellValue("PRODUCT_CODE").ToString();
            obj.PRODUCT_NAME = gridView.GetFocusedRowCellValue("PRODUCT_NAME").ToString();
            obj.CATEGORY_ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("CATEGORY_ID").ToString());
            obj.UNIT = gridView.GetFocusedRowCellValue("UNIT").ToString();
            obj.SELLING_PRICE = Convert.ToInt32(gridView.GetFocusedRowCellValue("SELLING_PRICE").ToString());
            obj.COST_PRICE = Convert.ToInt32(gridView.GetFocusedRowCellValue("COST_PRICE").ToString());
            obj.SALE_AMOUNT = Convert.ToInt32(gridView.GetFocusedRowCellValue("SALE_AMOUNT").ToString());
            obj.DESCRIPTION = gridView.GetFocusedRowCellValue("DESCRIPTION").ToString();
            obj.ORIGIN = gridView.GetFocusedRowCellValue("ORIGIN").ToString();
            obj.DESCRIPTION = gridView.GetFocusedRowCellValue("DESCRIPTION").ToString();

            frmAddProduct frmAdd = new frmAddProduct(preProduct, obj);
            frmAdd.ShowDialog();
        }

        //benDelete
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

            GridView gridView = gridProduct.FocusedView as GridView;

            preProduct.deleteProduct(gridView.GetFocusedRowCellValue("PRODUCT_ID").ToString());
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddProduct frmAdd = new frmAddProduct(preProduct);
            frmAdd.ShowDialog();
        }

    }
}
