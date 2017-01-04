using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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

            GridView gridView = grdconELEmployee.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }
            gridView.GroupPanelText = "Thả một tiêu đề ở đây để nhóm thông tin";
            //gridView.Columns["EMP_CODE"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
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
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            int index = gvELEmployee.FocusedRowHandle;
            presenter.removeEmployee(index);
        }

        private void frmEmployee_Activated(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadEmployeList();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconELEmployee.FocusedView as GridView;

                gridView.Columns[11].Visible = false;
                gridView.Columns[12].Visible = false;

                grdconELEmployee.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[11].Visible = true;
                gridView.Columns[12].Visible = true;
            }
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconELEmployee.FocusedView as GridView;

                gridView.Columns[11].Visible = false;
                gridView.Columns[12].Visible = false;

                grdconELEmployee.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[11].Visible = true;
                gridView.Columns[12].Visible = true;
            }
        }
    }
}
