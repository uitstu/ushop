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

namespace View.Elements
{
    public partial class frmProductCategory : Form, IProductCategoryView
    {
        private ProductCategoryPresenter presenter;
        public frmProductCategory()
        {
            InitializeComponent();
            presenter = new ProductCategoryPresenter(this);
        }

        private void frmProductCategory_Load(object sender, EventArgs e)
        {
            if (loadProductCategories != null)
            {
                loadProductCategories(sender, e);
            }
        }

        public List<Model.ProductCategory> ProductCategories
        {
            set { gridProductCategory.DataSource = value; }
        }

        public event EventHandler loadProductCategories;
    }
}
