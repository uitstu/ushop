namespace View.Elements.Appointment
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gvALAppointment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnALUpdateAppointment = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnALDeleteAppointment = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grdconALAppointment = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtniALAddAppointment = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintPDF = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvALAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnALUpdateAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnALDeleteAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconALAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvALAppointment
            // 
            this.gvALAppointment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn6,
            this.btnUPDATE,
            this.btnDELETE});
            this.gvALAppointment.GridControl = this.grdconALAppointment;
            this.gvALAppointment.Name = "gvALAppointment";
            this.gvALAppointment.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã phiếu hẹn";
            this.gridColumn7.FieldName = "APP_CODE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên Khách hàng";
            this.gridColumn4.FieldName = "CUS_NAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhân viên lập";
            this.gridColumn3.FieldName = "EMP_NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày lập";
            this.gridColumn2.FieldName = "CREATED_DATE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngày trả";
            this.gridColumn1.FieldName = "APP_DATE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nội dung";
            this.gridColumn5.FieldName = "DESCRIPTION";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tình trạng";
            this.gridColumn6.FieldName = "NOTE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ColumnEdit = this.btnALUpdateAppointment;
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Visible = true;
            this.btnUPDATE.VisibleIndex = 7;
            this.btnUPDATE.Width = 20;
            // 
            // btnALUpdateAppointment
            // 
            this.btnALUpdateAppointment.AutoHeight = false;
            this.btnALUpdateAppointment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnALUpdateAppointment.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.btnALUpdateAppointment.Name = "btnALUpdateAppointment";
            this.btnALUpdateAppointment.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnALUpdateAppointment.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnALUpdateAppointment_ButtonClick);
            // 
            // btnDELETE
            // 
            this.btnDELETE.ColumnEdit = this.btnALDeleteAppointment;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Visible = true;
            this.btnDELETE.VisibleIndex = 8;
            this.btnDELETE.Width = 20;
            // 
            // btnALDeleteAppointment
            // 
            this.btnALDeleteAppointment.AutoHeight = false;
            this.btnALDeleteAppointment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnALDeleteAppointment.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.btnALDeleteAppointment.Name = "btnALDeleteAppointment";
            this.btnALDeleteAppointment.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnALDeleteAppointment.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnALDeleteAppointment_ButtonClick);
            // 
            // grdconALAppointment
            // 
            this.grdconALAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdconALAppointment.Location = new System.Drawing.Point(0, 24);
            this.grdconALAppointment.MainView = this.gvALAppointment;
            this.grdconALAppointment.MenuManager = this.barManager1;
            this.grdconALAppointment.Name = "grdconALAppointment";
            this.grdconALAppointment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnALUpdateAppointment,
            this.btnALDeleteAppointment});
            this.grdconALAppointment.Size = new System.Drawing.Size(658, 440);
            this.grdconALAppointment.TabIndex = 10;
            this.grdconALAppointment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvALAppointment});
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
            this.bbtniALAddAppointment,
            this.btnPrintExcel,
            this.btnPrintPDF});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniALAddAppointment, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintPDF, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtniALAddAppointment
            // 
            this.bbtniALAddAppointment.Caption = "Thêm mới";
            this.bbtniALAddAppointment.Id = 0;
            this.bbtniALAddAppointment.ImageUri.Uri = "Add";
            this.bbtniALAddAppointment.Name = "bbtniALAddAppointment";
            this.bbtniALAddAppointment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniALAddAppointment_ItemClick_1);
            // 
            // btnPrintExcel
            // 
            this.btnPrintExcel.Caption = "Xuất danh sách";
            this.btnPrintExcel.Id = 1;
            this.btnPrintExcel.ImageUri.Uri = "ExportToXLSX";
            this.btnPrintExcel.Name = "btnPrintExcel";
            this.btnPrintExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintExcel_ItemClick);
            // 
            // btnPrintPDF
            // 
            this.btnPrintPDF.Caption = "Xuất danh sách";
            this.btnPrintPDF.Id = 2;
            this.btnPrintPDF.ImageUri.Uri = "ExportToPDF";
            this.btnPrintPDF.Name = "btnPrintPDF";
            this.btnPrintPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintPDF_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(658, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 464);
            this.barDockControlBottom.Size = new System.Drawing.Size(658, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 440);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(658, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 440);
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 464);
            this.Controls.Add(this.grdconALAppointment);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAppointment";
            this.Text = "Quản lý phiếu hẹn";
            this.Activated += new System.EventHandler(this.frmAppointment_Activated_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvALAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnALUpdateAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnALDeleteAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconALAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvALAppointment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn btnUPDATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnALUpdateAppointment;
        private DevExpress.XtraGrid.Columns.GridColumn btnDELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnALDeleteAppointment;
        private DevExpress.XtraGrid.GridControl grdconALAppointment;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbtniALAddAppointment;
        private DevExpress.XtraBars.BarButtonItem btnPrintExcel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnPrintPDF;
    }
}