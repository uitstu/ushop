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

namespace View.Elements.ReceiptNote
{
    public partial class frmReceiptNote : Form, IReceiptNoteView
    {
        private ReceiptNotePresenter preReceiptNote;

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

        public void loadReceiptNotesDB(DataTable dt)
        {
            gridReceiptNote.DataSource = dt;
        }

        public void loadReceiptNotes(List<Model.RECEIPT_NOTE> listObj)
        {
            gridReceiptNote.DataSource = listObj;
            
        }

        private void frmReceiptNote_Load(object sender, EventArgs e)
        {
            preReceiptNote.loadReceiptNotesDB();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddReceiptNote frmAdd = new frmAddReceiptNote(preReceiptNote);
            frmAdd.ShowDialog();
        }

        private void btnEditReceiptNote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridReceiptNote.FocusedView as GridView;
            GridColumn colCode = gridView.Columns["RN_CODE"];
            String code = gridView.GetRowCellValue(gridView.FocusedRowHandle, colCode).ToString();

            //MessageBox.Show(preReceiptNote.getReceiptNoteByCODE(code).RN_ID+"");

            frmAddReceiptNote frmAdd = new frmAddReceiptNote(preReceiptNote, preReceiptNote.getReceiptNoteByCODE(code));
            frmAdd.ShowDialog();
        }

        private void btnDeleteReceiptNote_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete it?", "Deleting", MessageBoxButtons.YesNo);
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

            DataTable dtItems = new DataTable();
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
    }
}
