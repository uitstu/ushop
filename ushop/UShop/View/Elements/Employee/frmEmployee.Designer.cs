using System;
using DevExpress.XtraEditors.Controls;

namespace View.Elements.Employee
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gvELEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnELUpdateInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnELDeleteInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grdconELEmployee = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtniELAddInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniELExport = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gvELEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnELUpdateInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnELDeleteInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconELEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvELEmployee
            // 
            this.gvELEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.btnUPDATE,
            this.btnDELETE});
            this.gvELEmployee.GridControl = this.grdconELEmployee;
            this.gvELEmployee.Name = "gvELEmployee";
            this.gvELEmployee.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân sự";
            this.gridColumn1.FieldName = "EMP_CODE";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 83;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ tên";
            this.gridColumn2.FieldName = "EMP_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 73;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giới tính";
            this.gridColumn3.FieldName = "GENDER";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 48;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày sinh";
            this.gridColumn4.FieldName = "BIRTHDAY";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 69;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "CMND";
            this.gridColumn5.FieldName = "ID_CARD_NO";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            this.gridColumn5.Width = 55;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Địa chỉ";
            this.gridColumn6.FieldName = "ADDRESS";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 71;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "SDT";
            this.gridColumn7.FieldName = "PHONE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 63;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ngày vào làm";
            this.gridColumn8.FieldName = "APPROVE_DATE";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            this.gridColumn8.Width = 112;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tình trạng";
            this.gridColumn9.FieldName = "WORK_STATUS";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 86;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ngày nghỉ việc";
            this.gridColumn10.FieldName = "SEV_DATE";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Vị trí";
            this.gridColumn11.FieldName = "POSITION";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 46;
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ColumnEdit = this.btnELUpdateInvoice;
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Visible = true;
            this.btnUPDATE.VisibleIndex = 10;
            this.btnUPDATE.Width = 33;
            // 
            // btnELUpdateInvoice
            // 
            this.btnELUpdateInvoice.AutoHeight = false;
            this.btnELUpdateInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnELUpdateInvoice.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.btnELUpdateInvoice.Name = "btnELUpdateInvoice";
            this.btnELUpdateInvoice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnELUpdateInvoice.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnELUpdateEmployee_ButtonClick);
            // 
            // btnDELETE
            // 
            this.btnDELETE.ColumnEdit = this.btnELDeleteInvoice;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Visible = true;
            this.btnDELETE.VisibleIndex = 11;
            this.btnDELETE.Width = 48;
            // 
            // btnELDeleteInvoice
            // 
            this.btnELDeleteInvoice.AutoHeight = false;
            this.btnELDeleteInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnELDeleteInvoice.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.btnELDeleteInvoice.Name = "btnELDeleteInvoice";
            this.btnELDeleteInvoice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnELDeleteInvoice.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnELDeleteInvoice_ButtonClick);
            // 
            // grdconELEmployee
            // 
            this.grdconELEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdconELEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdconELEmployee.Location = new System.Drawing.Point(0, 30);
            this.grdconELEmployee.MainView = this.gvELEmployee;
            this.grdconELEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdconELEmployee.MenuManager = this.barManager1;
            this.grdconELEmployee.Name = "grdconELEmployee";
            this.grdconELEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnELUpdateInvoice,
            this.btnELDeleteInvoice});
            this.grdconELEmployee.Size = new System.Drawing.Size(807, 320);
            this.grdconELEmployee.TabIndex = 8;
            this.grdconELEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvELEmployee});
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
            this.bbtniELAddInvoice,
            this.bbtniELExport});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniELAddInvoice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniELExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtniELAddInvoice
            // 
            this.bbtniELAddInvoice.Caption = "Thêm mới";
            this.bbtniELAddInvoice.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtniELAddInvoice.Glyph")));
            this.bbtniELAddInvoice.Id = 0;
            this.bbtniELAddInvoice.Name = "bbtniELAddInvoice";
            this.bbtniELAddInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniELAddEmployee_ItemClick);
            // 
            // bbtniELExport
            // 
            this.bbtniELExport.Caption = "Xuất danh sách";
            this.bbtniELExport.Id = 1;
            this.bbtniELExport.ImageUri.Uri = "ExportToXLSX";
            this.bbtniELExport.Name = "bbtniELExport";
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
            this.barDockControlTop.Size = new System.Drawing.Size(807, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 350);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(807, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 320);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(807, 30);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 320);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 375);
            this.Controls.Add(this.grdconELEmployee);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Activated += new System.EventHandler(this.frmEmployee_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gvELEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnELUpdateInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnELDeleteInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconELEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        


        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvELEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn btnUPDATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnELUpdateInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn btnDELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnELDeleteInvoice;
        private DevExpress.XtraGrid.GridControl grdconELEmployee;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbtniELAddInvoice;
        private DevExpress.XtraBars.BarButtonItem bbtniELExport;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}