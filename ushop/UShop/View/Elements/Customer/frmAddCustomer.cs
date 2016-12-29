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
using Model;
using Presenter.Elements;
using Model.Properties;

namespace View.Elements.Customer
{
    public partial class frmAddCustomer : Form,ICustomerAddingView
    {
        private Form caller;
        private CustomerPresenter presenter;
        String updatedCusCode;

        public frmAddCustomer(Form caller, CustomerPresenter presenter)
        {
            InitializeComponent();

            this.caller = caller;
            this.presenter = presenter;
            presenter.CusAddingView = this;

            refreshAll();
        }
        public frmAddCustomer(Form caller, CustomerPresenter presenter, String cusCode)
        {
            InitializeComponent();

            this.caller = caller;
            this.presenter = presenter;
            presenter.CusAddingView = this;

            refreshAll();

            //should load employee infor into components
            updatedCusCode = cusCode;
            presenter.loadExistedCustomer(updatedCusCode);
        }

        public void backPreviousForm()
        {
            foreach (var form in MdiParent.MdiChildren)
            {

                if (caller.Equals(form))
                {
                    caller.Activate();

                }
            }
            this.Close();
        }

        public void refreshAll()
        {
            txteACBoughtAmount.ResetText();
            txteACPhone.ResetText();
            txteACCusName.ResetText();
            txteACCusCode.ResetText();
            txteACAddress.ResetText();


            txteACCusCode.Text = presenter.getTemperatoryCode();
        }

        public void showInforComponents(CUSTOMER cus)
        {
            try
            {
                txteACAddress.Text = cus.ADDRESS;
                txteACCusCode.Text = cus.CUS_CODE;
                txteACCusName.Text = cus.CUS_NAME;
                txteACPhone.Text = cus.PHONE;
                txteACBoughtAmount.Text = cus.BOUGHT_AMOUNT+"";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
        
      

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void bbtniACBack_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            backPreviousForm();
        }

        private void bbtniACAdd_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String name = txteACCusName.Text;
            String address = txteACAddress.Text;
            String phone = txteACPhone.Text;
            //String boughtAmount = txteACBoughtAmount.Text;
            presenter.insertOrUpdateCustomer(name, address, phone);
        }

        private void bbtniACReset_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshAll();
        }
    }
}
