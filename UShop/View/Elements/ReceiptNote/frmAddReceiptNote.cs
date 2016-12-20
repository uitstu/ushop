﻿using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Model;
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
    public partial class frmAddReceiptNote : Form
    {
        private ReceiptNotePresenter preReceiptNote;
        private Model.RECEIPT_NOTE obj;
        DataTable dtItems;
        RECEIPT_NOTE receipt_note;

        List<string> lstSub = new List<string>();

        public frmAddReceiptNote()
        {
            InitializeComponent();
        }

        public frmAddReceiptNote(ReceiptNotePresenter preReceiptNote)
        {
            this.preReceiptNote = preReceiptNote;
            InitializeComponent();

            setSource();
        }

        public frmAddReceiptNote(ReceiptNotePresenter preReceiptNote, Model.RECEIPT_NOTE obj)
        {
            this.preReceiptNote = preReceiptNote;
            this.obj = obj;
            InitializeComponent();

            setSource();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strError = "";

            if (cboxSupplier.Text.Equals(""))
            {
                strError += "\nSuppiler is null";
            }
            else
            {
                bool checkExist = false;

                foreach (DataRow d in preReceiptNote.loadSupplierDT().Rows)
                {
                    if (cboxSupplier.Text.Equals(d[0].ToString() + " - " + d[1].ToString()))
                    {
                        checkExist = true;
                        break;
                    }
                }

                if (!checkExist)
                {
                    strError += "\nDidn't see any supplier like " + cboxSupplier.Text;
                }
            }

            if (lbTotal.Text.Equals(""))
            {
                strError += "\nNeed at least one receipt note item";
            }
            else
            {
                if (float.Parse(tboxAccounted.Text).CompareTo(float.Parse(lbTotal.Text))>=0)
                {
                    strError += "\nAccounted is not rather than total";
                }
            }

            if (dpickIssued.Value.CompareTo(dpickAccounting.Value)>0)
            {
                strError += "\nIssued date is not rather than accounting date";
            }

            if (!strError.Equals(""))
            {
                MessageBox.Show(strError);
                return;
            }

            //

            if (receipt_note == null)
            {
                receipt_note = new RECEIPT_NOTE();
            }
            receipt_note.SUPPLIER_ID = Int32.Parse(cboxSupplier.Text.Substring(cboxSupplier.Text.IndexOf('0'), cboxSupplier.Text.IndexOf(' ') - cboxSupplier.Text.IndexOf('0')));

            receipt_note.ACCOUNTED = Int32.Parse(tboxAccounted.Text);
            receipt_note.ISSUED_DATE = DateTime.Parse(dpickIssued.Text);
            receipt_note.ACCOUNTING_DATE = DateTime.Parse(dpickAccounting.Text);
            receipt_note.NOTE = tboxNote.Text;

            receipt_note.PREPARER_ID = 1;
            receipt_note.RECORD_STATUS = "A";
            receipt_note.RN_CODE = "aaaa";
            receipt_note.TOTAL = 0;
            //receipt_note.RN_ID = 1;

            preReceiptNote.add(receipt_note, dtItems);

            preReceiptNote.loadReceiptNotesDB();
            Close();
        }

        public void setSource()
        {
            dpickAccounting.MinDate = dpickIssued.Value;

            //

            List<string> lst = new List<string>();
            DataRow a = preReceiptNote.loadSupplierDT().Rows[0];
            foreach (DataRow d in preReceiptNote.loadSupplierDT().Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxSupplier.Properties.Items.AddRange(lst);
            cboxSupplier.Properties.AutoComplete = false;

            //

            lst = new List<string>();
            a = preReceiptNote.loadProdcutDT().Rows[0];
            foreach (DataRow d in preReceiptNote.loadProdcutDT().Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            removeListSub(lst);
            cboxProduct.Properties.Items.AddRange(lst);
            cboxProduct.Properties.AutoComplete = false;
        }

        private void cboxSupplier_TextChanged_1(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            DataRow a = preReceiptNote.loadSupplierDT().Rows[0];
            foreach (DataRow d in preReceiptNote.loadSupplierDT().Rows)
            {
                if ((d[0].ToString() + " - " + d[1].ToString()).ToLower().Contains(cboxSupplier.Text.ToString().ToLower()))
                    lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxSupplier.Properties.Items.Clear();
            cboxSupplier.Properties.Items.AddRange(lst);

            cboxSupplier.ShowPopup();
        }

        private void cboxProduct_TextChanged(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            DataRow a = preReceiptNote.loadProdcutDT().Rows[0];
            foreach (DataRow d in preReceiptNote.loadProdcutDT().Rows)
            {
                if ((d[0].ToString() + " - " + d[1].ToString()).ToLower().Contains(cboxProduct.Text.ToString().ToLower()))
                    lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }

            removeListSub(lst);

            cboxProduct.Properties.Items.Clear();
            cboxProduct.Properties.Items.AddRange(lst);

            cboxProduct.ShowPopup();
        }

        

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (dtItems == null)
            {
                dtItems = new DataTable();
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
                //dtItems.Columns.Add("DELETE");
            }

            String str = cboxProduct.Text;

            bool checkExist = false;

            foreach (DataRow d in preReceiptNote.loadProdcutDT().Rows)
            {
                if (str.Equals(d[0].ToString() + " - " + d[1].ToString()))
                {
                    checkExist = true;
                    break;
                }
            }

            if (checkExist)
            {
                String strCODE = str.Substring(0, str.IndexOf(' '));
                String strNAME = str.Substring(str.IndexOf(' ') + 3, str.Length - (str.IndexOf(' ') + 3));

                dtItems.Rows.Add(strCODE, strNAME, "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", preReceiptNote.getProductByCODE(strCODE).COST_PRICE, "0");

                gridItems.DataSource = dtItems;

                lstSub.Add(""+str);

                cboxProduct.Text = "";
            }
            else
            {
                MessageBox.Show("Didn't see any thing like "+str+"!");
            }

        }

        public void removeListSub(List<string> lst)
        {
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < lstSub.Count; j++)
                {
                    if (lst.ElementAt(i).Equals(lstSub.ElementAt(j)))
                    {
                        lst.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            int num = 0;
            if (!Int32.TryParse(e.Value as String, out num))
            {
                e.Valid = false;
                e.ErrorText = "Hey guy, just type integer style... :D";
            }
            else
                if (num < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Must rather than -1 guy... :D";
                }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            for (int i = 2; i < 11; i += 2)
            {
                GridColumn colStock = gridView1.Columns[i];
                GridColumn colVoucher = gridView1.Columns[i+1];

                int stockS = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colStock));
                int voucherS = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colVoucher));

                if (stockS > voucherS)
                {
                    //gridView1.SetColumnError(colStock_S, "The Voucher_S value should be less than this value.");
                    //gridView1.SetColumnError(colVoucher_S, "This value should be less than the Units In Stock value.");
                    //gridView1.SetColumnError(null, "Invalid data");
                    e.Valid = false;
                    e.ErrorText = "'Stock' value should be less than 'Voucher' value guy... :D";
                }
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
            
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            //remember: tru bot so luong
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName.Equals("STOCK_TOTAL") || e.Column.FieldName.Equals("VOUCHER_TOTAL")
                || e.Column.FieldName.Equals("AMOUNT"))
                return;

            int stockTotal = 0;
            int voucherTotal = 0;

            for (int i = 2; i < 11; i += 2)
            {
                GridColumn colStock = gridView1.Columns[i];
                GridColumn colVoucher = gridView1.Columns[i + 1];

                stockTotal += Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colStock));
                voucherTotal += Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colVoucher));
            }

            GridColumn colStockTotal = gridView1.Columns["STOCK_TOTAL"];
            GridColumn colVoucherTotal = gridView1.Columns["VOUCHER_TOTAL"];

            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colStockTotal, stockTotal);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colVoucherTotal, voucherTotal);

            GridColumn colAmount = gridView1.Columns["AMOUNT"];
            GridColumn colPrice = gridView1.Columns["PRICE"];

            float price = float.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPrice).ToString());
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colAmount, voucherTotal * price);

            float totalAmount = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                totalAmount += float.Parse(gridView1.GetRowCellValue(i, colAmount).ToString());
            }

            lbTotal.Text = Convert.ToString(totalAmount);
        }

        private void tboxAccounted_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dpickIssued_ValueChanged(object sender, EventArgs e)
        {
            dpickAccounting.MinDate = dpickIssued.Value;
        }

        private void dpickAccounting_ValueChanged(object sender, EventArgs e)
        {
            dpickIssued.MaxDate = dpickAccounting.Value;
        }

        private void btnDeleteItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            String str = "";
            GridView gridView = gridItems.FocusedView as GridView;

            GridColumn colCode = gridView1.Columns["CODE"];
            GridColumn colName = gridView1.Columns["NAME"];

            str = gridView.GetRowCellValue(gridView.FocusedRowHandle, colCode).ToString();
            str += " - " + gridView.GetRowCellValue(gridView.FocusedRowHandle, colName).ToString();

            GridColumn colAmount = gridView1.Columns["AMOUNT"];

            float newTotal = 0;
            newTotal = float.Parse(lbTotal.Text) - float.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, colAmount).ToString());
            lbTotal.Text = Convert.ToString(newTotal);

            dtItems.Rows.RemoveAt(gridView.FocusedRowHandle);

            for (int i = lstSub.Count - 1; i >= 0; i--)
            {
                if (lstSub.ElementAt(i).Equals(str))
                {
                    lstSub.RemoveAt(i);

                    List<string>  lst = new List<string>();
                    DataRow a = preReceiptNote.loadProdcutDT().Rows[0];
                    foreach (DataRow d in preReceiptNote.loadProdcutDT().Rows)
                    {
                        lst.Add(d[0].ToString() + " - " + d[1].ToString());
                    }
                    removeListSub(lst);
                    cboxProduct.Properties.Items.Clear();
                    cboxProduct.Properties.Items.AddRange(lst);
                    break;
                }
            }


            /*
             * GridView gridView = gridCategory.FocusedView as GridView;
            //object row = gridView.GetRow(gridView.FocusedRowHandle);

            preCategory.deleteCategory(gridView.GetFocusedRowCellValue("CATEGORY_ID").ToString());
             * */
        }
    }

    //data input: https://documentation.devexpress.com/#WindowsForms/CustomDocument114741
    //https://www.youtube.com/watch?v=povVd1iJkHc&list=PL8h4jt35t1wj1k3OpyPddjK2VzBH50rSj

}