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

        
    }
}
