﻿namespace View.Elements.Invoice
{
    partial class frmAddInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInvoice));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvInvoiceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcolInvItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolCalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolInvItemQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolInvItemAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolInvItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelInvoiceItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridItems = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barAIOptions = new DevExpress.XtraBars.Bar();
            this.bbtniAIBack = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAINewCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.btnAINewProduct = new DevExpress.XtraEditors.SimpleButton();
            this.cmbAISearchProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbAICustomer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txteAINote = new System.Windows.Forms.TextBox();
            this.btnAIAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txteAIEmployee = new DevExpress.XtraEditors.TextEdit();
            this.txteAIInvoiceNo = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txteAIVAT = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAIPaymentMethod = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpickAIDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAISearchProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAICustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAIPaymentMethod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvInvoiceItems
            // 
            this.gvInvoiceItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcolInvItemCode,
            this.grdcolProImage,
            this.grdcolProName,
            this.grdcolSize,
            this.grdcolCalName,
            this.grdcolProUnit,
            this.grdcolProUnitPrice,
            this.grdcolProDiscountAmount,
            this.grdcolInvItemQuantity,
            this.grdcolInvItemAmount,
            this.grdcolInvItemDescription,
            this.btnDelInvoiceItem});
            this.gvInvoiceItems.GridControl = this.gridItems;
            this.gvInvoiceItems.Name = "gvInvoiceItems";
            // 
            // grdcolInvItemCode
            // 
            this.grdcolInvItemCode.Caption = "Mã chi tiết";
            this.grdcolInvItemCode.FieldName = "INVOICE_ITEM_CODE";
            this.grdcolInvItemCode.Name = "grdcolInvItemCode";
            this.grdcolInvItemCode.Visible = true;
            this.grdcolInvItemCode.VisibleIndex = 0;
            this.grdcolInvItemCode.Width = 95;
            // 
            // grdcolProImage
            // 
            this.grdcolProImage.Caption = "Hình ảnh";
            this.grdcolProImage.FieldName = "PRODUCT_IMG";
            this.grdcolProImage.Name = "grdcolProImage";
            this.grdcolProImage.Visible = true;
            this.grdcolProImage.VisibleIndex = 1;
            this.grdcolProImage.Width = 95;
            // 
            // grdcolProName
            // 
            this.grdcolProName.Caption = "Tên sản phẩm";
            this.grdcolProName.FieldName = "PRODUCT_NAME";
            this.grdcolProName.Name = "grdcolProName";
            this.grdcolProName.Visible = true;
            this.grdcolProName.VisibleIndex = 2;
            this.grdcolProName.Width = 137;
            // 
            // grdcolSize
            // 
            this.grdcolSize.Caption = "Kích cỡ";
            this.grdcolSize.FieldName = "SIZE";
            this.grdcolSize.Name = "grdcolSize";
            this.grdcolSize.Visible = true;
            this.grdcolSize.VisibleIndex = 3;
            this.grdcolSize.Width = 54;
            // 
            // grdcolCalName
            // 
            this.grdcolCalName.Caption = "Loại";
            this.grdcolCalName.FieldName = "CATEGORY_NAME";
            this.grdcolCalName.Name = "grdcolCalName";
            this.grdcolCalName.Visible = true;
            this.grdcolCalName.VisibleIndex = 4;
            this.grdcolCalName.Width = 60;
            // 
            // grdcolProUnit
            // 
            this.grdcolProUnit.Caption = "ĐVT";
            this.grdcolProUnit.FieldName = "UNIT";
            this.grdcolProUnit.Name = "grdcolProUnit";
            this.grdcolProUnit.Visible = true;
            this.grdcolProUnit.VisibleIndex = 5;
            this.grdcolProUnit.Width = 47;
            // 
            // grdcolProUnitPrice
            // 
            this.grdcolProUnitPrice.Caption = "Đơn giá";
            this.grdcolProUnitPrice.FieldName = "UNIT_PRICE";
            this.grdcolProUnitPrice.Name = "grdcolProUnitPrice";
            this.grdcolProUnitPrice.Visible = true;
            this.grdcolProUnitPrice.VisibleIndex = 8;
            this.grdcolProUnitPrice.Width = 105;
            // 
            // grdcolProDiscountAmount
            // 
            this.grdcolProDiscountAmount.Caption = "Giảm";
            this.grdcolProDiscountAmount.FieldName = "DISCOUNT_AMOUNT";
            this.grdcolProDiscountAmount.Name = "grdcolProDiscountAmount";
            this.grdcolProDiscountAmount.Visible = true;
            this.grdcolProDiscountAmount.VisibleIndex = 6;
            this.grdcolProDiscountAmount.Width = 80;
            // 
            // grdcolInvItemQuantity
            // 
            this.grdcolInvItemQuantity.Caption = "Số lượng";
            this.grdcolInvItemQuantity.FieldName = "QUANTITY";
            this.grdcolInvItemQuantity.Name = "grdcolInvItemQuantity";
            this.grdcolInvItemQuantity.Visible = true;
            this.grdcolInvItemQuantity.VisibleIndex = 7;
            this.grdcolInvItemQuantity.Width = 68;
            // 
            // grdcolInvItemAmount
            // 
            this.grdcolInvItemAmount.Caption = "Thành tiền";
            this.grdcolInvItemAmount.FieldName = "AMOUNT";
            this.grdcolInvItemAmount.Name = "grdcolInvItemAmount";
            this.grdcolInvItemAmount.Visible = true;
            this.grdcolInvItemAmount.VisibleIndex = 9;
            this.grdcolInvItemAmount.Width = 150;
            // 
            // grdcolInvItemDescription
            // 
            this.grdcolInvItemDescription.Caption = "Mô tả";
            this.grdcolInvItemDescription.FieldName = "DESCRIPTION";
            this.grdcolInvItemDescription.Name = "grdcolInvItemDescription";
            this.grdcolInvItemDescription.Visible = true;
            this.grdcolInvItemDescription.VisibleIndex = 10;
            this.grdcolInvItemDescription.Width = 192;
            // 
            // btnDelInvoiceItem
            // 
            this.btnDelInvoiceItem.Caption = "Xóa";
            this.btnDelInvoiceItem.ColumnEdit = this.btnDeleteItem;
            this.btnDelInvoiceItem.Name = "btnDelInvoiceItem";
            this.btnDelInvoiceItem.Visible = true;
            this.btnDelInvoiceItem.VisibleIndex = 11;
            this.btnDelInvoiceItem.Width = 40;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.AutoHeight = false;
            this.btnDeleteItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridItems
            // 
            this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Level1";
            this.gridItems.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridItems.Location = new System.Drawing.Point(0, 288);
            this.gridItems.MainView = this.gvInvoiceItems;
            this.gridItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridItems.MenuManager = this.barManager1;
            this.gridItems.Name = "gridItems";
            this.gridItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteItem});
            this.gridItems.Size = new System.Drawing.Size(1143, 329);
            this.gridItems.TabIndex = 7;
            this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoiceItems});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barAIOptions,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.barButtonItem1,
            this.barButtonItem2,
            this.bbtniAIBack});
            this.barManager1.MainMenu = this.barAIOptions;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barAIOptions
            // 
            this.barAIOptions.BarName = "Main menu";
            this.barAIOptions.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barAIOptions.DockCol = 0;
            this.barAIOptions.DockRow = 0;
            this.barAIOptions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barAIOptions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAIBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barAIOptions.OptionsBar.AllowQuickCustomization = false;
            this.barAIOptions.OptionsBar.MultiLine = true;
            this.barAIOptions.OptionsBar.UseWholeRow = true;
            this.barAIOptions.Text = "Main menu";
            // 
            // bbtniAIBack
            // 
            this.bbtniAIBack.Caption = "Quay về";
            this.bbtniAIBack.Id = 3;
            this.bbtniAIBack.ImageUri.Uri = "Undo";
            this.bbtniAIBack.Name = "bbtniAIBack";
            this.bbtniAIBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAIBack_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Lưu";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageUri.Uri = "Apply";
            this.btnAdd.Name = "btnAdd";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageUri.Uri = "Print";
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xóa";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageUri.Uri = "Cancel";
            this.barButtonItem2.Name = "barButtonItem2";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1143, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 617);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1143, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 587);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1143, 30);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 587);
            // 
            // btnAINewCustomer
            // 
            this.btnAINewCustomer.Location = new System.Drawing.Point(349, 33);
            this.btnAINewCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAINewCustomer.Name = "btnAINewCustomer";
            this.btnAINewCustomer.Size = new System.Drawing.Size(84, 28);
            this.btnAINewCustomer.TabIndex = 20;
            this.btnAINewCustomer.Text = "KH mới";
            // 
            // btnAINewProduct
            // 
            this.btnAINewProduct.Location = new System.Drawing.Point(442, 213);
            this.btnAINewProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAINewProduct.Name = "btnAINewProduct";
            this.btnAINewProduct.Size = new System.Drawing.Size(78, 28);
            this.btnAINewProduct.TabIndex = 19;
            this.btnAINewProduct.Text = "Hàng mới";
            // 
            // cmbAISearchProduct
            // 
            this.cmbAISearchProduct.Location = new System.Drawing.Point(110, 216);
            this.cmbAISearchProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAISearchProduct.MenuManager = this.barManager1;
            this.cmbAISearchProduct.Name = "cmbAISearchProduct";
            this.cmbAISearchProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAISearchProduct.Size = new System.Drawing.Size(233, 22);
            this.cmbAISearchProduct.TabIndex = 16;
            this.cmbAISearchProduct.TextChanged += new System.EventHandler(this.cmbAISearchProduct_TextChanged);
            // 
            // cmbAICustomer
            // 
            this.cmbAICustomer.Location = new System.Drawing.Point(115, 36);
            this.cmbAICustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAICustomer.MenuManager = this.barManager1;
            this.cmbAICustomer.Name = "cmbAICustomer";
            this.cmbAICustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAICustomer.Size = new System.Drawing.Size(228, 22);
            this.cmbAICustomer.TabIndex = 15;
            this.cmbAICustomer.TextChanged += new System.EventHandler(this.cmbAICustomer_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ghi chú:";
            // 
            // txteAINote
            // 
            this.txteAINote.Location = new System.Drawing.Point(887, 36);
            this.txteAINote.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.txteAINote.Multiline = true;
            this.txteAINote.Name = "txteAINote";
            this.txteAINote.Size = new System.Drawing.Size(243, 66);
            this.txteAINote.TabIndex = 12;
            // 
            // btnAIAddItem
            // 
            this.btnAIAddItem.Location = new System.Drawing.Point(349, 213);
            this.btnAIAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAIAddItem.Name = "btnAIAddItem";
            this.btnAIAddItem.Size = new System.Drawing.Size(87, 28);
            this.btnAIAddItem.TabIndex = 11;
            this.btnAIAddItem.Text = "Thêm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tìm hàng:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txteAIEmployee);
            this.groupControl1.Controls.Add(this.txteAIInvoiceNo);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txteAIVAT);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cmbAIPaymentMethod);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.btnAINewCustomer);
            this.groupControl1.Controls.Add(this.btnAINewProduct);
            this.groupControl1.Controls.Add(this.cmbAISearchProduct);
            this.groupControl1.Controls.Add(this.cmbAICustomer);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txteAINote);
            this.groupControl1.Controls.Add(this.btnAIAddItem);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.dpickAIDate);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 30);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 258);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông tin hóa đơn";
            // 
            // txteAIEmployee
            // 
            this.txteAIEmployee.Location = new System.Drawing.Point(540, 77);
            this.txteAIEmployee.MenuManager = this.barManager1;
            this.txteAIEmployee.Name = "txteAIEmployee";
            this.txteAIEmployee.Properties.ReadOnly = true;
            this.txteAIEmployee.Size = new System.Drawing.Size(276, 22);
            this.txteAIEmployee.TabIndex = 29;
            // 
            // txteAIInvoiceNo
            // 
            this.txteAIInvoiceNo.Location = new System.Drawing.Point(540, 36);
            this.txteAIInvoiceNo.MenuManager = this.barManager1;
            this.txteAIInvoiceNo.Name = "txteAIInvoiceNo";
            this.txteAIInvoiceNo.Properties.ReadOnly = true;
            this.txteAIInvoiceNo.Size = new System.Drawing.Size(276, 22);
            this.txteAIInvoiceNo.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "NV lập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Hóa đơn:";
            // 
            // txteAIVAT
            // 
            this.txteAIVAT.Location = new System.Drawing.Point(115, 118);
            this.txteAIVAT.MenuManager = this.barManager1;
            this.txteAIVAT.Name = "txteAIVAT";
            this.txteAIVAT.Size = new System.Drawing.Size(228, 22);
            this.txteAIVAT.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "VAT:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbAIPaymentMethod
            // 
            this.cmbAIPaymentMethod.Location = new System.Drawing.Point(115, 77);
            this.cmbAIPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAIPaymentMethod.MenuManager = this.barManager1;
            this.cmbAIPaymentMethod.Name = "cmbAIPaymentMethod";
            this.cmbAIPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAIPaymentMethod.Size = new System.Drawing.Size(228, 22);
            this.cmbAIPaymentMethod.TabIndex = 22;
            this.cmbAIPaymentMethod.TextChanged += new System.EventHandler(this.cmbAIPaymentMethod_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phương thức:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày lập:";
            // 
            // dpickAIDate
            // 
            this.dpickAIDate.Location = new System.Drawing.Point(540, 116);
            this.dpickAIDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpickAIDate.Name = "dpickAIDate";
            this.dpickAIDate.Size = new System.Drawing.Size(277, 23);
            this.dpickAIDate.TabIndex = 0;
            // 
            // frmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 642);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAddInvoice";
            this.Text = "Thêm hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAISearchProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAICustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAIPaymentMethod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoiceItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteItem;
        private DevExpress.XtraGrid.GridControl gridItems;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barAIOptions;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAINewCustomer;
        private DevExpress.XtraEditors.SimpleButton btnAINewProduct;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAISearchProduct;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAICustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txteAINote;
        private DevExpress.XtraEditors.SimpleButton btnAIAddItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpickAIDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolInvItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolSize;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolProUnit;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolProUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolInvItemQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolInvItemAmount;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolInvItemDescription;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAIPaymentMethod;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolProImage;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolProName;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolProDiscountAmount;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txteAIEmployee;
        private DevExpress.XtraEditors.TextEdit txteAIInvoiceNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txteAIVAT;
        private DevExpress.XtraGrid.Columns.GridColumn btnDelInvoiceItem;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolCalName;
        private DevExpress.XtraBars.BarButtonItem bbtniAIBack;
    }
}