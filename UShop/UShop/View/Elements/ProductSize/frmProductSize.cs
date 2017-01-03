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
            gridView.GroupPanelText = "Thả một tiêu đề ở đây để nhóm thông tin";

            gridView.BeginSort();
            try
            {
                gridView.ClearGrouping();
                gridView.Columns["PRODUCT_CODE_NAME"].GroupIndex = 0;
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
            //frmAddProductSize frmAdd = new frmAddProductSize(preProductSize);
            //frmAdd.ShowDialog();
            frmAddProductSize frmAdd = new frmAddProductSize(preProductSize, this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        //btnUpdate
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridProductSize.FocusedView as GridView;
            Model.PRODUCT_SIZE obj = new Model.PRODUCT_SIZE();

            obj.PRODUCT_ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("PRODUCT_ID").ToString());
            obj.SIZE = gridView.GetFocusedRowCellValue("SIZE").ToString();
            obj.IN_STOCK_QUANTITY = Convert.ToInt32(gridView.GetFocusedRowCellValue("IN_STOCK_QUANTITY").ToString());

            //frmAddProductSize frmAdd = new frmAddProductSize(preProductSize, obj);
            //frmAdd.ShowDialog();
            frmAddProductSize frmAdd = new frmAddProductSize(preProductSize, obj, this);
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

            GridView gridView = gridProductSize.FocusedView as GridView;

            preProductSize.deleteProductSize(gridView.GetFocusedRowCellValue("PRODUCT_ID").ToString(), gridView.GetFocusedRowCellValue("SIZE").ToString());
        }

        private void frmProductSize_Activated(object sender, EventArgs e)
        {
            preProductSize.loadProductSizes();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = gridProductSize.FocusedView as GridView;

                gridView.Columns[5].Visible = false;
                gridView.Columns[6].Visible = false;

                gridProductSize.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[5].Visible = true;
                gridView.Columns[6].Visible = true;
            }
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = gridProductSize.FocusedView as GridView;

                gridView.Columns[5].Visible = false;
                gridView.Columns[6].Visible = false;

                gridProductSize.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[5].Visible = true;
                gridView.Columns[6].Visible = true;
            }
        }

       

    }
}
