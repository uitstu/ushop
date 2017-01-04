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

            GridView gridView = grdconALAppointment.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }

            gridView.GroupPanelText = "Thả một tiêu đề ở đây để nhóm thông tin";
            //gridView.Columns["APP_CODE"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
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

            GridView gridView = grdconALAppointment.FocusedView as GridView;
            GridColumn colCode = gvALAppointment.Columns["APP_CODE"];
            String code = gvALAppointment.GetRowCellValue(gridView.FocusedRowHandle, colCode).ToString();


            Form addAppForm = new frmAddAppointment(this, presenter, code);
            addAppForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addAppForm.MdiParent = this.MdiParent;
            addAppForm.Dock = DockStyle.Fill;
            addAppForm.Show();
        }

        private void btnALDeleteAppointment_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            GridView gridView = grdconALAppointment.FocusedView as GridView;
            GridColumn colCode = gvALAppointment.Columns["APP_CODE"];
            string code = gvALAppointment.GetRowCellValue(gridView.FocusedRowHandle, colCode).ToString();

            int index = gvALAppointment.FocusedRowHandle;
            presenter.removeAppointment(code);
        }


        private void bbtniALAddAppointment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
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

        private void btnPrintExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconALAppointment.FocusedView as GridView;

                gridView.Columns[7].Visible = false;
                gridView.Columns[8].Visible = false;

                grdconALAppointment.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[7].Visible = true;
                gridView.Columns[8].Visible = true;
            }
        }
    

        private void btnPrintPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconALAppointment.FocusedView as GridView;

                gridView.Columns[7].Visible = false;
                gridView.Columns[8].Visible = false;

                grdconALAppointment.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[7].Visible = true;
                gridView.Columns[8].Visible = true;
            }
        }
    }
}
