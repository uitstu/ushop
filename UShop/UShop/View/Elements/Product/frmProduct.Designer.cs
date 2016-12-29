namespace View.Elements.Product
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PRODUCT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRODUCT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CATEGORY_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SELLING_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COST_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SALE_AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRODUCER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ORIGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.PRODUCT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CATEGORY_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.SuspendLayout();
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
            this.btnAdd,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageUri.Uri = "Add";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xuất danh sách";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageUri.Uri = "ExportToXLSX";
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xuất danh sách";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageUri.Uri = "ExportToPDF";
            this.barButtonItem3.Name = "barButtonItem3";
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
            this.barDockControlTop.Size = new System.Drawing.Size(700, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 331);
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(700, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 307);
            // 
            // gridProduct
            // 
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.Location = new System.Drawing.Point(0, 24);
            this.gridProduct.MainView = this.gridView1;
            this.gridProduct.MenuManager = this.barManager1;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.gridProduct.Size = new System.Drawing.Size(700, 307);
            this.gridProduct.TabIndex = 4;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PRODUCT_CODE,
            this.PRODUCT_NAME,
            this.CATEGORY_NAME,
            this.UNIT,
            this.SELLING_PRICE,
            this.COST_PRICE,
            this.SALE_AMOUNT,
            this.DESCRIPTION,
            this.PRODUCER,
            this.ORIGIN,
            this.btnUpdate,
            this.btnDelete,
            this.PRODUCT_ID,
            this.CATEGORY_ID});
            this.gridView1.GridControl = this.gridProduct;
            this.gridView1.Name = "gridView1";
            // 
            // PRODUCT_CODE
            // 
            this.PRODUCT_CODE.Caption = "PRODUCT_CODE";
            this.PRODUCT_CODE.FieldName = "PRODUCT_CODE";
            this.PRODUCT_CODE.Name = "PRODUCT_CODE";
            this.PRODUCT_CODE.Visible = true;
            this.PRODUCT_CODE.VisibleIndex = 0;
            this.PRODUCT_CODE.Width = 56;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.Caption = "PRODUCT_NAME";
            this.PRODUCT_NAME.FieldName = "PRODUCT_NAME";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.Visible = true;
            this.PRODUCT_NAME.VisibleIndex = 1;
            this.PRODUCT_NAME.Width = 56;
            // 
            // CATEGORY_NAME
            // 
            this.CATEGORY_NAME.Caption = "CATEGORY_NAME";
            this.CATEGORY_NAME.FieldName = "CATEGORY_NAME";
            this.CATEGORY_NAME.Name = "CATEGORY_NAME";
            this.CATEGORY_NAME.Visible = true;
            this.CATEGORY_NAME.VisibleIndex = 2;
            this.CATEGORY_NAME.Width = 56;
            // 
            // UNIT
            // 
            this.UNIT.Caption = "UNIT";
            this.UNIT.FieldName = "UNIT";
            this.UNIT.Name = "UNIT";
            this.UNIT.Visible = true;
            this.UNIT.VisibleIndex = 3;
            this.UNIT.Width = 56;
            // 
            // SELLING_PRICE
            // 
            this.SELLING_PRICE.Caption = "SELLING_PRICE";
            this.SELLING_PRICE.FieldName = "SELLING_PRICE";
            this.SELLING_PRICE.Name = "SELLING_PRICE";
            this.SELLING_PRICE.Visible = true;
            this.SELLING_PRICE.VisibleIndex = 4;
            this.SELLING_PRICE.Width = 56;
            // 
            // COST_PRICE
            // 
            this.COST_PRICE.Caption = "COST_PRICE";
            this.COST_PRICE.FieldName = "COST_PRICE";
            this.COST_PRICE.Name = "COST_PRICE";
            this.COST_PRICE.Visible = true;
            this.COST_PRICE.VisibleIndex = 5;
            this.COST_PRICE.Width = 56;
            // 
            // SALE_AMOUNT
            // 
            this.SALE_AMOUNT.Caption = "SALE_AMOUNT";
            this.SALE_AMOUNT.FieldName = "SALE_AMOUNT";
            this.SALE_AMOUNT.Name = "SALE_AMOUNT";
            this.SALE_AMOUNT.Visible = true;
            this.SALE_AMOUNT.VisibleIndex = 6;
            this.SALE_AMOUNT.Width = 56;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Caption = "DESCRIPTION";
            this.DESCRIPTION.FieldName = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Visible = true;
            this.DESCRIPTION.VisibleIndex = 7;
            this.DESCRIPTION.Width = 56;
            // 
            // PRODUCER
            // 
            this.PRODUCER.Caption = "PRODUCER";
            this.PRODUCER.FieldName = "PRODUCER";
            this.PRODUCER.Name = "PRODUCER";
            this.PRODUCER.Visible = true;
            this.PRODUCER.VisibleIndex = 8;
            this.PRODUCER.Width = 56;
            // 
            // ORIGIN
            // 
            this.ORIGIN.Caption = "ORIGIN";
            this.ORIGIN.FieldName = "ORIGIN";
            this.ORIGIN.Name = "ORIGIN";
            this.ORIGIN.Visible = true;
            this.ORIGIN.VisibleIndex = 9;
            this.ORIGIN.Width = 56;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ColumnEdit = this.repositoryItemButtonEdit1;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Visible = true;
            this.btnUpdate.VisibleIndex = 10;
            this.btnUpdate.Width = 20;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // btnDelete
            // 
            this.btnDelete.ColumnEdit = this.repositoryItemButtonEdit2;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Visible = true;
            this.btnDelete.VisibleIndex = 11;
            this.btnDelete.Width = 20;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit2.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit2_ButtonClick);
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.Caption = "PRODUCT_ID";
            this.PRODUCT_ID.FieldName = "PRODUCT_ID";
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            // 
            // CATEGORY_ID
            // 
            this.CATEGORY_ID.Caption = "CATEGORY_ID";
            this.CATEGORY_ID.FieldName = "CATEGORY_ID";
            this.CATEGORY_ID.Name = "CATEGORY_ID";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 354);
            this.Controls.Add(this.gridProduct);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmProduct_Activated);
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn PRODUCT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn PRODUCT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn CATEGORY_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn SELLING_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn COST_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn SALE_AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn DESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn PRODUCER;
        private DevExpress.XtraGrid.Columns.GridColumn ORIGIN;
        private DevExpress.XtraGrid.Columns.GridColumn btnUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn PRODUCT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn CATEGORY_ID;
    }
}