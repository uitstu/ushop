namespace View.Elements.Customer
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbtniCLExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniCLAddCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.btnCLDeleteCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCLUpdateCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnUPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvCLCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdconCLCustomer = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLDeleteCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLUpdateCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCLCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconCLCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(815, 30);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 488);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(815, 25);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(815, 30);
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
            // bbtniCLExport
            // 
            this.bbtniCLExport.Caption = "Xuất danh sách";
            this.bbtniCLExport.Id = 1;
            this.bbtniCLExport.ImageUri.Uri = "ExportToXLSX";
            this.bbtniCLExport.Name = "bbtniCLExport";
            // 
            // bbtniCLAddCustomer
            // 
            this.bbtniCLAddCustomer.Caption = "Thêm mới";
            this.bbtniCLAddCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtniCLAddCustomer.Glyph")));
            this.bbtniCLAddCustomer.Id = 0;
            this.bbtniCLAddCustomer.Name = "bbtniCLAddCustomer";
            this.bbtniCLAddCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniCLAddCustomer_ItemClick);
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
            this.bbtniCLAddCustomer,
            this.bbtniCLExport});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniCLAddCustomer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniCLExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // btnCLDeleteCustomer
            // 
            this.btnCLDeleteCustomer.AutoHeight = false;
            this.btnCLDeleteCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnCLDeleteCustomer.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnCLDeleteCustomer.Name = "btnCLDeleteCustomer";
            this.btnCLDeleteCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnCLDeleteCustomer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(btnCLDeleteCustomer_ButtonClick);
            // 
            // btnDELETE
            // 
            this.btnDELETE.ColumnEdit = this.btnCLDeleteCustomer;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Visible = true;
            this.btnDELETE.VisibleIndex = 6;
            this.btnDELETE.Width = 48;
            // 
            // btnCLUpdateCustomer
            // 
            this.btnCLUpdateCustomer.AutoHeight = false;
            this.btnCLUpdateCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnCLUpdateCustomer.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnCLUpdateCustomer.Name = "btnCLUpdateCustomer";
            this.btnCLUpdateCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnCLUpdateCustomer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(btnCLUpdateCustomer_ButtonClick);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ColumnEdit = this.btnCLUpdateCustomer;
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Visible = true;
            this.btnUPDATE.VisibleIndex = 5;
            this.btnUPDATE.Width = 33;
            // 
            // gvCLCustomer
            // 
            this.gvCLCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn2,
            this.btnUPDATE,
            this.btnDELETE});
            this.gvCLCustomer.GridControl = this.grdconCLCustomer;
            this.gvCLCustomer.Name = "gvCLCustomer";
            this.gvCLCustomer.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã Khách hàng";
            this.gridColumn6.FieldName = "CUS_CODE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên Khách hàng";
            this.gridColumn5.FieldName = "CUS_NAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa chỉ";
            this.gridColumn4.FieldName = "ADDRESS";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "SDT";
            this.gridColumn3.FieldName = "PHONE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Đã mua";
            this.gridColumn2.FieldName = "BOUGHT_AMOUNT";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            // 
            // grdconCLCustomer
            // 
            this.grdconCLCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdconCLCustomer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdconCLCustomer.Location = new System.Drawing.Point(0, 30);
            this.grdconCLCustomer.MainView = this.gvCLCustomer;
            this.grdconCLCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdconCLCustomer.MenuManager = this.barManager1;
            this.grdconCLCustomer.Name = "grdconCLCustomer";
            this.grdconCLCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnCLUpdateCustomer,
            this.btnCLDeleteCustomer});
            this.grdconCLCustomer.Size = new System.Drawing.Size(815, 458);
            this.grdconCLCustomer.TabIndex = 9;
            this.grdconCLCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCLCustomer});
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 513);
            this.Controls.Add(this.grdconCLCustomer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Activated += new System.EventHandler(this.frmCustomer_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLDeleteCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCLUpdateCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCLCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconCLCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbtniCLExport;
        private DevExpress.XtraBars.BarButtonItem bbtniCLAddCustomer;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraGrid.GridControl grdconCLCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCLCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn btnUPDATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnCLUpdateCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn btnDELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnCLDeleteCustomer;
    }
}