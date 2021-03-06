﻿using DevExpress.XtraEditors.Controls;
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

namespace View.Elements.Customer
{
    public partial class frmCustomer : Form,ICustomerView
    {

        CustomerPresenter presenter;
        DataTable table;

        public frmCustomer()
        {
            InitializeComponent();
            presenter = new CustomerPresenter();
            presenter.CusView = this;
            presenter.loadCustomerList();

            GridView gridView = grdconCLCustomer.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }

            gridView.GroupPanelText = "Thả một tiêu đề ở đây để nhóm thông tin";
            //gridView.Columns["CUS_CODE"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
        }

        public DataTable getCustomerTable()
        {
            table = grdconCLCustomer.DataSource as DataTable;
            return table;
        }

        public void showCustomerList(DataTable table)
        {
            this.table = table;
            grdconCLCustomer.DataSource = table;
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
        

        private void btnCLUpdateCustomer_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GridView gridView = grdconCLCustomer.FocusedView as GridView;
            GridColumn colCode = gvCLCustomer.Columns["CUS_CODE"];
            String code = gvCLCustomer.GetRowCellValue(gridView.FocusedRowHandle, colCode).ToString();


            Form addCusForm = new frmAddCustomer(this, presenter, code);
            addCusForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addCusForm.MdiParent = this.MdiParent;
            addCusForm.Dock = DockStyle.Fill;
            addCusForm.Show();
        }

        private void btnCLDeleteCustomer_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            GridView gridView = grdconCLCustomer.FocusedView as GridView;
            GridColumn colCode = gvCLCustomer.Columns["CUS_CODE"];
            String code = gvCLCustomer.GetRowCellValue(gridView.FocusedRowHandle, colCode).ToString();
           // int index = gvCLCustomer.FocusedRowHandle;
            presenter.removeCustomer(code);
        }
        

        private void bbtniCLAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form addCusForm = new frmAddCustomer(this, presenter);
            addCusForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addCusForm.MdiParent = this.MdiParent;
            addCusForm.Dock = DockStyle.Fill;
            addCusForm.Show();
        }

        private void frmCustomer_Activated(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadCustomerList();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconCLCustomer.FocusedView as GridView;

                gridView.Columns[5].Visible = false;
                gridView.Columns[6].Visible = false;

                grdconCLCustomer.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[5].Visible = true;
                gridView.Columns[6].Visible = true;
            }
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconCLCustomer.FocusedView as GridView;

                gridView.Columns[5].Visible = false;
                gridView.Columns[6].Visible = false;

                grdconCLCustomer.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[5].Visible = true;
                gridView.Columns[6].Visible = true;
            }
        }
    }
}
