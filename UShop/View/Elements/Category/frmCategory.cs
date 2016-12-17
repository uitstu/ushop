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
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;// .Settings.AutoFilterCondition = AutoFilterCondition.Contains;
            }
        }

        //functions from interface
        public void loadCategories(List<Model.Category> listObj)
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
            frmAddCategory frmAdd = new frmAddCategory(preCategory);
            frmAdd.ShowDialog();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridCategory.FocusedView as GridView;
            //object row = gridView.GetRow(gridView.FocusedRowHandle);

            preCategory.deleteCategory(gridView.GetFocusedRowCellValue("CategoryID").ToString());
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridCategory.FocusedView as GridView;
            Model.Category obj = new Model.Category();

            obj.CategoryID = Convert.ToInt32(gridView.GetFocusedRowCellValue("CategoryID").ToString());
            obj.CategoryName = gridView.GetFocusedRowCellValue("CategoryName").ToString();
            obj.CategoryDescription = gridView.GetFocusedRowCellValue("CategoryDescription").ToString();

            frmAddCategory frmAdd = new frmAddCategory(preCategory, obj);
            frmAdd.ShowDialog();
        }

        private void updateCategory_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
        {
            
        }

        private void updateCategory_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            
        }

        
    }
}
