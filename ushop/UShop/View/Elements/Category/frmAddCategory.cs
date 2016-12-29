
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
        private Form beforeForm;
        private CategoryPresenter preCategory;
        private Model.CATEGORY obj;

        public frmAddCategory()
        {
        }

        public frmAddCategory(CategoryPresenter preCategory)
        {
            this.preCategory = preCategory;
            InitializeComponent();
        }

        public frmAddCategory(CategoryPresenter preCategory, Model.CATEGORY obj)
        {
            this.preCategory = preCategory;
            this.obj = obj;
            InitializeComponent();

            edtCategoryName.Text = obj.CATEGORY_NAME;
            edtCategoryDescription.Text = obj.DESCRIPTION;
        }

        public frmAddCategory(CategoryPresenter preCategory, Form beforeForm)
        {
            this.preCategory = preCategory;
            this.beforeForm = beforeForm;
            InitializeComponent();
        }

        public frmAddCategory(CategoryPresenter preCategory, Model.CATEGORY obj, Form beforeForm)
        {
            this.preCategory = preCategory;
            this.obj = obj;
            this.beforeForm = beforeForm;
            InitializeComponent();

            edtCategoryName.Text = obj.CATEGORY_NAME;
            edtCategoryDescription.Text = obj.DESCRIPTION;
        }

        private void btnCategorySave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (obj == null)
            {
                obj = new Model.CATEGORY();

                obj.CATEGORY_NAME = edtCategoryName.Text;
                obj.DESCRIPTION = edtCategoryDescription.Text;
                obj.RECORD_STATUS = "A";

                preCategory.saveCategory(obj);
            }
            else
            {
                obj.CATEGORY_NAME = edtCategoryName.Text;
                obj.DESCRIPTION = edtCategoryDescription.Text;
                obj.RECORD_STATUS = "A";

                preCategory.updateCategory(obj);
            }

            this.beforeForm.WindowState = FormWindowState.Maximized;
            this.beforeForm.Activate();
            //Close();
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Close();
            this.beforeForm.WindowState = FormWindowState.Maximized;
            this.beforeForm.Activate();
            //this.WindowState = FormWindowState.Minimized;
        }

        private void frmAddCategory_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
