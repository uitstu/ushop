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
            gridView.GroupPanelText = "Thả một tiêu đề ở đây để nhóm thông tin";
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
            obj.PRODUCER = gridView.GetFocusedRowCellValue("PRODUCER").ToString();

            //frmAddProduct frmAdd = new frmAddProduct(preProduct, obj);
            //frmAdd.ShowDialog();
            frmAddProduct frmAdd = new frmAddProduct(preProduct, obj, this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        //btnDelete
        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
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
            //frmAddProduct frmAdd = new frmAddProduct(preProduct);
            //frmAdd.ShowDialog();
            frmAddProduct frmAdd = new frmAddProduct(preProduct,this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void frmProduct_Activated(object sender, EventArgs e)
        {
            preProduct.loadProductList();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = gridProduct.FocusedView as GridView;

                gridView.Columns[10].Visible = false;
                gridView.Columns[11].Visible = false;

                gridProduct.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[10].Visible = true;
                gridView.Columns[11].Visible = true;
            }
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = gridProduct.FocusedView as GridView;

                gridView.Columns[10].Visible = false;
                gridView.Columns[11].Visible = false;

                gridProduct.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[10].Visible = true;
                gridView.Columns[11].Visible = true;
            }
        }

    }
}
