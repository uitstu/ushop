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
using View.Elements.Category;

namespace View.Elements
{
    public partial class frmCategory : Form, ICategoryView
    {
        private CategoryPresenter preCategory;
        public frmCategory()
        {
            InitializeComponent();
            preCategory = new CategoryPresenter(this);

            GridView gridView = gridCategory.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }

            gridView.GroupPanelText = "Thả một tiêu đề ở đây để nhóm thông tin";
        }

        //functions from interface
        public void loadCategories(List<Model.CATEGORY> listObj)
        {
            gridCategory.DataSource = listObj;
        }


        //functions

        //events
        private void frmCategory_Load(object sender, EventArgs e)
        {
            preCategory.loadCategories();
        }

        private void btnCategoryAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmAddCategory frmAdd = new frmAddCategory(preCategory);
            //frmAdd.ShowDialog();
            Form frmAdd = new frmAddCategory(preCategory, this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            GridView gridView = gridCategory.FocusedView as GridView;
            //object row = gridView.GetRow(gridView.FocusedRowHandle);

            preCategory.deleteCategory(gridView.GetFocusedRowCellValue("CATEGORY_ID").ToString());
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridCategory.FocusedView as GridView;
            Model.CATEGORY obj = new Model.CATEGORY();

            obj.CATEGORY_ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("CATEGORY_ID").ToString());
            obj.CATEGORY_NAME = gridView.GetFocusedRowCellValue("CATEGORY_NAME").ToString();
            obj.DESCRIPTION = gridView.GetFocusedRowCellValue("DESCRIPTION").ToString();

            //frmAddCategory frmAdd = new frmAddCategory(preCategory, obj);
            //frmAdd.ShowDialog();
            Form frmAdd = new frmAddCategory(preCategory, obj, this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void updateCategory_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            
        }

        private void updateCategory_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            
        }

        private void frmCategory_Activated(object sender, EventArgs e)
        {
            preCategory.loadCategories();
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnPrintExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = gridCategory.FocusedView as GridView;

                gridView.Columns[3].Visible = false;
                gridView.Columns[4].Visible = false;

                gridCategory.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[3].Visible = true;
                gridView.Columns[4].Visible = true;
            }
        }

        private void btnPrintPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = gridCategory.FocusedView as GridView;

                gridView.Columns[3].Visible = false;
                gridView.Columns[4].Visible = false;

                gridCategory.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[3].Visible = true;
                gridView.Columns[4].Visible = true;
            }
        }

        
    }
}
