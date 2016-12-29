namespace View.Elements.Account
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbtniAMExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniAMAddAccount = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.grdconAMAccount = new DevExpress.XtraGrid.GridControl();
            this.gvAMAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnALUpdateAppointment = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDELETE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnALDeleteAppointment = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconAMAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAMAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnALUpdateAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnALDeleteAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(856, 30);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 428);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 458);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(856, 25);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(856, 30);
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
            // bbtniAMExport
            // 
            this.bbtniAMExport.Caption = "Xuất danh sách";
            this.bbtniAMExport.Id = 1;
            this.bbtniAMExport.ImageUri.Uri = "ExportToXLSX";
            this.bbtniAMExport.Name = "bbtniAMExport";
            // 
            // bbtniAMAddAccount
            // 
            this.bbtniAMAddAccount.Caption = "Thêm mới";
            this.bbtniAMAddAccount.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtniAMAddAccount.Glyph")));
            this.bbtniAMAddAccount.Id = 0;
            this.bbtniAMAddAccount.Name = "bbtniAMAddAccount";
            this.bbtniAMAddAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAMAddAccount_ItemClick_1);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAMAddAccount, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAMExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.bbtniAMAddAccount,
            this.bbtniAMExport});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 428);
            // 
            // grdconAMAccount
            // 
            this.grdconAMAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdconAMAccount.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdconAMAccount.Location = new System.Drawing.Point(0, 30);
            this.grdconAMAccount.MainView = this.gvAMAccount;
            this.grdconAMAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdconAMAccount.MenuManager = this.barManager1;
            this.grdconAMAccount.Name = "grdconAMAccount";
            this.grdconAMAccount.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnALUpdateAppointment,
            this.btnALDeleteAppointment});
            this.grdconAMAccount.Size = new System.Drawing.Size(856, 428);
            this.grdconAMAccount.TabIndex = 11;
            this.grdconAMAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAMAccount});
            // 
            // gvAMAccount
            // 
            this.gvAMAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn3,
            this.btnUPDATE,
            this.btnDELETE});
            this.gvAMAccount.GridControl = this.grdconAMAccount;
            this.gvAMAccount.Name = "gvAMAccount";
            this.gvAMAccount.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã nhân sự";
            this.gridColumn6.FieldName = "EMP_CODE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 165;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tên tài khoản";
            this.gridColumn5.FieldName = "ACC_CODE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 240;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mật khẩu";
            this.gridColumn4.FieldName = "PASSWORD";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 217;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cấp bậc";
            this.gridColumn3.FieldName = "POSITION";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 113;
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.ColumnEdit = this.btnALUpdateAppointment;
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Visible = true;
            this.btnUPDATE.VisibleIndex = 4;
            this.btnUPDATE.Width = 55;
            // 
            // btnALUpdateAppointment
            // 
            this.btnALUpdateAppointment.AutoHeight = false;
            this.btnALUpdateAppointment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnALUpdateAppointment.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnALUpdateAppointment.Name = "btnALUpdateAppointment";
            this.btnALUpdateAppointment.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnALUpdateAppointment.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAMUpdateAccount_ButtonClick);
            // 
            // btnDELETE
            // 
            this.btnDELETE.ColumnEdit = this.btnALDeleteAppointment;
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Visible = true;
            this.btnDELETE.VisibleIndex = 5;
            this.btnDELETE.Width = 46;
            // 
            // btnALDeleteAppointment
            // 
            this.btnALDeleteAppointment.AutoHeight = false;
            this.btnALDeleteAppointment.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnALDeleteAppointment.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnALDeleteAppointment.Name = "btnALDeleteAppointment";
            this.btnALDeleteAppointment.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnALDeleteAppointment.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAMDeleteAccount_ButtonClick);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 483);
            this.Controls.Add(this.grdconAMAccount);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAccount";
            this.Text = "Quản lý tài khoản";
            this.Activated += new System.EventHandler(this.frmAccount_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdconAMAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAMAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnALUpdateAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnALDeleteAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbtniAMExport;
        private DevExpress.XtraBars.BarButtonItem bbtniAMAddAccount;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraGrid.GridControl grdconAMAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAMAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn btnUPDATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnALUpdateAppointment;
        private DevExpress.XtraGrid.Columns.GridColumn btnDELETE;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnALDeleteAppointment;
    }
}