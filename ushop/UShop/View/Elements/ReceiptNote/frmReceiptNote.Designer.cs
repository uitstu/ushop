namespace View.Elements.ReceiptNote
{
    partial class frmReceiptNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiptNote));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatDS = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridReceiptNote = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RN_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUPPLIER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISSUED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACCOUNTING_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACCOUNTED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditReceiptNote = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteReceiptNote = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceiptNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditReceiptNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteReceiptNote)).BeginInit();
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
            this.barButtonItem1,
            this.btnXuatDS});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuatDS, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm mới";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnXuatDS
            // 
            this.btnXuatDS.Caption = "Xuất danh sách";
            this.btnXuatDS.Id = 1;
            this.btnXuatDS.ImageUri.Uri = "ExportToXLSX";
            this.btnXuatDS.Name = "btnXuatDS";
            this.btnXuatDS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatDS_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(675, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 338);
            this.barDockControlBottom.Size = new System.Drawing.Size(675, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 314);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(675, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 314);
            // 
            // gridReceiptNote
            // 
            this.gridReceiptNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReceiptNote.Location = new System.Drawing.Point(0, 24);
            this.gridReceiptNote.MainView = this.gridView;
            this.gridReceiptNote.MenuManager = this.barManager1;
            this.gridReceiptNote.Name = "gridReceiptNote";
            this.gridReceiptNote.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditReceiptNote,
            this.btnDeleteReceiptNote});
            this.gridReceiptNote.Size = new System.Drawing.Size(675, 314);
            this.gridReceiptNote.TabIndex = 6;
            this.gridReceiptNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RN_CODE,
            this.SUPPLIER_NAME,
            this.EMP_NAME,
            this.ISSUED_DATE,
            this.ACCOUNTING_DATE,
            this.ACCOUNTED,
            this.TOTAL,
            this.NOTE,
            this.btnUPDATE,
            this.btnDELETE});
            this.gridView.GridControl = this.gridReceiptNote;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // RN_CODE
            // 
            this.RN_CODE.Caption = "RN_CODE";
            this.RN_CODE.FieldName = "RN_CODE";
            this.RN_CODE.Name = "RN_CODE";
            this.RN_CODE.OptionsColumn.AllowEdit = false;
            this.RN_CODE.Visible = true;
            this.RN_CODE.VisibleIndex = 0;
            this.RN_CODE.Width = 70;
            // 
            // SUPPLIER_NAME
            // 
            this.SUPPLIER_NAME.Caption = "SUPPLIER_NAME";
            this.SUPPLIER_NAME.FieldName = "SUPPLIER_NAME";
            this.SUPPLIER_NAME.Name = "SUPPLIER_NAME";
            this.SUPPLIER_NAME.OptionsColumn.AllowEdit = false;
            this.SUPPLIER_NAME.Visible = true;
            this.SUPPLIER_NAME.VisibleIndex = 1;
            this.SUPPLIER_NAME.Width = 70;
            // 
            // EMP_NAME
            // 
            this.EMP_NAME.Caption = "EMP_NAME";
            this.EMP_NAME.FieldName = "EMP_NAME";
            this.EMP_NAME.Name = "EMP_NAME";
            this.EMP_NAME.OptionsColumn.AllowEdit = false;
            this.EMP_NAME.Visible = true;
            this.EMP_NAME.VisibleIndex = 2;
            this.EMP_NAME.Width = 70;
            // 
            // ISSUED_DATE
            // 
            this.ISSUED_DATE.Caption = "ISSUED_DATE";
            this.ISSUED_DATE.FieldName = "ISSUED_DATE";
            this.ISSUED_DATE.Name = "ISSUED_DATE";
            this.ISSUED_DATE.OptionsColumn.AllowEdit = false;
            this.ISSUED_DATE.Visible = true;
            this.ISSUED_DATE.VisibleIndex = 3;
            this.ISSUED_DATE.Width = 70;
            // 
            // ACCOUNTING_DATE
            // 
            this.ACCOUNTING_DATE.Caption = "ACCOUNTING_DATE";
            this.ACCOUNTING_DATE.FieldName = "ACCOUNTING_DATE";
            this.ACCOUNTING_DATE.Name = "ACCOUNTING_DATE";
            this.ACCOUNTING_DATE.OptionsColumn.AllowEdit = false;
            this.ACCOUNTING_DATE.Visible = true;
            this.ACCOUNTING_DATE.VisibleIndex = 4;
            this.ACCOUNTING_DATE.Width = 70;
            // 
            // ACCOUNTED
            // 
            this.ACCOUNTED.Caption = "ACCOUNTED";
            this.ACCOUNTED.FieldName = "ACCOUNTED";
            this.ACCOUNTED.Name = "ACCOUNTED";
            this.ACCOUNTED.OptionsColumn.AllowEdit = false;
            this.ACCOUNTED.Visible = true;
            this.ACCOUNTED.VisibleIndex = 5;
            this.ACCOUNTED.Width = 70;
            // 
            // TOTAL
            // 
            this.TOTAL.Caption = "TOTAL";
            this.TOTAL.FieldName = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.OptionsColumn.AllowEdit = false;
            this.TOTAL.Visible = true;
            this.TOTAL.VisibleIndex = 6;
            this.TOTAL.Width = 70;
            // 
            // NOTE
            // 
            this.NOTE.Caption = "NOTE";
            this.NOTE.FieldName = "NOTE";
            this.NOTE.Name = "NOTE";
            this.NOTE.OptionsColumn.AllowEdit = false;
            this.NOTE.Visible = true;
            this.NOTE.VisibleIndex = 7;
            this.NOTE.Width = 70;
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ColumnEdit = this.btnEditReceiptNote;
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Visible = true;
            this.btnUPDATE.VisibleIndex = 8;
            this.btnUPDATE.Width = 20;
            // 
            // btnEditReceiptNote
            // 
            this.btnEditReceiptNote.AutoHeight = false;
            this.btnEditReceiptNote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEditReceiptNote.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnEditReceiptNote.Name = "btnEditReceiptNote";
            this.btnEditReceiptNote.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditReceiptNote.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditReceiptNote_ButtonClick);
            // 
            // btnDELETE
            // 
            this.btnDELETE.ColumnEdit = this.btnDeleteReceiptNote;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Visible = true;
            this.btnDELETE.VisibleIndex = 9;
            this.btnDELETE.Width = 20;
            // 
            // btnDeleteReceiptNote
            // 
            this.btnDeleteReceiptNote.AutoHeight = false;
            this.btnDeleteReceiptNote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDeleteReceiptNote.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDeleteReceiptNote.Name = "btnDeleteReceiptNote";
            this.btnDeleteReceiptNote.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteReceiptNote.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteReceiptNote_ButtonClick);
            // 
            // frmReceiptNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 361);
            this.Controls.Add(this.gridReceiptNote);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmReceiptNote";
            this.Text = "frmReceiptNote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmReceiptNote_Activated);
            this.Load += new System.EventHandler(this.frmReceiptNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceiptNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditReceiptNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteReceiptNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gridReceiptNote;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn RN_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn SUPPLIER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn EMP_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn ISSUED_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn ACCOUNTING_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn ACCOUNTED;
        private DevExpress.XtraGrid.Columns.GridColumn TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn NOTE;
        private DevExpress.XtraGrid.Columns.GridColumn btnUPDATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditReceiptNote;
        private DevExpress.XtraGrid.Columns.GridColumn btnDELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteReceiptNote;
        private DevExpress.XtraBars.BarButtonItem btnXuatDS;

    }
}