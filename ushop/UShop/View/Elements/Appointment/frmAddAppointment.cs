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
using Presenter.Interfaces;
using Model.Properties;
using View.Elements.Customer;

namespace View.Elements.Appointment
{
    public partial class frmAddAppointment : Form,IAppointmentAddingView
    {
        private Form caller;
        private AppoinmentPresenter presenter;
        private string updatedAppCode;

        public frmAddAppointment()
        {
            InitializeComponent();
        }

        public frmAddAppointment(Form caller, AppoinmentPresenter presenter, string appCode)
        {
            InitializeComponent();
            this.caller = caller;
            this.presenter = presenter;
            this.updatedAppCode = appCode;
            presenter.AppAddingView = this;

            refreshAll();

            presenter.loadExistedAppointment(updatedAppCode);

        }

        public frmAddAppointment(frmAppointment caller, AppoinmentPresenter presenter)
        {
            InitializeComponent();
            this.caller = caller;
            this.presenter = presenter;
            presenter.AppAddingView = this;

            refreshAll();
        }

        private void bbtniAAAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cusCode = cmbAACusId.Text.ToString().Split(new char[] { '-' })[0];
            string description = txteAADescription.Text;
            string note = cboxStatus.Text;

            DateTime createdDT = dpkAACreatedDate.Value;
            DateTime appDT = dpkAAAppDate.Value;
            presenter.insertOrUpdateAppointment(cusCode, createdDT, appDT, description, note);
        }

        private void bbtniAAPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbtniAABack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            backPreviousForm();
        }

        private void bbtniAAReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshAll();
        }

        public void showInforComponents(APPOINTMENT app,String cusCodeName,String empName)
        {
            try
            {
                txteAAAppCode.Text = app.APP_CODE;
                txteAADescription.Text = app.DESCRIPTION;
                txteAAEmployee.Text = empName;
                cboxStatus.Text = app.NOTE;

                cmbAACusId.Text = cusCodeName;
                dpkAAAppDate.Value = (DateTime)app.APP_DATE;
                dpkAACreatedDate.Value = (DateTime)app.CREATED_DATE;
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

        public void refreshAll()
        {
            txteAAAppCode.ResetText();
            txteAADescription.ResetText();
            txteAAEmployee.ResetText();
            //cboxStatus.ResetText();

            cmbAACusId.ResetText();
            dpkAAAppDate.Value = DateTime.Now;
            dpkAACreatedDate.Value = DateTime.Now;


            txteAAAppCode.Text = presenter.getTemperatoryCode();
            txteAAEmployee.Text = presenter.getCurrentEmployeeName();


            presenter.loadCustomerNames(null);

        }

        public void backPreviousForm()
        {

            this.Close();
            caller.Activate();
        }

        public void showCustomerName(List<String> cusCodeNameList)
        {
           
            var cmbItems = cmbAACusId.Properties.Items;
            cmbItems.Clear();
            cmbItems.AddRange(cusCodeNameList);
            //if (doShowPopup)
            //    cmbAICustomer.ShowPopup();
        
        }

        private void btnAENewCustomer_Click(object sender, EventArgs e)
        {
            Form addCusForm = new frmAddCustomer(this, new CustomerPresenter());
            addCusForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addCusForm.MdiParent = this.MdiParent;
            addCusForm.Dock = DockStyle.Fill;
            addCusForm.Show();
        }

        private void frmAddAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                cboxStatus.Properties.Items.Clear();
            }
            catch
            { }

            List<string> lst = new List<string>();
            lst.Add("Đã hoàn tất");
            lst.Add("Đang hoàn tất");

            cboxStatus.Properties.Items.AddRange(lst);
        }

        private void dpkAACreatedDate_ValueChanged(object sender, EventArgs e)
        {
            dpkAAAppDate.MinDate = dpkAACreatedDate.Value;
        }

        private void dpkAAAppDate_ValueChanged(object sender, EventArgs e)
        {
            dpkAACreatedDate.MaxDate = dpkAAAppDate.Value;
        }
    }
}
