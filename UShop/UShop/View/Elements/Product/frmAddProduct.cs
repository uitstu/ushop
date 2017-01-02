using Model;
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

namespace View.Elements.Product
{
    public partial class frmAddProduct : Form
    {
        Form beforeForm;
        private ProductPresenter preProduct;
        private Model.PRODUCT obj;

        public frmAddProduct()
        {
        }

        public frmAddProduct(ProductPresenter preProduct)
        {
            this.preProduct = preProduct;
            InitializeComponent();
            setSource();
        }

        public frmAddProduct(ProductPresenter preProduct, Form beforeForm)
        {
            this.preProduct = preProduct;
            this.beforeForm = beforeForm;
            InitializeComponent();
            setSource();
        }

        public frmAddProduct(ProductPresenter preProduct, Model.PRODUCT obj, Form beforeForm)
            : this(preProduct, obj)
        {
            this.beforeForm = beforeForm;
        }

        public frmAddProduct(ProductPresenter preProduct, Model.PRODUCT obj)
        {
            this.preProduct = preProduct;
            this.obj = obj;
            InitializeComponent();

            tboxName.Text = obj.PRODUCT_NAME;
            tboxPrice.Text = obj.SELLING_PRICE.ToString();
            tboxCost.Text = obj.COST_PRICE.ToString();
            tboxSale.Text = obj.SALE_AMOUNT.ToString();

            foreach (DataRow d in preProduct.loadCategoryDT(false).Rows)
            {
                int catID = Int32.Parse(d[0].ToString().Substring(d[0].ToString().IndexOf('0'), d[0].ToString().Length - d[0].ToString().IndexOf('0')));
                if (obj.CATEGORY_ID.Equals(catID))
                {
                    string str = d[0].ToString() + " - " + d[1].ToString();
                    cboxCategory.Text = str;
                    break;
                }
            }

            cboxGender.Text = obj.UNIT;
            tboxProducer.Text = obj.PRODUCER;
            tboxOrigin.Text = obj.ORIGIN;
            tboxNote.Text = obj.DESCRIPTION;

            setSource();

            foreach (DataRow d in preProduct.loadCategoryDT(false).Rows)
            {
                int catID = Int32.Parse(d[0].ToString().Substring(d[0].ToString().IndexOf('0'), d[0].ToString().Length - d[0].ToString().IndexOf('0')));
                if (obj.CATEGORY_ID.Equals(catID))
                {
                    string str = d[0].ToString() + " - " + d[1].ToString();
                    cboxCategory.Text = str;
                    break;
                }
            }
            
        }

        public void setSource()
        {
            try
            {
                cboxCategory.Properties.Items.Clear();
                cboxGender.Properties.Items.Clear();
            }
            catch
            { }
            List<string> lst = new List<string>();
            foreach (DataRow d in preProduct.loadCategoryDT(false).Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxCategory.Properties.Items.AddRange(lst);
            cboxCategory.Properties.AutoComplete = false;

            List<string> lst1 = new List<string>();
            lst1.Add("Cái");
            lst1.Add("Bộ");
            cboxGender.Properties.Items.AddRange(lst1);
            cboxGender.Properties.AutoComplete = true;
        }

        private void cboxCategory_TextChanged(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            foreach (DataRow d in preProduct.loadCategoryDT(false).Rows)
            {
                if ((d[0].ToString() + " - " + d[1].ToString()).ToLower().Contains(cboxCategory.Text.ToString().ToLower()))
                    lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxCategory.Properties.Items.Clear();
            cboxCategory.Properties.Items.AddRange(lst);

            try
            {
                cboxCategory.ShowPopup();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tboxName.Text.Equals(""))
            {
                MessageBox.Show("Tên hàng không được rỗng");
                return;
            }

            int price, cost, sale = 0;
            try
            {
                price = Int32.Parse(tboxCost.Text);
                cost = Int32.Parse(tboxCost.Text);
                sale = Int32.Parse(tboxSale.Text);
            }
            catch
            {
                MessageBox.Show("Giá bán, giá nhập và tiền giảm phải là số");
                return;
            }

            if (price == 0 || cost == 0)
            {
                MessageBox.Show("Giá bán và giá nhập phải lớn hơn 0");
                return;
            }

            if (sale > price)
            {
                MessageBox.Show("Tiền giảm không được lớn hơn giá bán");
                return;
            }

            if (obj == null)
            {
                obj = new PRODUCT();
                obj.PRODUCT_NAME = tboxName.Text;
                obj.SELLING_PRICE = Int32.Parse(tboxPrice.Text);
                obj.COST_PRICE = Int32.Parse(tboxCost.Text);
                obj.SALE_AMOUNT = Int32.Parse(tboxSale.Text);
                int catID = Int32.Parse(cboxCategory.Text.Substring(cboxCategory.Text.IndexOf('0'), cboxCategory.Text.IndexOf(' ') - cboxCategory.Text.IndexOf('0')+1));
                obj.CATEGORY_ID = catID;
                obj.UNIT = cboxGender.Text;
                obj.PRODUCER = tboxProducer.Text;
                obj.ORIGIN = tboxOrigin.Text;
                obj.DESCRIPTION = tboxNote.Text;
                obj.RECORD_STATUS = "A";
                preProduct.saveProduct(obj);
            }
            else
            {
                obj.PRODUCT_NAME = tboxName.Text;
                obj.SELLING_PRICE = Int32.Parse(tboxPrice.Text);
                obj.COST_PRICE = Int32.Parse(tboxCost.Text);
                obj.SALE_AMOUNT = Int32.Parse(tboxSale.Text);
                int catID = Int32.Parse(cboxCategory.Text.Substring(cboxCategory.Text.IndexOf('0'), cboxCategory.Text.IndexOf(' ') - cboxCategory.Text.IndexOf('0')));
                obj.CATEGORY_ID = catID;
                obj.UNIT = cboxGender.Text;
                obj.PRODUCER = tboxProducer.Text;
                obj.ORIGIN = tboxOrigin.Text;
                obj.DESCRIPTION = tboxNote.Text;
                obj.RECORD_STATUS = "A";
                preProduct.updateProduct(obj);
            }

            this.beforeForm.WindowState = FormWindowState.Maximized;
            this.beforeForm.Activate();
            //Close();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            //frmAddCategory frmAdd = new frmAddCategory(new CategoryPresenter());
            //frmAdd.ShowDialog();
            Form frmAdd = new frmAddCategory(new CategoryPresenter(), this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void frmAddProduct_Activated(object sender, EventArgs e)
        {
            setSource();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            this.beforeForm.WindowState = FormWindowState.Maximized;
            this.beforeForm.Activate();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tboxName.Text = "";
            tboxPrice.Text = "0";
            tboxCost.Text = "0";
            tboxSale.Text = "0";
            tboxNote.Text = "";
            tboxProducer.Text = "";
            tboxOrigin.Text = "";
        }
    }
}
