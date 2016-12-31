namespace View.Elements.Invoice
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
            this.btnAIDeleteItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gvInvoiceItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdcolInvItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolProDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolInvItemQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolInvItemAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcolInvItemNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAIDelInvoiceItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdconAIItems = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barAIOptions = new DevExpress.XtraBars.Bar();
            this.bbtniAIBack = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bsiAIState = new DevExpress.XtraBars.BarStaticItem();
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
            this.txteAITotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.txteAITotalPayment = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAISize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label9 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconAIItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAISearchProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAICustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteAITotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAITotalPayment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAISize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAIPaymentMethod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAIDeleteItem
            // 
            this.btnAIDeleteItem.AutoHeight = false;
            this.btnAIDeleteItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnAIDeleteItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnAIDeleteItem.Name = "btnAIDeleteItem";
            this.btnAIDeleteItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAIDeleteItem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAIDeleteItem_Click);
            // 
            // gvInvoiceItems
            // 
            this.gvInvoiceItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdcolInvItemCode,
            this.grdcolProName,
            this.grdcolSize,
            this.grdcolProUnit,
            this.grdcolProUnitPrice,
            this.grdcolProDiscountAmount,
            this.grdcolInvItemQuantity,
            this.grdcolInvItemAmount,
            this.grdcolInvItemNote,
            this.btnAIDelInvoiceItem});
            this.gvInvoiceItems.GridControl = this.grdconAIItems;
            this.gvInvoiceItems.Name = "gvInvoiceItems";
            this.gvInvoiceItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvInvoiceItems.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvInvoiceItems.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvInvoiceItems_CellValueChanged);
            this.gvInvoiceItems.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvInvoiceItems_CellValueChanging);
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
            // grdcolProName
            // 
            this.grdcolProName.Caption = "Tên sản phẩm";
            this.grdcolProName.FieldName = "PRODUCT_NAME";
            this.grdcolProName.Name = "grdcolProName";
            this.grdcolProName.Visible = true;
            this.grdcolProName.VisibleIndex = 1;
            this.grdcolProName.Width = 137;
            // 
            // grdcolSize
            // 
            this.grdcolSize.Caption = "Kích cỡ";
            this.grdcolSize.FieldName = "SIZE";
            this.grdcolSize.Name = "grdcolSize";
            this.grdcolSize.Visible = true;
            this.grdcolSize.VisibleIndex = 2;
            this.grdcolSize.Width = 54;
            // 
            // grdcolProUnit
            // 
            this.grdcolProUnit.Caption = "ĐVT";
            this.grdcolProUnit.FieldName = "UNIT";
            this.grdcolProUnit.Name = "grdcolProUnit";
            this.grdcolProUnit.Visible = true;
            this.grdcolProUnit.VisibleIndex = 3;
            this.grdcolProUnit.Width = 47;
            // 
            // grdcolProUnitPrice
            // 
            this.grdcolProUnitPrice.Caption = "Đơn giá";
            this.grdcolProUnitPrice.FieldName = "UNIT_PRICE";
            this.grdcolProUnitPrice.Name = "grdcolProUnitPrice";
            this.grdcolProUnitPrice.Visible = true;
            this.grdcolProUnitPrice.VisibleIndex = 6;
            this.grdcolProUnitPrice.Width = 105;
            // 
            // grdcolProDiscountAmount
            // 
            this.grdcolProDiscountAmount.Caption = "Giảm";
            this.grdcolProDiscountAmount.FieldName = "DISCOUNT_AMOUNT";
            this.grdcolProDiscountAmount.Name = "grdcolProDiscountAmount";
            this.grdcolProDiscountAmount.Visible = true;
            this.grdcolProDiscountAmount.VisibleIndex = 4;
            this.grdcolProDiscountAmount.Width = 80;
            // 
            // grdcolInvItemQuantity
            // 
            this.grdcolInvItemQuantity.Caption = "Số lượng";
            this.grdcolInvItemQuantity.FieldName = "QUANTITY";
            this.grdcolInvItemQuantity.Name = "grdcolInvItemQuantity";
            this.grdcolInvItemQuantity.Visible = true;
            this.grdcolInvItemQuantity.VisibleIndex = 5;
            this.grdcolInvItemQuantity.Width = 68;
            // 
            // grdcolInvItemAmount
            // 
            this.grdcolInvItemAmount.Caption = "Thành tiền";
            this.grdcolInvItemAmount.FieldName = "AMOUNT";
            this.grdcolInvItemAmount.Name = "grdcolInvItemAmount";
            this.grdcolInvItemAmount.Visible = true;
            this.grdcolInvItemAmount.VisibleIndex = 7;
            this.grdcolInvItemAmount.Width = 150;
            // 
            // grdcolInvItemNote
            // 
            this.grdcolInvItemNote.Caption = "Mô tả";
            this.grdcolInvItemNote.FieldName = "NOTE";
            this.grdcolInvItemNote.Name = "grdcolInvItemNote";
            this.grdcolInvItemNote.Visible = true;
            this.grdcolInvItemNote.VisibleIndex = 8;
            this.grdcolInvItemNote.Width = 192;
            // 
            // btnAIDelInvoiceItem
            // 
            this.btnAIDelInvoiceItem.Caption = "Xóa";
            this.btnAIDelInvoiceItem.ColumnEdit = this.btnAIDeleteItem;
            this.btnAIDelInvoiceItem.Name = "btnAIDelInvoiceItem";
            this.btnAIDelInvoiceItem.Visible = true;
            this.btnAIDelInvoiceItem.VisibleIndex = 9;
            this.btnAIDelInvoiceItem.Width = 40;
            // 
            // grdconAIItems
            // 
            this.grdconAIItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdconAIItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Level1";
            this.grdconAIItems.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdconAIItems.Location = new System.Drawing.Point(0, 288);
            this.grdconAIItems.MainView = this.gvInvoiceItems;
            this.grdconAIItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdconAIItems.MenuManager = this.barManager1;
            this.grdconAIItems.Name = "grdconAIItems";
            this.grdconAIItems.Size = new System.Drawing.Size(1143, 320);
            this.grdconAIItems.TabIndex = 7;
            this.grdconAIItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.bbtniAIBack,
            this.bsiAIState});
            this.barManager1.MainMenu = this.barAIOptions;
            this.barManager1.MaxItemId = 5;
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
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
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
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiAIState)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bsiAIState
            // 
            this.bsiAIState.Caption = "State";
            this.bsiAIState.Id = 4;
            this.bsiAIState.Name = "bsiAIState";
            this.bsiAIState.TextAlignment = System.Drawing.StringAlignment.Near;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 608);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1143, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 578);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1143, 30);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 578);
            // 
            // btnAINewCustomer
            // 
            this.btnAINewCustomer.Location = new System.Drawing.Point(349, 33);
            this.btnAINewCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAINewCustomer.Name = "btnAINewCustomer";
            this.btnAINewCustomer.Size = new System.Drawing.Size(84, 28);
            this.btnAINewCustomer.TabIndex = 20;
            this.btnAINewCustomer.Text = "KH mới";
            this.btnAINewCustomer.Click += new System.EventHandler(this.btnAINewCustomer_Click);
            // 
            // btnAINewProduct
            // 
            this.btnAINewProduct.Location = new System.Drawing.Point(349, 213);
            this.btnAINewProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAINewProduct.Name = "btnAINewProduct";
            this.btnAINewProduct.Size = new System.Drawing.Size(78, 28);
            this.btnAINewProduct.TabIndex = 19;
            this.btnAINewProduct.Text = "Hàng mới";
            this.btnAINewProduct.Click += new System.EventHandler(this.btnAINewProduct_Click);
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
            this.cmbAISearchProduct.SelectedIndexChanged += new System.EventHandler(this.cmbAISearchProduct_SelectedIndexChanged);
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
            this.label7.Location = new System.Drawing.Point(440, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ghi chú:";
            // 
            // txteAINote
            // 
            this.txteAINote.Location = new System.Drawing.Point(512, 29);
            this.txteAINote.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.txteAINote.Multiline = true;
            this.txteAINote.Name = "txteAINote";
            this.txteAINote.Size = new System.Drawing.Size(277, 70);
            this.txteAINote.TabIndex = 12;
            // 
            // btnAIAddItem
            // 
            this.btnAIAddItem.AllowFocus = false;
            this.btnAIAddItem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAIAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAIAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAIAddItem.Image")));
            this.btnAIAddItem.Location = new System.Drawing.Point(678, 208);
            this.btnAIAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAIAddItem.Name = "btnAIAddItem";
            this.btnAIAddItem.Size = new System.Drawing.Size(111, 37);
            this.btnAIAddItem.TabIndex = 11;
            this.btnAIAddItem.Text = "Thêm vào";
            this.btnAIAddItem.Click += new System.EventHandler(this.btnAIAddItem_Click);
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
            this.groupControl1.Controls.Add(this.txteAITotalAmount);
            this.groupControl1.Controls.Add(this.txteAITotalPayment);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.cmbAISize);
            this.groupControl1.Controls.Add(this.label9);
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
            // txteAITotalAmount
            // 
            this.txteAITotalAmount.EditValue = "0";
            this.txteAITotalAmount.Location = new System.Drawing.Point(664, 116);
            this.txteAITotalAmount.MenuManager = this.barManager1;
            this.txteAITotalAmount.Name = "txteAITotalAmount";
            this.txteAITotalAmount.Properties.ReadOnly = true;
            this.txteAITotalAmount.Size = new System.Drawing.Size(125, 22);
            this.txteAITotalAmount.TabIndex = 38;
            // 
            // txteAITotalPayment
            // 
            this.txteAITotalPayment.EditValue = "0";
            this.txteAITotalPayment.Location = new System.Drawing.Point(512, 116);
            this.txteAITotalPayment.MenuManager = this.barManager1;
            this.txteAITotalPayment.Name = "txteAITotalPayment";
            this.txteAITotalPayment.Size = new System.Drawing.Size(127, 22);
            this.txteAITotalPayment.TabIndex = 37;
            this.txteAITotalPayment.EditValueChanged += new System.EventHandler(this.txteAITotalPayment_EditValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tổng trả:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(645, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "/";
            // 
            // cmbAISize
            // 
            this.cmbAISize.Location = new System.Drawing.Point(512, 216);
            this.cmbAISize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAISize.MenuManager = this.barManager1;
            this.cmbAISize.Name = "cmbAISize";
            this.cmbAISize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAISize.Size = new System.Drawing.Size(60, 22);
            this.cmbAISize.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Chọn cỡ:";
            // 
            // txteAIEmployee
            // 
            this.txteAIEmployee.Location = new System.Drawing.Point(887, 77);
            this.txteAIEmployee.MenuManager = this.barManager1;
            this.txteAIEmployee.Name = "txteAIEmployee";
            this.txteAIEmployee.Properties.ReadOnly = true;
            this.txteAIEmployee.Size = new System.Drawing.Size(244, 22);
            this.txteAIEmployee.TabIndex = 29;
            // 
            // txteAIInvoiceNo
            // 
            this.txteAIInvoiceNo.Location = new System.Drawing.Point(887, 36);
            this.txteAIInvoiceNo.MenuManager = this.barManager1;
            this.txteAIInvoiceNo.Name = "txteAIInvoiceNo";
            this.txteAIInvoiceNo.Properties.ReadOnly = true;
            this.txteAIInvoiceNo.Size = new System.Drawing.Size(244, 22);
            this.txteAIInvoiceNo.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "NV lập:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 39);
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
            this.label1.Location = new System.Drawing.Point(815, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày lập:";
            // 
            // dpickAIDate
            // 
            this.dpickAIDate.Location = new System.Drawing.Point(887, 117);
            this.dpickAIDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpickAIDate.Name = "dpickAIDate";
            this.dpickAIDate.Size = new System.Drawing.Size(244, 23);
            this.dpickAIDate.TabIndex = 0;
            // 
            // frmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 642);
            this.Controls.Add(this.grdconAIItems);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAddInvoice";
            this.Text = "Thêm hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconAIItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAISearchProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAICustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteAITotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAITotalPayment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAISize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAIVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAIPaymentMethod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoiceItems;
        private DevExpress.XtraGrid.GridControl grdconAIItems;
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
        private DevExpress.XtraGrid.Columns.GridColumn grdcolInvItemNote;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAIPaymentMethod;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolProName;
        private DevExpress.XtraGrid.Columns.GridColumn grdcolProDiscountAmount;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txteAIEmployee;
        private DevExpress.XtraEditors.TextEdit txteAIInvoiceNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txteAIVAT;
        private DevExpress.XtraGrid.Columns.GridColumn btnAIDelInvoiceItem;
        private DevExpress.XtraBars.BarButtonItem bbtniAIBack;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAIDeleteItem;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAISize;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraBars.BarStaticItem bsiAIState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txteAITotalAmount;
        private DevExpress.XtraEditors.TextEdit txteAITotalPayment;
    }
}