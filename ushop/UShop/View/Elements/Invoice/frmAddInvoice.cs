using Model.Properties;
using Presenter.Elements;
using Presenter.InterfaceImplement;
using Presenter.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Elements.Invoice
{
    public partial class frmAddInvoice : Form,IInvoiceAddingView
    {
        DataTable table;
        InvoicePresenter presenter;
        Form caller;
        public frmAddInvoice(Form caller,InvoicePresenter presenter)
        {
            this.caller = caller;
            this.presenter = presenter;
            this.presenter.InvoiceAddingView = this;
            InitializeComponent();
            //load product name into cmb
            presenter.loadProductName(null,false);
            //load customer name into cmb
            presenter.loadCustomerName(null, false);
            //load payment method into cmb
            cmbAIPaymentMethod.Properties.Items.AddRange
                (new String[] {
                     Resources.PM_CASH
                ,    Resources.PM_TRANSFER
                ,    Resources.PM_UNIDENTIFY });
            txteAIVAT.Text = "0";
            txteAIEmployee.Text =  AccountPresenter.currentEmployee.EMP_NAME;
            txteAIInvoiceNo.Text = presenter.getTemperatoryCode();
            cmbAISize.Properties.Items.AddRange(
                new String[]
                {
                    Resources.SIZE_S,
                    Resources.SIZE_M,
                    Resources.SIZE_L,
                    Resources.SIZE_XL,
                    Resources.SIZE_XXL,
                    Resources.SIZE_XXXL});
            table = grdconAIItems.DataSource as DataTable;
            if (table == null)
            {
                table = new DataTable();
                var cols = table.Columns;
                cols.Add("Mã chi tiết");
                cols.Add("Tên sản phẩm");
                cols.Add("Kích cỡ");
                cols.Add("Loại");
                cols.Add("DVT");
                cols.Add("Giảm");
                cols.Add("Số lượng");
                cols.Add("Đơn giá");
                cols.Add("Thành tiền");
                cols.Add("Mô tả");

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bbtniAIBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            foreach( var form in MdiParent.MdiChildren)
            {

                if (caller.Equals(form))
                {
                    caller.Activate();

                }
            }
            this.Close();
        }

        private void cmbAICustomer_TextChanged(object sender, EventArgs e)
        {

            presenter.loadCustomerName(cmbAICustomer.Text, true);
            //presenter.loadProductName(cmbAICustomer.Text,true);
        }
        private void cmbAISearchProduct_TextChanged(object sender, EventArgs e)
        {
            presenter.loadProductName(cmbAICustomer.Text, true);
        }
        public void showProductName(List<string> productNames, bool doShowPopup)
        {
            var cmbItems = cmbAISearchProduct.Properties.Items;
            cmbItems.Clear();
            cmbItems.AddRange(productNames);
            if(doShowPopup)
                cmbAISearchProduct.ShowPopup();
        }

        public void showMessageBox(string msg, MessageBoxIcon type)
        {
            switch (type)
            {
                case MessageBoxIcon.Error:

                    MessageBox.Show(msg, Resources.ERROR_CAPTION, MessageBoxButtons.OK, type);
                    break;
                case MessageBoxIcon.Information:

                    MessageBox.Show(msg, Resources.INFOR_CAPTION, MessageBoxButtons.OK, type);
                    break;
            }
        }

        private void cmbAIPaymentMethod_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void showCustomerName(List<string> customerNames, bool doShowPopup)
        {
            var cmbItems = cmbAICustomer.Properties.Items;
            cmbItems.Clear();
            cmbItems.AddRange(customerNames);
            if (doShowPopup)
                cmbAICustomer.ShowPopup();
        }

        private void cmbAISearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.loadSizeOfProduct(cmbAISearchProduct.Text);
        }

        public void showSizeOfProduct(List<String> sizeList)
        {
            var cmbItems = cmbAISize.Properties.Items;
            cmbItems.Clear();
            cmbItems.AddRange(sizeList);
        }

        private void btnAIAddItem_Click(object sender, EventArgs e)
        {
            presenter.addItem(cmbAISearchProduct.Text, cmbAISize.Text);
        }

        public void resetItemAddingComponents()
        {
            throw new NotImplementedException();
        }

        public void addItemIntoGrid(String[] invoiceItem)
        {
            /*
            int groupColumnCount = gvInvoiceItems.Columns.Count;
            //Get the handle of the new row 

            gvInvoiceItems.AddNewRow();
            int newRowHandle = gvInvoiceItems.FocusedRowHandle;
            object newRow = gvInvoiceItems.GetRow(newRowHandle);
            if (groupColumnCount > 0)
            {
                for (int i = 0; i < groupColumnCount-2; i++)
                {
                    gvInvoiceItems.SetRowCellValue(newRowHandle, gvInvoiceItems.Columns[i], invoiceItem[i]);
                }
            }
            gvInvoiceItems.UpdateCurrentRow();*/
            
            
            
            table.Rows.Add(invoiceItem);
            grdconAIItems.DataSource = table;

        }
    }
}
