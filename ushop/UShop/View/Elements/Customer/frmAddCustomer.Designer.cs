namespace View.Elements.Customer
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barAIOptions = new DevExpress.XtraBars.Bar();
            this.bbtniACBack = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniACAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniACReset = new DevExpress.XtraBars.BarButtonItem();
            this.bsiAIState = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbtniACPrint = new DevExpress.XtraBars.BarButtonItem();
            this.txteACPhone = new DevExpress.XtraEditors.TextEdit();
            this.txteACAddress = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txteACCusName = new DevExpress.XtraEditors.TextEdit();
            this.txteACCusCode = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txteACBoughtAmount = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAIDeleteItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteACPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteACAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteACCusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteACCusCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteACBoughtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barAIOptions});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtniACAdd,
            this.bbtniACPrint,
            this.bbtniACReset,
            this.bbtniACBack,
            this.bsiAIState});
            this.barManager1.MainMenu = this.barAIOptions;
            this.barManager1.MaxItemId = 5;
            // 
            // barAIOptions
            // 
            this.barAIOptions.BarName = "Main menu";
            this.barAIOptions.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barAIOptions.DockCol = 0;
            this.barAIOptions.DockRow = 0;
            this.barAIOptions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barAIOptions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniACBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniACAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniACReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barAIOptions.OptionsBar.AllowQuickCustomization = false;
            this.barAIOptions.OptionsBar.MultiLine = true;
            this.barAIOptions.OptionsBar.UseWholeRow = true;
            this.barAIOptions.Text = "Main menu";
            // 
            // bbtniACBack
            // 
            this.bbtniACBack.Caption = "Quay về";
            this.bbtniACBack.Id = 3;
            this.bbtniACBack.ImageUri.Uri = "Undo";
            this.bbtniACBack.Name = "bbtniACBack";
            this.bbtniACBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniACBack_ItemClick_1);
            // 
            // bbtniACAdd
            // 
            this.bbtniACAdd.Caption = "Lưu";
            this.bbtniACAdd.Id = 0;
            this.bbtniACAdd.ImageUri.Uri = "Apply";
            this.bbtniACAdd.Name = "bbtniACAdd";
            this.bbtniACAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniACAdd_ItemClick_1);
            // 
            // bbtniACReset
            // 
            this.bbtniACReset.Caption = "Xóa";
            this.bbtniACReset.Id = 2;
            this.bbtniACReset.ImageUri.Uri = "Cancel";
            this.bbtniACReset.Name = "bbtniACReset";
            this.bbtniACReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniACReset_ItemClick_1);
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
            this.barDockControlTop.Size = new System.Drawing.Size(773, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 264);
            this.barDockControlBottom.Size = new System.Drawing.Size(773, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 240);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(773, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 240);
            // 
            // bbtniACPrint
            // 
            this.bbtniACPrint.Caption = "In";
            this.bbtniACPrint.Id = 1;
            this.bbtniACPrint.ImageUri.Uri = "Print";
            this.bbtniACPrint.Name = "bbtniACPrint";
            // 
            // txteACPhone
            // 
            this.txteACPhone.Location = new System.Drawing.Point(108, 162);
            this.txteACPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txteACPhone.MenuManager = this.barManager1;
            this.txteACPhone.Name = "txteACPhone";
            this.txteACPhone.Size = new System.Drawing.Size(195, 20);
            this.txteACPhone.TabIndex = 37;
            // 
            // txteACAddress
            // 
            this.txteACAddress.Location = new System.Drawing.Point(108, 129);
            this.txteACAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txteACAddress.MenuManager = this.barManager1;
            this.txteACAddress.Name = "txteACAddress";
            this.txteACAddress.Size = new System.Drawing.Size(195, 20);
            this.txteACAddress.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Địa chỉ:";
            // 
            // txteACCusName
            // 
            this.txteACCusName.Location = new System.Drawing.Point(108, 96);
            this.txteACCusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txteACCusName.MenuManager = this.barManager1;
            this.txteACCusName.Name = "txteACCusName";
            this.txteACCusName.Size = new System.Drawing.Size(195, 20);
            this.txteACCusName.TabIndex = 30;
            // 
            // txteACCusCode
            // 
            this.txteACCusCode.Location = new System.Drawing.Point(108, 29);
            this.txteACCusCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txteACCusCode.MenuManager = this.barManager1;
            this.txteACCusCode.Name = "txteACCusCode";
            this.txteACCusCode.Properties.ReadOnly = true;
            this.txteACCusCode.Size = new System.Drawing.Size(195, 20);
            this.txteACCusCode.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "SĐT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã khách hàng:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txteACBoughtAmount);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txteACPhone);
            this.groupControl1.Controls.Add(this.txteACAddress);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txteACCusName);
            this.groupControl1.Controls.Add(this.txteACCusCode);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(773, 240);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông tin khách hàng";
            // 
            // txteACBoughtAmount
            // 
            this.txteACBoughtAmount.Location = new System.Drawing.Point(108, 63);
            this.txteACBoughtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txteACBoughtAmount.MenuManager = this.barManager1;
            this.txteACBoughtAmount.Name = "txteACBoughtAmount";
            this.txteACBoughtAmount.Properties.ReadOnly = true;
            this.txteACBoughtAmount.Size = new System.Drawing.Size(195, 20);
            this.txteACBoughtAmount.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Đã mua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Họ tên:";
            // 
            // btnAIDeleteItem
            // 
            this.btnAIDeleteItem.AutoHeight = false;
            this.btnAIDeleteItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnAIDeleteItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnAIDeleteItem.Name = "btnAIDeleteItem";
            this.btnAIDeleteItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 264);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddCustomer";
            this.Text = "Khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteACPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteACAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteACCusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteACCusCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteACBoughtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barAIOptions;
        private DevExpress.XtraBars.BarButtonItem bbtniACBack;
        private DevExpress.XtraBars.BarButtonItem bbtniACAdd;
        private DevExpress.XtraBars.BarButtonItem bbtniACPrint;
        private DevExpress.XtraBars.BarButtonItem bbtniACReset;
        private DevExpress.XtraBars.BarStaticItem bsiAIState;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txteACBoughtAmount;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txteACPhone;
        private DevExpress.XtraEditors.TextEdit txteACAddress;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txteACCusName;
        private DevExpress.XtraEditors.TextEdit txteACCusCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAIDeleteItem;
    }
}