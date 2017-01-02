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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnILDeleteInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnILUpdateInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnUPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbtniILExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniILAddInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnILDeleteInvoice.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.btnILDeleteInvoice.Name = "btnILDeleteInvoice";
            this.btnILDeleteInvoice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnILDeleteInvoice.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnILDeleteInvoice_ButtonClick);
            // 
            // btnILUpdateInvoice
            // 
            this.btnILUpdateInvoice.AutoHeight = false;
            this.btnILUpdateInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnILUpdateInvoice.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
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
            this.btnUPDATE.Width = 26;
            // 
            // btnDELETE
            // 
            this.btnDELETE.ColumnEdit = this.btnILDeleteInvoice;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Visible = true;
            this.btnDELETE.VisibleIndex = 8;
            this.btnDELETE.Width = 33;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 231);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(659, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 231);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 255);
            this.barDockControlBottom.Size = new System.Drawing.Size(659, 23);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(659, 24);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbtniILExport
            // 
            this.bbtniILExport.Caption = "Xuất danh sách";
            this.bbtniILExport.Id = 1;
            this.bbtniILExport.ImageUri.Uri = "ExportToXLSX";
            this.bbtniILExport.Name = "bbtniILExport";
            // 
            // bbtniILAddInvoice
            // 
            this.bbtniILAddInvoice.Caption = "Thêm mới";
            this.bbtniILAddInvoice.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtniILAddInvoice.Glyph")));
            this.bbtniILAddInvoice.Id = 0;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniILExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtniILAddInvoice,
            this.bbtniILExport});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
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
            this.grdcolInvCode.Visible = true;
            this.grdcolInvCode.VisibleIndex = 0;
            this.grdcolInvCode.Width = 99;
            // 
            // grdcolBuyerName
            // 
            this.grdcolBuyerName.Caption = "Tên KH";
            this.grdcolBuyerName.FieldName = "CUS_NAME";
            this.grdcolBuyerName.Name = "grdcolBuyerName";
            this.grdcolBuyerName.Visible = true;
            this.grdcolBuyerName.VisibleIndex = 4;
            this.grdcolBuyerName.Width = 96;
            // 
            // grdcolSeller
            // 
            this.grdcolSeller.Caption = "Tên NVBH";
            this.grdcolSeller.FieldName = "EMP_NAME";
            this.grdcolSeller.Name = "grdcolSeller";
            this.grdcolSeller.Visible = true;
            this.grdcolSeller.VisibleIndex = 5;
            this.grdcolSeller.Width = 99;
            // 
            // grdcolPaymentMethod
            // 
            this.grdcolPaymentMethod.Caption = "PTTT";
            this.grdcolPaymentMethod.FieldName = "PAYMENT_METHOD";
            this.grdcolPaymentMethod.Name = "grdcolPaymentMethod";
            this.grdcolPaymentMethod.Visible = true;
            this.grdcolPaymentMethod.VisibleIndex = 3;
            this.grdcolPaymentMethod.Width = 99;
            // 
            // grdcolTotalAmount
            // 
            this.grdcolTotalAmount.Caption = "Tổng tiền";
            this.grdcolTotalAmount.FieldName = "TOTAL_AMOUNT";
            this.grdcolTotalAmount.Name = "grdcolTotalAmount";
            this.grdcolTotalAmount.Visible = true;
            this.grdcolTotalAmount.VisibleIndex = 1;
            this.grdcolTotalAmount.Width = 99;
            // 
            // grdcolTotalPayment
            // 
            this.grdcolTotalPayment.Caption = "Đã thanh toán";
            this.grdcolTotalPayment.FieldName = "TOTAL_PAYMENT";
            this.grdcolTotalPayment.Name = "grdcolTotalPayment";
            this.grdcolTotalPayment.Visible = true;
            this.grdcolTotalPayment.VisibleIndex = 2;
            this.grdcolTotalPayment.Width = 99;
            // 
            // grdcolDate
            // 
            this.grdcolDate.Caption = "Ngày lập HĐ";
            this.grdcolDate.FieldName = "DATE";
            this.grdcolDate.Name = "grdcolDate";
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
            this.grdconILInvoice.Size = new System.Drawing.Size(659, 231);
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
            this.Text = "frmInvoice";
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
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbtniILExport;
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
    }
}