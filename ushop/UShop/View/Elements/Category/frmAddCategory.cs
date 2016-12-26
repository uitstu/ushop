
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

            Close();
        }
    }
}
