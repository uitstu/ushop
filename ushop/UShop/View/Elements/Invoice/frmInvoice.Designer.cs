using System;
using DevExpress.XtraEditors.Controls;

namespace View.Elements.Invoice
{
    partial class frmInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnILDeleteInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnILUpdateInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnUPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniILAddInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnPDF = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.gvILInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcolInvCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolBuyerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolSeller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolTotalPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdconILInvoice = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnILDeleteInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnILUpdateInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvILInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconILInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnILDeleteInvoice
            // 
            this.btnILDeleteInvoice.AutoHeight = false;
            this.btnILDeleteInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnILDeleteInvoice.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.btnILDeleteInvoice.Name = "btnILDeleteInvoice";
            this.btnILDeleteInvoice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnILDeleteInvoice.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnILDeleteInvoice_ButtonClick);
            // 
            // btnILUpdateInvoice
            // 
            this.btnILUpdateInvoice.AutoHeight = false;
            this.btnILUpdateInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnILUpdateInvoice.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true)});
            this.btnILUpdateInvoice.Name = "btnILUpdateInvoice";
            this.btnILUpdateInvoice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnILUpdateInvoice.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnILUpdateInvoice_ButtonClick);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ColumnEdit = this.btnILUpdateInvoice;
            this.btnUPDATE.FieldName = "btnUPDATE";
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Visible = true;
            this.btnUPDATE.VisibleIndex = 7;
            this.btnUPDATE.Width = 20;
            // 
            // btnDELETE
            // 
            this.btnDELETE.ColumnEdit = this.btnILDeleteInvoice;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Visible = true;
            this.btnDELETE.VisibleIndex = 8;
            this.btnDELETE.Width = 20;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 254);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(659, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 254);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 278);
            this.barDockControlBottom.Size = new System.Drawing.Size(659, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(659, 24);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Xuất danh sách";
            this.btnExcel.Id = 1;
            this.btnExcel.ImageUri.Uri = "ExportToXLSX";
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // bbtniILAddInvoice
            // 
            this.bbtniILAddInvoice.Caption = "Thêm mới";
            this.bbtniILAddInvoice.Id = 0;
            this.bbtniILAddInvoice.ImageUri.Uri = "Add";
            this.bbtniILAddInvoice.Name = "bbtniILAddInvoice";
            this.bbtniILAddInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniILAddInvoice_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniILAddInvoice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPDF, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnPDF
            // 
            this.btnPDF.Caption = "Xuất danh sách";
            this.btnPDF.Id = 2;
            this.btnPDF.ImageUri.Uri = "ExportToPDF";
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPDF_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtniILAddInvoice,
            this.btnExcel,
            this.btnPDF});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // gvILInvoice
            // 
            this.gvILInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcolInvCode,
            this.grdcolBuyerName,
            this.grdcolSeller,
            this.grdcolPaymentMethod,
            this.grdcolTotalAmount,
            this.grdcolTotalPayment,
            this.grdcolDate,
            this.btnUPDATE,
            this.btnDELETE});
            this.gvILInvoice.GridControl = this.grdconILInvoice;
            this.gvILInvoice.Name = "gvILInvoice";
            this.gvILInvoice.OptionsView.ShowAutoFilterRow = true;
            // 
            // grdcolInvCode
            // 
            this.grdcolInvCode.Caption = "Mã hóa đơn";
            this.grdcolInvCode.FieldName = "INVOICE_CODE";
            this.grdcolInvCode.Name = "grdcolInvCode";
            this.grdcolInvCode.OptionsColumn.AllowEdit = false;
            this.grdcolInvCode.Visible = true;
            this.grdcolInvCode.VisibleIndex = 0;
            this.grdcolInvCode.Width = 99;
            // 
            // grdcolBuyerName
            // 
            this.grdcolBuyerName.Caption = "Tên KH";
            this.grdcolBuyerName.FieldName = "CUS_NAME";
            this.grdcolBuyerName.Name = "grdcolBuyerName";
            this.grdcolBuyerName.OptionsColumn.AllowEdit = false;
            this.grdcolBuyerName.Visible = true;
            this.grdcolBuyerName.VisibleIndex = 4;
            this.grdcolBuyerName.Width = 96;
            // 
            // grdcolSeller
            // 
            this.grdcolSeller.Caption = "Tên NVBH";
            this.grdcolSeller.FieldName = "EMP_NAME";
            this.grdcolSeller.Name = "grdcolSeller";
            this.grdcolSeller.OptionsColumn.AllowEdit = false;
            this.grdcolSeller.Visible = true;
            this.grdcolSeller.VisibleIndex = 5;
            this.grdcolSeller.Width = 99;
            // 
            // grdcolPaymentMethod
            // 
            this.grdcolPaymentMethod.Caption = "PTTT";
            this.grdcolPaymentMethod.FieldName = "PAYMENT_METHOD";
            this.grdcolPaymentMethod.Name = "grdcolPaymentMethod";
            this.grdcolPaymentMethod.OptionsColumn.AllowEdit = false;
            this.grdcolPaymentMethod.Visible = true;
            this.grdcolPaymentMethod.VisibleIndex = 3;
            this.grdcolPaymentMethod.Width = 99;
            // 
            // grdcolTotalAmount
            // 
            this.grdcolTotalAmount.Caption = "Tổng tiền";
            this.grdcolTotalAmount.FieldName = "TOTAL_AMOUNT";
            this.grdcolTotalAmount.Name = "grdcolTotalAmount";
            this.grdcolTotalAmount.OptionsColumn.AllowEdit = false;
            this.grdcolTotalAmount.Visible = true;
            this.grdcolTotalAmount.VisibleIndex = 1;
            this.grdcolTotalAmount.Width = 99;
            // 
            // grdcolTotalPayment
            // 
            this.grdcolTotalPayment.Caption = "Đã thanh toán";
            this.grdcolTotalPayment.FieldName = "TOTAL_PAYMENT";
            this.grdcolTotalPayment.Name = "grdcolTotalPayment";
            this.grdcolTotalPayment.OptionsColumn.AllowEdit = false;
            this.grdcolTotalPayment.Visible = true;
            this.grdcolTotalPayment.VisibleIndex = 2;
            this.grdcolTotalPayment.Width = 99;
            // 
            // grdcolDate
            // 
            this.grdcolDate.Caption = "Ngày lập HĐ";
            this.grdcolDate.FieldName = "DATE";
            this.grdcolDate.Name = "grdcolDate";
            this.grdcolDate.OptionsColumn.AllowEdit = false;
            this.grdcolDate.Visible = true;
            this.grdcolDate.VisibleIndex = 6;
            this.grdcolDate.Width = 99;
            // 
            // grdconILInvoice
            // 
            this.grdconILInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdconILInvoice.Location = new System.Drawing.Point(0, 24);
            this.grdconILInvoice.MainView = this.gvILInvoice;
            this.grdconILInvoice.MenuManager = this.barManager1;
            this.grdconILInvoice.Name = "grdconILInvoice";
            this.grdconILInvoice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnILUpdateInvoice,
            this.btnILDeleteInvoice});
            this.grdconILInvoice.Size = new System.Drawing.Size(659, 254);
            this.grdconILInvoice.TabIndex = 7;
            this.grdconILInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvILInvoice});
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 278);
            this.Controls.Add(this.grdconILInvoice);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInvoice";
            this.Text = "Quản lý hóa đơn";
            this.Activated += new System.EventHandler(this.frmInvoice_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.btnILDeleteInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnILUpdateInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvILInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconILInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnILDeleteInvoice;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnILUpdateInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn btnUPDATE;
        private DevExpress.XtraGrid.Columns.GridColumn btnDELETE;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem bbtniILAddInvoice;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraGrid.GridControl grdconILInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvILInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolInvCode;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolBuyerName;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolSeller;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolTotalPayment;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolDate;
        private DevExpress.XtraBars.BarButtonItem btnPDF;
    }
}