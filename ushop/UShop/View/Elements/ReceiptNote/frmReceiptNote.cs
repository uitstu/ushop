using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Model;
using Presenter.Interface;
using Presenter.InterfaceImplement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
//using app = Microsoft.Office.Interop.Excel.Application;

namespace View.Elements.ReceiptNote
{
    public partial class frmReceiptNote : Form, IReceiptNoteView
    {
        private ReceiptNotePresenter preReceiptNote;
        private System.Data.DataTable dt;

        public frmReceiptNote()
        {
            InitializeComponent();
            preReceiptNote = new ReceiptNotePresenter(this);
            GridView gridView = gridReceiptNote.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;// .Settings.AutoFilterCondition = AutoFilterCondition.Contains;
            }
        }

        public void loadReceiptNotesDB(System.Data.DataTable dt)
        {
            this.dt = dt;
            gridReceiptNote.DataSource = dt;
        }
        /*
        public void loadReceiptNotes(List<Model.RECEIPT_NOTE> listObj)
        {
            gridReceiptNote.DataSource = listObj;
            
        }
        */
        private void frmReceiptNote_Load(object sender, EventArgs e)
        {
            preReceiptNote.loadReceiptNotesDB();
            /*
            GridView gridView = gridReceiptNote.FocusedView as GridView;
            gridView.Columns["ACCOUNTING_DATE"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView.Columns["ACCOUNTING_DATE"].DisplayFormat.FormatString = "dd/MM/yyyy";
             * */
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmAddReceiptNote frmAdd = new frmAddReceiptNote(preReceiptNote);
            //frmAdd.ShowDialog();
            frmAddReceiptNote frmAdd = new frmAddReceiptNote(preReceiptNote, this);
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void btnEditReceiptNote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridReceiptNote.FocusedView as GridView;
            GridColumn colCode = gridView.Columns["RN_CODE"];
            String code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colCode).ToString();

            //MessageBox.Show(preReceiptNote.getReceiptNoteByCODE(code).RN_ID+"");

            //frmAddReceiptNote frmAdd = new frmAddReceiptNote(preReceiptNote, preReceiptNote.getReceiptNoteByCODE(code));
            //frmAdd.ShowDialog();
            frmAddReceiptNote frmAdd = new frmAddReceiptNote(preReceiptNote, preReceiptNote.getReceiptNoteByCODE(code), this);
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void btnDeleteReceiptNote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            GridView gridView = gridReceiptNote.FocusedView as GridView;
            GridColumn colCode = gridView.Columns["RN_CODE"];
            String code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colCode).ToString();

            System.Data.DataTable dtItems = new System.Data.DataTable();
            dtItems.Columns.Add("CODE");
            dtItems.Columns.Add("NAME");
            dtItems.Columns.Add("STOCK_S");
            dtItems.Columns.Add("VOUCHER_S");
            dtItems.Columns.Add("STOCK_M");
            dtItems.Columns.Add("VOUCHER_M");
            dtItems.Columns.Add("STOCK_L");
            dtItems.Columns.Add("VOUCHER_L");
            dtItems.Columns.Add("STOCK_XL");
            dtItems.Columns.Add("VOUCHER_XL");
            dtItems.Columns.Add("STOCK_XXL");
            dtItems.Columns.Add("VOUCHER_XXL");
            dtItems.Columns.Add("STOCK_TOTAL");
            dtItems.Columns.Add("VOUCHER_TOTAL");
            dtItems.Columns.Add("PRICE");
            dtItems.Columns.Add("AMOUNT");

            string strError = "";
            strError = preReceiptNote.update(preReceiptNote.getReceiptNoteByCODE(code), dtItems);
            if (!strError.Equals(""))
            {
                MessageBox.Show(strError);
            }
            preReceiptNote.loadReceiptNotesDB();
        }

        private void btnXuatDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = gridReceiptNote.FocusedView as GridView;

                gridView.Columns[8].Visible = false;
                gridView.Columns[9].Visible = false;

                gridReceiptNote.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[8].Visible = true;
                gridView.Columns[9].Visible = true;

            } 
        }

        private void frmReceiptNote_Activated(object sender, EventArgs e)
        {
            preReceiptNote.loadReceiptNotesDB();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = gridReceiptNote.FocusedView as GridView;

                gridView.Columns[8].Visible = false;
                gridView.Columns[9].Visible = false;

                gridReceiptNote.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[8].Visible = true;
                gridView.Columns[9].Visible = true;
            }
        }

    }
}
