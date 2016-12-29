using DevExpress.XtraEditors.Controls;
using Model;
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

namespace View.Elements.Appointment
{
    public partial class frmAppointment : Form,IAppointmentView
    {
        AppoinmentPresenter presenter;
        DataTable table;

        public frmAppointment()
        {
            InitializeComponent();
            presenter = new AppoinmentPresenter();
            presenter.AppView = this;
            presenter.loadAppointmentList();
        }
        

        public void showAppointmentList(DataTable table)
        {
            this.table = table;
            grdconALAppointment.DataSource = table;
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


        private void btnALUpdateAppointment_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.ADDING_APPOINTMENT))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form addAppForm = new frmAddAppointment(this, presenter, table.Rows[gvALAppointment.FocusedRowHandle]["APP_CODE"] + "");
            addAppForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addAppForm.MdiParent = this.MdiParent;
            addAppForm.Dock = DockStyle.Fill;
            addAppForm.Show();
        }

        private void btnALDeleteAppointment_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int index = gvALAppointment.FocusedRowHandle;
            presenter.removeAppointment(index);
        }


        private void bbtniALAddAppointment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!AccountPresenter.checkPermission(FORM_TYPE.ADDING_APPOINTMENT))
            {
                MessageBox.Show("Không được cấp quyền sử dụng chức năng này!");
                return;
            }
            Form addAppForm = new frmAddAppointment(this, presenter);
            addAppForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addAppForm.MdiParent = this.MdiParent;
            addAppForm.Dock = DockStyle.Fill;
            addAppForm.Show();
        }

       

        public DataTable getApppointmentTable()
        {
            table = grdconALAppointment.DataSource as DataTable;
            return table;
        }

        private void bbtniALAddAppointment_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form addAppForm = new frmAddAppointment(this, presenter);
            addAppForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addAppForm.MdiParent = this.MdiParent;
            addAppForm.Dock = DockStyle.Fill;
            addAppForm.Show();
        }

        private void frmAppointment_Activated_1(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadAppointmentList();
        }
    }
}
