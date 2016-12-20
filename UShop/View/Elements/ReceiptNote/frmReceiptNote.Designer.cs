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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridReceiptNote = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RN_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUPPLIER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISSUED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACCOUNTING_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACCOUNTED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceiptNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm mới";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(675, 22);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 316);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(675, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 316);
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 22);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(675, 107);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridReceiptNote
            // 
            this.gridReceiptNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReceiptNote.Location = new System.Drawing.Point(0, 129);
            this.gridReceiptNote.MainView = this.gridView1;
            this.gridReceiptNote.MenuManager = this.barManager1;
            this.gridReceiptNote.Name = "gridReceiptNote";
            this.gridReceiptNote.Size = new System.Drawing.Size(675, 209);
            this.gridReceiptNote.TabIndex = 6;
            this.gridReceiptNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RN_CODE,
            this.SUPPLIER_NAME,
            this.EMP_NAME,
            this.ISSUED_DATE,
            this.ACCOUNTING_DATE,
            this.ACCOUNTED,
            this.TOTAL,
            this.NOTE});
            this.gridView1.GridControl = this.gridReceiptNote;
            this.gridView1.Name = "gridView1";
            // 
            // RN_CODE
            // 
            this.RN_CODE.Caption = "RN_CODE";
            this.RN_CODE.FieldName = "RN_CODE";
            this.RN_CODE.Name = "RN_CODE";
            this.RN_CODE.Visible = true;
            this.RN_CODE.VisibleIndex = 0;
            // 
            // SUPPLIER_NAME
            // 
            this.SUPPLIER_NAME.Caption = "SUPPLIER_NAME";
            this.SUPPLIER_NAME.FieldName = "SUPPLIER_NAME";
            this.SUPPLIER_NAME.Name = "SUPPLIER_NAME";
            this.SUPPLIER_NAME.Visible = true;
            this.SUPPLIER_NAME.VisibleIndex = 1;
            // 
            // EMP_NAME
            // 
            this.EMP_NAME.Caption = "EMP_NAME";
            this.EMP_NAME.FieldName = "EMP_NAME";
            this.EMP_NAME.Name = "EMP_NAME";
            this.EMP_NAME.Visible = true;
            this.EMP_NAME.VisibleIndex = 2;
            // 
            // ISSUED_DATE
            // 
            this.ISSUED_DATE.Caption = "ISSUED_DATE";
            this.ISSUED_DATE.FieldName = "ISSUED_DATE";
            this.ISSUED_DATE.Name = "ISSUED_DATE";
            this.ISSUED_DATE.Visible = true;
            this.ISSUED_DATE.VisibleIndex = 3;
            // 
            // ACCOUNTING_DATE
            // 
            this.ACCOUNTING_DATE.Caption = "ACCOUNTING_DATE";
            this.ACCOUNTING_DATE.FieldName = "ACCOUNTING_DATE";
            this.ACCOUNTING_DATE.Name = "ACCOUNTING_DATE";
            this.ACCOUNTING_DATE.Visible = true;
            this.ACCOUNTING_DATE.VisibleIndex = 4;
            // 
            // ACCOUNTED
            // 
            this.ACCOUNTED.Caption = "ACCOUNTED";
            this.ACCOUNTED.FieldName = "ACCOUNTED";
            this.ACCOUNTED.Name = "ACCOUNTED";
            this.ACCOUNTED.Visible = true;
            this.ACCOUNTED.VisibleIndex = 5;
            // 
            // TOTAL
            // 
            this.TOTAL.Caption = "TOTAL";
            this.TOTAL.FieldName = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Visible = true;
            this.TOTAL.VisibleIndex = 6;
            // 
            // NOTE
            // 
            this.NOTE.Caption = "NOTE";
            this.NOTE.FieldName = "NOTE";
            this.NOTE.Name = "NOTE";
            this.NOTE.Visible = true;
            this.NOTE.VisibleIndex = 7;
            // 
            // frmReceiptNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 361);
            this.Controls.Add(this.gridReceiptNote);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmReceiptNote";
            this.Text = "frmReceiptNote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReceiptNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceiptNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridReceiptNote;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn RN_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn SUPPLIER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn EMP_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn ISSUED_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn ACCOUNTING_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn ACCOUNTED;
        private DevExpress.XtraGrid.Columns.GridColumn TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn NOTE;

    }
}