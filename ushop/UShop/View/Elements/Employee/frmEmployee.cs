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

namespace View.Elements.Employee
{
    public partial class frmEmployee : Form, IEmployeeView
    {
        EmployeePresenter presenter;
        DataTable table;

        public frmEmployee()
        {
            InitializeComponent();
            presenter = new EmployeePresenter();
            presenter.EmpView = this;
            presenter.loadEmployeList();
        }

        public DataTable getEmployeeTable()
        {
            table = grdconELEmployee.DataSource as DataTable;
            return table;
        }

        public void showEmployeeList(DataTable table)
        {
            this.table = table;
            grdconELEmployee.DataSource = table;
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

        private void bbtniELAddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            Form addEmpForm = new frmAddEmployee(this,presenter);
            addEmpForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addEmpForm.MdiParent = this.MdiParent;
            addEmpForm.Dock = DockStyle.Fill;
            addEmpForm.Show();
        }

        private void btnELUpdateEmployee_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
           
            Form addEmpForm = new frmAddEmployee(this, presenter,table.Rows[gvELEmployee.FocusedRowHandle]["EMP_CODE"]+"");
            addEmpForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addEmpForm.MdiParent = this.MdiParent;
            addEmpForm.Dock = DockStyle.Fill;
            addEmpForm.Show();
        }

        private void btnELDeleteInvoice_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int index = gvELEmployee.FocusedRowHandle;
            presenter.removeEmployee(index);
        }

        private void frmEmployee_Activated(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadEmployeList();
        }
    }
}
