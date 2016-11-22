
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

namespace View.Elements.Category
{
    public partial class frmAddCategory : Form
    {
        private CategoryPresenter preCategory;
        private Model.Category obj;

        public frmAddCategory()
        {
        }

        public frmAddCategory(CategoryPresenter preCategory)
        {
            this.preCategory = preCategory;
            InitializeComponent();
        }

        public frmAddCategory(CategoryPresenter preCategory, Model.Category obj)
        {
            this.preCategory = preCategory;
            this.obj = obj;
            InitializeComponent();

            edtCategoryName.Text = obj.CategoryName;
            edtCategoryDescription.Text = obj.CategoryDescription;
        }

        private void btnCategorySave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (obj == null)
            {
                obj = new Model.Category();

                obj.CategoryName = edtCategoryName.Text;
                obj.CategoryDescription = edtCategoryDescription.Text;
                obj.IsActive = true;

                preCategory.saveCategory(obj);
            }
            else
            {
                obj.CategoryName = edtCategoryName.Text;
                obj.CategoryDescription = edtCategoryDescription.Text;
                obj.IsActive = true;

                preCategory.updateCategory(obj);
            }

            Close();
        }
    }
}
