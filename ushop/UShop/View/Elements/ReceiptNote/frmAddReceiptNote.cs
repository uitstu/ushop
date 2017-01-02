using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Model;
using Presenter.InterfaceImplement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Elements.Category;
using View.Elements.Product;
using View.Elements.Supplier;
using Microsoft.Reporting.WinForms;

namespace View.Elements.ReceiptNote
{
    public partial class frmAddReceiptNote : Form
    {
        Form beforeForm;
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

        public frmAddReceiptNote(ReceiptNotePresenter preReceiptNote, Form beforeForm)
        {
            this.preReceiptNote = preReceiptNote;
            this.beforeForm = beforeForm;
            InitializeComponent();

            setSource();
        }

        public frmAddReceiptNote(ReceiptNotePresenter preReceiptNote, Model.RECEIPT_NOTE obj, Form beforeForm)
            : this(preReceiptNote, obj)
        {
            this.beforeForm = beforeForm;
        }

        public frmAddReceiptNote(ReceiptNotePresenter preReceiptNote, Model.RECEIPT_NOTE obj)
        {
            this.preReceiptNote = preReceiptNote;
            this.obj = obj;
            this.dtItems = preReceiptNote.loadRN_ITEM(obj.RN_ID);

            InitializeComponent();

            //update giao dien
            gridItems.DataSource = dtItems;

            cboxSupplier.Text = Convert.ToString(obj.SUPPLIER_ID);

            dpickIssued.Value = obj.ISSUED_DATE ?? new DateTime();
            dpickAccounting.Value = obj.ACCOUNTING_DATE ?? new DateTime();
            tboxNote.Text = obj.NOTE;
            tboxAccounted.Text = Convert.ToString(obj.ACCOUNTED);
            lbTotal.Text = Convert.ToString(obj.TOTAL);
            setSource(); 
            //cboxSupplier.Text = Convert.ToString(obj.SUPPLIER_ID);
            foreach (DataRow d in preReceiptNote.loadSupplierDT(true).Rows)
            {
                if (Int32.Parse(d[0].ToString().Substring(d[0].ToString().IndexOf('0'), d[0].ToString().Length - d[0].ToString().IndexOf('0'))) == obj.SUPPLIER_ID)
                {
                    cboxSupplier.Text = d[0].ToString() + " - " + d[1].ToString();
                    break;
                }
            }

            //cap nhat lstSub
            
            foreach (DataRow d in dtItems.Rows)
            {
                lstSub.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            
            
            List<string> lst = new List<string>();
            foreach (DataRow d in preReceiptNote.loadProdcutDT().Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            removeListSub(lst);
            cboxProduct.Properties.Items.Clear();
            cboxProduct.Properties.Items.AddRange(lst);
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strError = "";

            if (cboxSupplier.Text.Equals(""))
            {
                strError += "\nNhà cung cấp trống";
            }
            else
            {
                bool checkExist = false;

                foreach (DataRow d in preReceiptNote.loadSupplierDT(true).Rows)
                {
                    if (cboxSupplier.Text.Equals(d[0].ToString() + " - " + d[1].ToString()))
                    {
                        checkExist = true;
                        break;
                    }
                }

                if (!checkExist)
                {
                    strError += "\nKhông tìm thấy " + cboxSupplier.Text;
                }
            }

            bool checkItem = true;
            if (gridItems.DataSource == null || ((DataTable)gridItems.DataSource).Rows.Count == 0)
            {
                checkItem = false;
            }
            else
            {
                foreach (DataRow r in ((DataTable)gridItems.DataSource).Rows)
                {
                    if (Int32.Parse(r[3].ToString()) == 0)
                        checkItem = false;
                }
            }
            

            if (!checkItem)
            {
                strError += "\nHàng hóa phải có số lượng";
            }
            else
            {
                if (float.Parse(tboxAccounted.Text).CompareTo(float.Parse(lbTotal.Text))>0)
                {
                    strError += "\nTiền thanh toán không được lớn hơn tổng tiền";
                }
            }

            if (!strError.Equals(""))
            {
                MessageBox.Show(strError);
                return;
            }

            //

            if (obj != null)
            {
                //chua get data obj
                obj.SUPPLIER_ID = Int32.Parse(cboxSupplier.Text.Substring(cboxSupplier.Text.IndexOf('0'), cboxSupplier.Text.IndexOf(' ') - cboxSupplier.Text.IndexOf('0') + 1));
                obj.ACCOUNTED = Int32.Parse(tboxAccounted.Text);
                obj.TOTAL = Int32.Parse(lbTotal.Text);
                obj.ISSUED_DATE = dpickIssued.Value;
                obj.ACCOUNTING_DATE = dpickAccounting.Value;
                obj.NOTE = tboxNote.Text;

                obj.STATUS = "Chưa thanh toán";
                if (lbTotal.Text.Equals(tboxAccounted.Text))
                {
                    obj.STATUS = "Đã thanh toán";
                }

                String strEr = preReceiptNote.update(obj, dtItems);
                if (strEr.Equals(""))
                {
                    preReceiptNote.loadReceiptNotesDB();
                    Close();
                    beforeForm.WindowState = FormWindowState.Maximized;
                    beforeForm.Activate();
                }
                else
                {
                    MessageBox.Show(strEr);
                }
                
                return;
            }

            //

            if (receipt_note == null)
            {
                receipt_note = new RECEIPT_NOTE();
            }
            receipt_note.SUPPLIER_ID = Int32.Parse(cboxSupplier.Text.Substring(cboxSupplier.Text.IndexOf('0'), cboxSupplier.Text.IndexOf(' ') - cboxSupplier.Text.IndexOf('0')));

            receipt_note.ACCOUNTED = Int32.Parse(tboxAccounted.Text);
            receipt_note.ISSUED_DATE = dpickIssued.Value;
            receipt_note.ACCOUNTING_DATE = dpickAccounting.Value;
            receipt_note.NOTE = tboxNote.Text;

            receipt_note.STATUS = "Chưa thanh toán";
            if (lbTotal.Text.Equals(tboxAccounted.Text))
            {
                receipt_note.STATUS = "Đã thanh toán";
            }

            if (AccountPresenter.currentEmployee == null)
            {
                receipt_note.PREPARER_ID = 1;
            }
            else
            {
                receipt_note.PREPARER_ID = AccountPresenter.currentEmployee.EMP_ID;
            }

            receipt_note.RECORD_STATUS = "A";
            receipt_note.TOTAL = float.Parse(lbTotal.Text);

            preReceiptNote.add(receipt_note, dtItems);

            preReceiptNote.loadReceiptNotesDB();

            beforeForm.WindowState = FormWindowState.Maximized;
            beforeForm.Activate();
            //Close();
        }

        public void setSource()
        {
            try
            {
                cboxSupplier.Properties.Items.Clear();
                cboxProduct.Properties.Items.Clear();
            }
            catch
            { }

            dpickAccounting.MinDate = dpickIssued.Value;

            //
            List<string> lst = new List<string>();
            foreach (DataRow d in preReceiptNote.loadSupplierDT(false).Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxSupplier.Properties.Items.AddRange(lst);
            cboxSupplier.Properties.AutoComplete = false;
            //

            lst = new List<string>();
            foreach (DataRow d in preReceiptNote.loadProdcutDT().Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            removeListSub(lst);
            cboxProduct.Properties.Items.AddRange(lst);
            cboxProduct.Properties.AutoComplete = false;

            cboxSize.Properties.Items.Clear();
            cboxSize.Properties.Items.Add("M");
            cboxSize.Properties.Items.Add("L");
            cboxSize.Properties.Items.Add("XL");
        }

        private void cboxSupplier_TextChanged_1(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            foreach (DataRow d in preReceiptNote.loadSupplierDT(false).Rows)
            {
                if ((d[0].ToString() + " - " + d[1].ToString()).ToLower().Contains(cboxSupplier.Text.ToString().ToLower()))
                    lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxSupplier.Properties.Items.Clear();
            cboxSupplier.Properties.Items.AddRange(lst);

            try
            {
                cboxSupplier.ShowPopup();
            }
            catch (Exception ex)
            { 
            }
                
        }

        private void cboxProduct_TextChanged(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
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
                dtItems.Columns.Add("PRODUCT_CODE");
                dtItems.Columns.Add("PRODUCT_NAME");
                dtItems.Columns.Add("STOCK_S");
                dtItems.Columns.Add("VOUCHER_S");
                dtItems.Columns.Add("SIZE");
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

            if (!checkExist)
            {
                MessageBox.Show("Không có sản phẩm " + str + "!");
            }

            if (cboxSize.Text.Equals(""))
            {
                checkExist = false;
                MessageBox.Show("Chưa nhập size!");
            }

            foreach (DataRow d in dtItems.Rows)
            {
                if (d[0].ToString().Equals(str.Substring(0, str.IndexOf(' '))) && d[4].ToString().ToUpper().Equals(cboxSize.Text.ToUpper()))
                {
                    checkExist = false;
                    MessageBox.Show("Đã có trong danh sách!");
                    break;
                }
            }

            if (checkExist)
            {
                String strCODE = str.Substring(0, str.IndexOf(' '));
                String strNAME = str.Substring(str.IndexOf(' ') + 3, str.Length - (str.IndexOf(' ') + 3));

                dtItems.Rows.Add(strCODE, strNAME, "0", "0", cboxSize.Text.ToUpper(), preReceiptNote.getProductByCODE(strCODE).COST_PRICE, "0");

                gridItems.DataSource = dtItems;

                lstSub.Add("" + str);

                cboxProduct.Text = "";
                cboxSize.Text = "";
            }
        }
        
        public void removeListSub(List<string> lst)
        {
            /*
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
             * */
        }
        
        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {    
            int num = 0;
            if (!Int32.TryParse(e.Value as String, out num))
            {
                e.Valid = false;
                e.ErrorText = "Phải nhập số";
            }
            else
                if (num < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Phải lớn hơn 0";
                }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridColumn colStock = gridView1.Columns[2];
            GridColumn colVoucher = gridView1.Columns[3];

            int stockS = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, colStock));
            int voucherS = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, colVoucher));

            if (stockS > voucherS)
            {
                //gridView1.SetColumnError(colStock_S, "The Voucher_S value should be less than this value.");
                //gridView1.SetColumnError(colVoucher_S, "This value should be less than the Units In Stock value.");
                //gridView1.SetColumnError(null, "Invalid data");
                //gridView1.SetColumnError(colStock, "aahi");
                e.Valid = false;
                e.ErrorText = "Thực nhập không được lớn hơn yêu cầu";
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
            if (e.Column.FieldName.Equals("AMOUNT"))
            {
                return;
            }

            GridColumn colStock = gridView1.Columns[2];
            GridColumn colVoucher = gridView1.Columns[3];

            int voucher = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, colVoucher));

            GridColumn colAmount = gridView1.Columns["AMOUNT"];
            GridColumn colPrice = gridView1.Columns["PRICE"];

            float price = float.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPrice).ToString());
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, colAmount, (voucher * price).ToString(/*"0.##"*/));

            float totalAmount = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                totalAmount += float.Parse(gridView1.GetRowCellValue(i, colAmount).ToString());
            }
            lbTotal.Text = totalAmount.ToString("0.##");
            //lbTotal.Text = Convert.ToString(totalAmount);
        }


        //rang buoc: chi duoc nhap so
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
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            String str = "";
            GridView gridView = gridItems.FocusedView as GridView;

            GridColumn colCode = gridView1.Columns["PRODUCT_CODE"];
            GridColumn colName = gridView1.Columns["PRODUCT_NAME"];

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

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            //frmAddSupplier frmAdd = new frmAddSupplier(new SupplierPresenter());
            //frmAdd.ShowDialog();
            Form frmAdd = new frmAddSupplier(new SupplierPresenter(), this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            //frmAddProduct frmAdd = new frmAddProduct(new ProductPresenter());
            //frmAdd.ShowDialog();
            Form frmAdd = new frmAddProduct(new ProductPresenter(), this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void frmAddReceiptNote_Activated(object sender, EventArgs e)
        {
            setSource();
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            beforeForm.WindowState = FormWindowState.Maximized;
            beforeForm.Activate();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportEmbeddedResource = "View.Elements.ReceiptNote.ReportReceiptNote.rdlc";
            localReport.DataSources.Clear();

            DataTable dt = dtItems;

            dt.TableName = "DataSetReceiptNote";
            Microsoft.Reporting.WinForms.ReportDataSource newDataSource =
                new Microsoft.Reporting.WinForms.ReportDataSource(dt.TableName, dt);
            localReport.DataSources.Add(newDataSource);
            
            List<ReportParameter> lstt = new List<ReportParameter>();

            String str1, str2, str3, str4, str5;
            str1 = "Người lập: " + AccountPresenter.currentEmployee.EMP_NAME + ", Ngày lập: " + dpickIssued.Text + ", Ngày hạch toán: " + dpickAccounting.Text;

            string supplierCODE = cboxSupplier.Text.Substring(0, cboxSupplier.Text.IndexOf(' '));

            SUPPLIER s1 = (new UShopPresenter()).getUShop();
            SUPPLIER s2 = preReceiptNote.getSupplierByCODE(supplierCODE);
            str2 = "Bên gửi: " + s1.SUPPLIER_NAME+", Địa chỉ: "+s1.ADDRESS+", SĐT: "+s1.PHONE + ", MST: "+s1.TAX_CODE;
            str3 = "Bên nhận: " + s2.SUPPLIER_NAME + ", Địa chỉ: " + s2.ADDRESS + ", SĐT: " + s2.PHONE + ", MST: " + s2.TAX_CODE;

            str4 = "Đã thanh toán/Tổng thành tiền: " + tboxAccounted.Text + "/" + lbTotal.Text;
            str5 = "Nội dung: "+tboxNote.Text;

            ReportParameter param1 = new ReportParameter("ReportParameterNgay", str1);
            lstt.Add(param1);
            ReportParameter param2 = new ReportParameter("ReportParameterBenGui", str2);
            lstt.Add(param2);
            ReportParameter param3 = new ReportParameter("ReportParameterBenNhan", str3);
            lstt.Add(param3);
            ReportParameter param4 = new ReportParameter("ReportParameterDaThanhToan", str4);
            lstt.Add(param4);
            ReportParameter param5 = new ReportParameter("ReportParameterNoiDung", str5);
            lstt.Add(param5);

            localReport.SetParameters(lstt);
            
            Run(localReport);
        }

        #region
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        // Routine to provide to the report renderer, in order to
        //    save an image for each page of the report.
        private Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        // Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>0.25in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }
        // Create a local report for Report.rdlc, load the data,
        //    export the report to an .emf file, and print it.
        private void Run(LocalReport report)
        {
            //LocalReport report = new LocalReport();
            //report.ReportPath = @"..\..\Report.rdlc";
            //report.DataSources.Add(
            //   new ReportDataSource("Sales", LoadSalesData()));
            Export(report);
            Print();
        }

        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
        #endregion

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cboxSupplier.Text = "";
            tboxAccounted.Text = "";
            tboxNote.Text = "";
        }
    }

    //data input: https://documentation.devexpress.com/#WindowsForms/CustomDocument114741
    //https://www.youtube.com/watch?v=povVd1iJkHc&list=PL8h4jt35t1wj1k3OpyPddjK2VzBH50rSj
    //printer: https://www.codeproject.com/Questions/86383/Print-rdlc-report-without-preview
    //http://caulacbovb.com/forum/viewtopic.php?t=15790

}
