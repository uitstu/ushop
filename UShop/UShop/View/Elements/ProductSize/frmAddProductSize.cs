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
using View.Elements.Product;

namespace View.Elements.frmProductSize
{
    public partial class frmAddProductSize : Form
    {
        private ProductSizePresenter preProductSize;
        private Model.PRODUCT_SIZE obj;

        public frmAddProductSize()
        {
        }

        public frmAddProductSize(ProductSizePresenter preProductSize)
        {
            this.preProductSize = preProductSize;
            InitializeComponent();
            setSource();
        }

        public frmAddProductSize(ProductSizePresenter preProductSize, Model.PRODUCT_SIZE obj)
        {
            this.preProductSize = preProductSize;
            this.obj = obj;
            InitializeComponent();
            
            tboxQuantity.Text = obj.IN_STOCK_QUANTITY.ToString();
            
            foreach (DataRow d in preProductSize.loadProductDT(false).Rows)
            {
                int proID = Int32.Parse(d[0].ToString().Substring(d[0].ToString().IndexOf('0'), d[0].ToString().Length - d[0].ToString().IndexOf('0')));
                if (obj.PRODUCT_ID.Equals(proID))
                {
                    string str = d[0].ToString() + " - " + d[1].ToString();
                    cboxProduct.Text = str;
                    break;
                }
            }

            cboxSize.Text = obj.SIZE;
            
            setSource();
            
            foreach (DataRow d in preProductSize.loadProductDT(false).Rows)
            {
                int proID = Int32.Parse(d[0].ToString().Substring(d[0].ToString().IndexOf('0'), d[0].ToString().Length - d[0].ToString().IndexOf('0')));
                if (obj.PRODUCT_ID.Equals(proID))
                {
                    string str = d[0].ToString() + " - " + d[1].ToString();
                    cboxProduct.Text = str;
                    break;
                }
            }

            if (obj != null)
            {
                cboxProduct.ReadOnly = true;
                cboxSize.ReadOnly = true;
            }
        }

        public void setSource()
        {
            try
            {
                cboxProduct.Properties.Items.Clear();
                cboxSize.Properties.Items.Clear();
            }
            catch
            { }
            List<string> lst = new List<string>();
            foreach (DataRow d in preProductSize.loadProductDT(false).Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            
            cboxProduct.Properties.Items.AddRange(lst);
            cboxProduct.Properties.AutoComplete = false;

            List<string> lst1 = new List<string>();
            lst1.Add("S");
            lst1.Add("M");
            lst1.Add("L");
            lst1.Add("XL");
            lst1.Add("XXL");
            cboxSize.Properties.Items.AddRange(lst1);
            cboxSize.Properties.AutoComplete = true;

        }

        private void cboxProduct_TextChanged(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            foreach (DataRow d in preProductSize.loadProductDT(false).Rows)
            {
                if ((d[0].ToString() + " - " + d[1].ToString()).ToLower().Contains(cboxProduct.Text.ToString().ToLower()))
                    lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxProduct.Properties.Items.Clear();
            cboxProduct.Properties.Items.AddRange(lst);

            try
            {
                cboxProduct.ShowPopup();
            }
            catch (Exception ex)
            {
            }

            foreach (DataRow d in preProductSize.loadProductDT(false).Rows)
            {
                if (cboxProduct.Text.Contains(d[0].ToString()) && cboxProduct.Text.Contains(d[1].ToString()))
                {
                    int proID = Int32.Parse(d[0].ToString().Substring(d[0].ToString().IndexOf('0'), d[0].ToString().Length - d[0].ToString().IndexOf('0')));
                    cboxSize.Properties.Items.Clear();
                    cboxSize.Properties.Items.AddRange(preProductSize.getLstSize(proID));
                    break;
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (obj == null)
            {
                obj = new PRODUCT_SIZE();

                int proID = Int32.Parse(cboxProduct.Text.Substring(cboxProduct.Text.IndexOf('0'), cboxProduct.Text.IndexOf(' ') - cboxProduct.Text.IndexOf('0')));
                obj.PRODUCT_ID = proID;

                obj.SIZE = cboxSize.Text;
                obj.IN_STOCK_QUANTITY = Int32.Parse(tboxQuantity.Text);

                preProductSize.saveProductSize(obj);
            }
            else
            {
                int proID = Int32.Parse(cboxProduct.Text.Substring(cboxProduct.Text.IndexOf('0'), cboxProduct.Text.IndexOf(' ') - cboxProduct.Text.IndexOf('0')));
                obj.PRODUCT_ID = proID;

                obj.SIZE = cboxSize.Text;
                obj.IN_STOCK_QUANTITY = Int32.Parse(tboxQuantity.Text);
                preProductSize.updateProductSize(obj);
            }

            Close();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAdd = new frmAddProduct(new ProductPresenter());
            frmAdd.ShowDialog();
        }

        private void frmAddProductSize_Activated(object sender, EventArgs e)
        {
            setSource();
        }
    }
}
