namespace View.Elements.Account
{
    partial class frmEditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAccount));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnAIDeleteItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txteEACPassword = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barAAOptions = new DevExpress.XtraBars.Bar();
            this.bbtniEABack = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniEAAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbtniAAPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniEAReset = new DevExpress.XtraBars.BarButtonItem();
            this.bsiAIState = new DevExpress.XtraBars.BarStaticItem();
            this.txteEAAccountCode = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tboxAgainPassword = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txteEAEmployeeCodeName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEACPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEAAccountCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxAgainPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEAEmployeeCodeName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAIDeleteItem
            // 
            this.btnAIDeleteItem.AutoHeight = false;
            this.btnAIDeleteItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnAIDeleteItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnAIDeleteItem.Name = "btnAIDeleteItem";
            this.btnAIDeleteItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // txteEACPassword
            // 
            this.txteEACPassword.Location = new System.Drawing.Point(108, 125);
            this.txteEACPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txteEACPassword.MenuManager = this.barManager1;
            this.txteEACPassword.Name = "txteEACPassword";
            this.txteEACPassword.Properties.PasswordChar = '*';
            this.txteEACPassword.Size = new System.Drawing.Size(180, 20);
            this.txteEACPassword.TabIndex = 51;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barAAOptions});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtniEAAdd,
            this.bbtniAAPrint,
            this.bbtniEAReset,
            this.bbtniEABack,
            this.bsiAIState,
            this.btnDelete});
            this.barManager1.MainMenu = this.barAAOptions;
            this.barManager1.MaxItemId = 6;
            // 
            // barAAOptions
            // 
            this.barAAOptions.BarName = "Main menu";
            this.barAAOptions.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barAAOptions.DockCol = 0;
            this.barAAOptions.DockRow = 0;
            this.barAAOptions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barAAOptions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniEABack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniEAAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barAAOptions.OptionsBar.AllowQuickCustomization = false;
            this.barAAOptions.OptionsBar.MultiLine = true;
            this.barAAOptions.OptionsBar.UseWholeRow = true;
            this.barAAOptions.Text = "Main menu";
            // 
            // bbtniEABack
            // 
            this.bbtniEABack.Caption = "Quay về";
            this.bbtniEABack.Id = 3;
            this.bbtniEABack.ImageUri.Uri = "Undo";
            this.bbtniEABack.Name = "bbtniEABack";
            this.bbtniEABack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniEABack_ItemClick);
            // 
            // bbtniEAAdd
            // 
            this.bbtniEAAdd.Caption = "Lưu";
            this.bbtniEAAdd.Id = 0;
            this.bbtniEAAdd.ImageUri.Uri = "Apply";
            this.bbtniEAAdd.Name = "bbtniEAAdd";
            this.bbtniEAAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniEAAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 5;
            this.btnDelete.ImageUri.Uri = "Cancel";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(333, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 205);
            this.barDockControlBottom.Size = new System.Drawing.Size(333, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 181);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(333, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 181);
            // 
            // bbtniAAPrint
            // 
            this.bbtniAAPrint.Caption = "In";
            this.bbtniAAPrint.Id = 1;
            this.bbtniAAPrint.ImageUri.Uri = "Print";
            this.bbtniAAPrint.Name = "bbtniAAPrint";
            // 
            // bbtniEAReset
            // 
            this.bbtniEAReset.Caption = "Xóa";
            this.bbtniEAReset.Id = 2;
            this.bbtniEAReset.ImageUri.Uri = "Cancel";
            this.bbtniEAReset.Name = "bbtniEAReset";
            // 
            // bsiAIState
            // 
            this.bsiAIState.Caption = "State";
            this.bsiAIState.Id = 4;
            this.bsiAIState.Name = "bsiAIState";
            this.bsiAIState.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txteEAAccountCode
            // 
            this.txteEAAccountCode.Location = new System.Drawing.Point(108, 61);
            this.txteEAAccountCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txteEAAccountCode.MenuManager = this.barManager1;
            this.txteEAAccountCode.Name = "txteEAAccountCode";
            this.txteEAAccountCode.Properties.ReadOnly = true;
            this.txteEAAccountCode.Size = new System.Drawing.Size(180, 20);
            this.txteEAAccountCode.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tài khoản:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tboxAgainPassword);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.tboxOldPassword);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txteEAEmployeeCodeName);
            this.groupControl1.Controls.Add(this.txteEACPassword);
            this.groupControl1.Controls.Add(this.txteEAAccountCode);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(333, 181);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Thông tin Tài khoản";
            // 
            // tboxAgainPassword
            // 
            this.tboxAgainPassword.Location = new System.Drawing.Point(108, 149);
            this.tboxAgainPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxAgainPassword.MenuManager = this.barManager1;
            this.tboxAgainPassword.Name = "tboxAgainPassword";
            this.tboxAgainPassword.Properties.PasswordChar = '*';
            this.tboxAgainPassword.Size = new System.Drawing.Size(180, 20);
            this.tboxAgainPassword.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nhập lại:";
            // 
            // tboxOldPassword
            // 
            this.tboxOldPassword.EditValue = "";
            this.tboxOldPassword.Location = new System.Drawing.Point(108, 96);
            this.tboxOldPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxOldPassword.MenuManager = this.barManager1;
            this.tboxOldPassword.Name = "tboxOldPassword";
            this.tboxOldPassword.Properties.PasswordChar = '*';
            this.tboxOldPassword.Size = new System.Drawing.Size(180, 20);
            this.tboxOldPassword.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // txteEAEmployeeCodeName
            // 
            this.txteEAEmployeeCodeName.Location = new System.Drawing.Point(108, 29);
            this.txteEAEmployeeCodeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txteEAEmployeeCodeName.MenuManager = this.barManager1;
            this.txteEAEmployeeCodeName.Name = "txteEAEmployeeCodeName";
            this.txteEAEmployeeCodeName.Properties.ReadOnly = true;
            this.txteEAEmployeeCodeName.Size = new System.Drawing.Size(180, 20);
            this.txteEAEmployeeCodeName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // frmEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 205);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditAccount";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEACPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEAAccountCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxAgainPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEAEmployeeCodeName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAIDeleteItem;
        private DevExpress.XtraEditors.TextEdit txteEACPassword;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barAAOptions;
        private DevExpress.XtraBars.BarButtonItem bbtniEABack;
        private DevExpress.XtraBars.BarButtonItem bbtniEAAdd;
        private DevExpress.XtraBars.BarButtonItem bbtniAAPrint;
        private DevExpress.XtraBars.BarButtonItem bbtniEAReset;
        private DevExpress.XtraBars.BarStaticItem bsiAIState;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txteEAEmployeeCodeName;
        private DevExpress.XtraEditors.TextEdit txteEAAccountCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit tboxAgainPassword;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit tboxOldPassword;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
    }
}