using Microsoft.Reporting.WinForms;
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
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Elements.Customer;
using View.Elements.Employee;
using View.Elements.Product;

namespace View.Elements.Invoice
{
    public partial class frmAddInvoice : Form,IInvoiceAddingView
    {
        DataTable table;
        InvoicePresenter presenter;
        Form caller;
        public frmAddInvoice(Form caller,InvoicePresenter presenter)
        {
            this.caller = caller;
            this.presenter = presenter;
            this.presenter.InvoiceAddingView = this;
            InitializeComponent();
            resetAll();
        }
        public frmAddInvoice(Form caller, InvoicePresenter presenter,String invoiceCode)
        {
            this.caller = caller;
            this.presenter = presenter;
            this.presenter.InvoiceAddingView = this;
            InitializeComponent();
            resetAll();
            presenter.loadExistedInvoice(invoiceCode);
        }
        private void setData(String invoiceCode)
        {
            /*
            txteAIEmployee.Text = AccountPresenter.currentEmployee.EMP_NAME;
            txteAIInvoiceNo.Text = invoice.INVOICE_CODE;
            dpickAIDate.Value =(DateTime)invoice.DATE;
            txteAITotalAmount.Text =invoice.TOTAL_AMOUNT+"";
            txteAITotalPayment.Text = invoice.TOTAL_PAYMENT+"";
            txteAINote.Text = invoice.NOTE;
            txteAIVAT.Text = invoice.VAT_RATE+"";
            */
            //binding columns

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAIDeleteItem_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs arg)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            presenter.removeItem(gvInvoiceItems.FocusedRowHandle);
        }
        
        private void bbtniAIBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            foreach( var form in MdiParent.MdiChildren)
            {

                if (caller.Equals(form))
                {
                    caller.Activate();

                }
            }
            this.Close();
        }

        private void cmbAICustomer_TextChanged(object sender, EventArgs e)
        {

           // presenter.loadCustomerName(cmbAICustomer.Text, true);
        }
        private void cmbAISearchProduct_TextChanged(object sender, EventArgs e)
        {
            //presenter.loadProductName(cmbAICustomer.Text, true);
        }
        public void showProductName(List<string> productNames, bool doShowPopup)
        {
           
            var cmbItems = cmbAISearchProduct.Properties.Items;
            cmbItems.Clear();
            cmbItems.AddRange(productNames);
            if(doShowPopup)
                cmbAISearchProduct.ShowPopup();
            
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

        private void cmbAIPaymentMethod_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void showCustomerName(List<string> customerNames, bool doShowPopup)
        {
           
            var cmbItems = cmbAICustomer.Properties.Items;
            cmbItems.Clear();
            cmbItems.AddRange(customerNames);
            //if (doShowPopup)
            //    cmbAICustomer.ShowPopup();
        }

        private void cmbAISearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = cmbAISearchProduct.Text;
            cmbAISize.ResetText();
            if (text != null && !text.Equals(""))
                presenter.loadSizeOfProduct(cmbAISearchProduct.Text);
        }

        public void showSizeOfProduct(List<String> sizeList)
        {
           
            var cmbItems = cmbAISize.Properties.Items;
            cmbItems.Clear();
            cmbItems.AddRange(sizeList);
        }

        private void btnAIAddItem_Click(object sender, EventArgs e)
        {
            presenter.addItem(cmbAISearchProduct.Text, cmbAISize.Text);
        }

        public void resetItemAddingComponents()
        {
            throw new NotImplementedException();
        }

        public void addItemIntoGrid(String[] invoiceItem)
        {
            /*
            int groupColumnCount = gvInvoiceItems.Columns.Count;
            //Get the handle of the new row 

            gvInvoiceItems.AddNewRow();
            int newRowHandle = gvInvoiceItems.FocusedRowHandle;
            object newRow = gvInvoiceItems.GetRow(newRowHandle);
            if (groupColumnCount > 0)
            {
                for (int i = 0; i < groupColumnCount-2; i++)
                {
                    gvInvoiceItems.SetRowCellValue(newRowHandle, gvInvoiceItems.Columns[i], invoiceItem[i]);
                }
            }
            gvInvoiceItems.UpdateCurrentRow();*/
            
            
            
            table.Rows.Add(invoiceItem);
            grdconAIItems.DataSource = table;
            //cmbAISearchProduct.ResetText();
            //cmbAISize.ResetText();

        }

        public DataTable getInvoiceItemDataTable()
        {
            return table;
        }

        private void gvInvoiceItems_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gvInvoiceItems_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int selectRow = e.RowHandle;


            if (e.Column == gvInvoiceItems.Columns["QUANTITY"] ||
                e.Column == gvInvoiceItems.Columns["DISCOUNT_AMOUNT"] ||
                e.Column == gvInvoiceItems.Columns["UNIT_PRICE"] ||
                e.Column == gvInvoiceItems.Columns["AMOUNT"])
            {
                int quantity = Convert.ToInt16( table.Rows[selectRow]["QUANTITY"]);
                float discount =Convert.ToSingle( table.Rows[selectRow]["DISCOUNT_AMOUNT"]);
                float unitPrice = Convert.ToSingle(table.Rows[selectRow]["UNIT_PRICE"]);
                double amount = Convert.ToDouble( presenter.calculateAmount(quantity, unitPrice, discount));

                table.Rows[selectRow]["AMOUNT"] = amount + "";

                grdconAIItems.DataSource = table;
                presenter.sumTotalAmount();
                //gvInvoiceItems.SetRowCellValue(selectRow, gvInvoiceItems.Columns["AMOUNT"], amount);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbAICustomer.Text.Equals(""))
            {
                MessageBox.Show("Khách hàng không được để trống");
                return;
            }

            if (float.Parse(txteAITotalAmount.Text) <= 0)
            {
                MessageBox.Show("Phải có ít nhất 1 hàng hóa");
                return;
            }

            String cusCodeName = cmbAICustomer.Text;
            String cusCode = cusCodeName.Split(new char[] { '-' })[0];
            
            String paymentMethod = cmbAIPaymentMethod.Text;
            String VAT = txteAIVAT.Text;
            String note = txteAINote.Text;
            DateTime date = dpickAIDate.Value;

            String totalPayment = txteAITotalPayment.Text;
            String totalAmount = txteAITotalAmount.Text;
            presenter.insertInvoice(cusCode, paymentMethod,VAT,note,date, totalPayment, totalAmount);
        }

        public void resetAll()
        {
            //load product name into cmb
            presenter.loadProductName(null, false);
            //load customer name into cmb
            presenter.loadCustomerName(null, false);
            //load payment method into cmb
            cmbAIPaymentMethod.Properties.Items.Clear();
            cmbAIPaymentMethod.Properties.Items.AddRange
                (new String[] {
                     Resources.PM_CASH
                ,    Resources.PM_TRANSFER
                ,    Resources.PM_UNIDENTIFY });
            //set default values
            txteAIVAT.Text = "0";
            txteAIEmployee.Text = AccountPresenter.currentEmployee.EMP_NAME;
            txteAIInvoiceNo.Text = presenter.getTemperatoryCode();


            cmbAICustomer.ResetText();
            cmbAIPaymentMethod.ResetText();
            cmbAISearchProduct.ResetText();
            cmbAISize.ResetText();

            //binding columns
            table = grdconAIItems.DataSource as DataTable;
            if (table == null)
            {
                table = new DataTable();

                var cols = table.Columns;
                cols.Add("INVOICE_ITEM_CODE");
                cols.Add("PRODUCT_NAME");
                cols.Add("SIZE");
                cols.Add("UNIT");
                cols.Add("DISCOUNT_AMOUNT");
                cols.Add("QUANTITY");
                cols.Add("UNIT_PRICE");
                cols.Add("AMOUNT");
                cols.Add("NOTE");
            }
            else
            {
                table.Clear();
                
            }


        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resetAll();
        }

        private void txteAITotalPayment_EditValueChanged(object sender, EventArgs e)
        {
            //presenter check valid payment
            presenter.checkValidPayment(txteAITotalAmount.Text, txteAITotalPayment.Text);  
        }

        public void showTotalPayment(double totalPayment)
        {
            txteAITotalPayment.Text = totalPayment+"";
        }

        public void showTotalAmount(double totalAmount)
        {
            txteAITotalAmount.Text = totalAmount + "";
            txteAIVAT.Text = (totalAmount / 10) + "";
            txteAITotalPayment.Text = totalAmount + "";
        }

        public void showInvoiceItemGrid(DataTable table)
        {
            grdconAIItems.DataSource = table;
            this.table = grdconAIItems.DataSource as DataTable;
        }

        public void showInfoComponents(INVOICE invoice)
        {
            CUSTOMER temp = presenter.findCustomerBy((int)invoice.BUYER_ID);
            cmbAICustomer.Text = temp.CUS_CODE+"-"+temp.CUS_NAME;
            cmbAIPaymentMethod.Text = invoice.PAYMENT_METHOD;
            
            txteAIEmployee.Text = AccountPresenter.currentEmployee.EMP_NAME;
            txteAIInvoiceNo.Text = invoice.INVOICE_CODE;
            dpickAIDate.Value = (DateTime)(invoice.DATE != null ? invoice.DATE : DateTime.Now) ;
            txteAITotalAmount.Text = invoice.TOTAL_AMOUNT + "";
            txteAITotalPayment.Text = invoice.TOTAL_PAYMENT + "";
            txteAINote.Text = invoice.NOTE;
            txteAIVAT.Text = invoice.VAT_RATE + "";
            
        }

        private void btnAINewCustomer_Click(object sender, EventArgs e)
        {
            /*
            Form addEmployForm = new frmAddEmployee(this, new EmployeePresenter());
            addEmployForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addEmployForm.MdiParent = this.MdiParent;
            addEmployForm.Dock = DockStyle.Fill;
            addEmployForm.Show();
            */
            Form addCustomerForm = new frmAddCustomer(this, new CustomerPresenter());
            addCustomerForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addCustomerForm.MdiParent = this.MdiParent;
            addCustomerForm.Dock = DockStyle.Fill;
            addCustomerForm.Show();
        }

        private void btnAINewProduct_Click(object sender, EventArgs e)
        {
            Form addProductForm = new frmAddProduct(new ProductPresenter(), this);
            addProductForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addProductForm.MdiParent = this.MdiParent;
            addProductForm.Dock = DockStyle.Fill;
            addProductForm.Show();

        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbAICustomer.Text.Equals(""))
            {
                MessageBox.Show("Khách hàng không được để trống");
                return;
            }

            if (float.Parse(txteAITotalAmount.Text) <= 0)
            {
                MessageBox.Show("Phải có ít nhất 1 hàng hóa");
                return;
            }

            LocalReport localReport = new LocalReport();
            localReport.ReportEmbeddedResource = "View.Elements.Invoice.ReportInvoice.rdlc";
            localReport.DataSources.Clear();

            DataTable dt = table;

            dt.TableName = "DataSet1";
            ReportDataSource newDataSource =
                new ReportDataSource(dt.TableName, dt);
            localReport.DataSources.Add(newDataSource);
            
            //

            List<ReportParameter> lstt = new List<ReportParameter>();

            String str1, str2, str3, str4, str5;

            SUPPLIER s1 = (new UShopPresenter()).getUShop();
            str1 = s1.SUPPLIER_NAME;
            str2 = "Hóa đơn: " + txteAIInvoiceNo.Text + ", Ngày lập: " + dpickAIDate.Text + ", Người lập: " + txteAIEmployee.Text;
            str3 = "Khách hàng: " + cmbAICustomer.Text;
            str4 = "Đã thanh toán/Tổng thành tiền: " + txteAITotalPayment.Text + "/" + txteAITotalAmount.Text + ", Phương thức: " + cmbAIPaymentMethod.Text;
            str5 = "Ghi chú: " + txteAINote.Text;

            ReportParameter param1 = new ReportParameter("UShop", str1);
            lstt.Add(param1);
            ReportParameter param2 = new ReportParameter("Info", str2);
            lstt.Add(param2);
            ReportParameter param3 = new ReportParameter("Customer", str3);
            lstt.Add(param3);
            ReportParameter param4 = new ReportParameter("Total", str4);
            lstt.Add(param4);
            ReportParameter param5 = new ReportParameter("Note", str5);
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

        private void frmAddInvoice_Activated(object sender, EventArgs e)
        {
            presenter.loadCustomerName(null, false);
            presenter.loadProductName(null, false);

            String text = cmbAISearchProduct.Text;
            cmbAISize.ResetText();
            if (text != null && !text.Equals(""))
                presenter.loadSizeOfProduct(cmbAISearchProduct.Text);
        }
    }
}
