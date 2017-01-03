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
using Model.InterfaceImplements;
using Model.Properties;
using DevExpress.XtraEditors.Controls;
using Presenter.InterfaceImplement;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace View.Elements.Invoice
{
    public partial class frmInvoice : Form, IInvoiceView
    {
        DataTable table;
        InvoicePresenter presenter;
        public frmInvoice()
        {
            presenter = new InvoicePresenter(new InvoiceModel());
            presenter.InvoiceView = this;
            InitializeComponent();
            presenter.loadInvoiceList();

            GridView gridView = grdconILInvoice.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }
            gridView.GroupPanelText = "Thả một tiêu đề ở đây để nhóm thông tin";
        }

        public void showInvoiceList(DataTable invoiceTable)
        {
            table = invoiceTable;
            grdconILInvoice.DataSource = table;
        }

        public void showInvoiceList(List<INVOICE> invoiceList)
        {
            

            grdconILInvoice.DataSource = invoiceList;
        }

        public void showMessageBox(string msg, MessageBoxIcon type)
        {
            switch(type)
            {
                case MessageBoxIcon.Error:

                    MessageBox.Show(msg, Resources.ERROR_CAPTION, MessageBoxButtons.OK, type);
                    break;
                case MessageBoxIcon.Information:

                    MessageBox.Show(msg, Resources.INFOR_CAPTION, MessageBoxButtons.OK, type);
                    break;
            }
        }

        private void bbtniILAddInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Form addInvoiceForm = new frmAddInvoice(this,presenter);
            addInvoiceForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addInvoiceForm.MdiParent = this.MdiParent;
            addInvoiceForm.Dock = DockStyle.Fill;
            addInvoiceForm.Show();
        }

        private void btnILUpdateInvoice_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            
            int row = gvILInvoice.FocusedRowHandle;
            String invoiceCode =  table.Rows[row]["INVOICE_CODE"] + "";
            Form addInvoiceForm = new frmAddInvoice(this, presenter, invoiceCode);
            addInvoiceForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addInvoiceForm.MdiParent = this.MdiParent;
            addInvoiceForm.Dock = DockStyle.Fill;
            addInvoiceForm.Show();
            // presenter.loadExistedInvoice(invoiceId);
        }
        private void btnILDeleteInvoice_ButtonClick(object sender,ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            int indexOfGrid = gvILInvoice.FocusedRowHandle;
            presenter.removeInvoice(indexOfGrid);
        }

        public DataTable getDataTable()
        {
            return table;
        }

        private void frmInvoice_Activated(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadInvoiceList();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconILInvoice.FocusedView as GridView;

                gridView.Columns[7].Visible = false;
                gridView.Columns[8].Visible = false;

                grdconILInvoice.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[7].Visible = true;
                gridView.Columns[8].Visible = true;
            }
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconILInvoice.FocusedView as GridView;

                gridView.Columns[7].Visible = false;
                gridView.Columns[8].Visible = false;

                grdconILInvoice.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[7].Visible = true;
                gridView.Columns[8].Visible = true;
            }
        }
    }
}
