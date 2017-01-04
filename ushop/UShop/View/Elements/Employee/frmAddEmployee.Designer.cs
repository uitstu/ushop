namespace View.Elements.Employee
{
    partial class frmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barAIOptions = new DevExpress.XtraBars.Bar();
            this.bbtniAEBack = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniAEAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniAEReset = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbtniAEPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bsiAIState = new DevExpress.XtraBars.BarStaticItem();
            this.btnAIDeleteItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dpickAEBirthday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txteAEEmpCode = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbAEPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dpkAESevDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAEWorkStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dpkAEApproveDate = new System.Windows.Forms.DateTimePicker();
            this.txteAEPhone = new DevExpress.XtraEditors.TextEdit();
            this.txteAEAddress = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txteAEIDNo = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAEGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txteAEEmpName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAEPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAEWorkStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEIDNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAEGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEEmpName.Properties)).BeginInit();
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
            this.bbtniAEAdd,
            this.bbtniAEPrint,
            this.bbtniAEReset,
            this.bbtniAEBack,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAEBack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAEAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAEReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barAIOptions.OptionsBar.AllowQuickCustomization = false;
            this.barAIOptions.OptionsBar.MultiLine = true;
            this.barAIOptions.OptionsBar.UseWholeRow = true;
            this.barAIOptions.Text = "Main menu";
            // 
            // bbtniAEBack
            // 
            this.bbtniAEBack.Caption = "Quay về";
            this.bbtniAEBack.Id = 3;
            this.bbtniAEBack.ImageUri.Uri = "Undo";
            this.bbtniAEBack.Name = "bbtniAEBack";
            this.bbtniAEBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAEBack_ItemClick);
            // 
            // bbtniAEAdd
            // 
            this.bbtniAEAdd.Caption = "Lưu";
            this.bbtniAEAdd.Id = 0;
            this.bbtniAEAdd.ImageUri.Uri = "Apply";
            this.bbtniAEAdd.Name = "bbtniAEAdd";
            this.bbtniAEAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAEAdd_ItemClick);
            // 
            // bbtniAEReset
            // 
            this.bbtniAEReset.Caption = "Xóa";
            this.bbtniAEReset.Id = 2;
            this.bbtniAEReset.ImageUri.Uri = "Cancel";
            this.bbtniAEReset.Name = "bbtniAEReset";
            this.bbtniAEReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAEReset_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlTop.Size = new System.Drawing.Size(1744, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 704);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlBottom.Size = new System.Drawing.Size(1744, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 646);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1744, 58);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 646);
            // 
            // bbtniAEPrint
            // 
            this.bbtniAEPrint.Caption = "In";
            this.bbtniAEPrint.Id = 1;
            this.bbtniAEPrint.ImageUri.Uri = "Print";
            this.bbtniAEPrint.Name = "bbtniAEPrint";
            // 
            // bsiAIState
            // 
            this.bsiAIState.Caption = "State";
            this.bsiAIState.Id = 4;
            this.bsiAIState.Name = "bsiAIState";
            this.bsiAIState.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnAIDeleteItem
            // 
            this.btnAIDeleteItem.AutoHeight = false;
            this.btnAIDeleteItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnAIDeleteItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnAIDeleteItem.Name = "btnAIDeleteItem";
            this.btnAIDeleteItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // dpickAEBirthday
            // 
            this.dpickAEBirthday.CustomFormat = "dd/MM/yyyy";
            this.dpickAEBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpickAEBirthday.Location = new System.Drawing.Point(264, 315);
            this.dpickAEBirthday.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dpickAEBirthday.Name = "dpickAEBirthday";
            this.dpickAEBirthday.Size = new System.Drawing.Size(516, 40);
            this.dpickAEBirthday.TabIndex = 0;
            this.dpickAEBirthday.ValueChanged += new System.EventHandler(this.dpickAEBirthday_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Giới tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 34);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã nhân sự:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(936, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 34);
            this.label4.TabIndex = 27;
            this.label4.Text = "SĐT:";
            // 
            // txteAEEmpCode
            // 
            this.txteAEEmpCode.Location = new System.Drawing.Point(264, 71);
            this.txteAEEmpCode.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txteAEEmpCode.MenuManager = this.barManager1;
            this.txteAEEmpCode.Name = "txteAEEmpCode";
            this.txteAEEmpCode.Properties.ReadOnly = true;
            this.txteAEEmpCode.Size = new System.Drawing.Size(520, 40);
            this.txteAEEmpCode.TabIndex = 28;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbAEPosition);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.dpkAESevDate);
            this.groupControl1.Controls.Add(this.cmbAEWorkStatus);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.dpkAEApproveDate);
            this.groupControl1.Controls.Add(this.txteAEPhone);
            this.groupControl1.Controls.Add(this.txteAEAddress);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txteAEIDNo);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.cmbAEGender);
            this.groupControl1.Controls.Add(this.txteAEEmpName);
            this.groupControl1.Controls.Add(this.txteAEEmpCode);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dpickAEBirthday);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 58);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1744, 646);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Thông tin nhân sự";
            // 
            // cmbAEPosition
            // 
            this.cmbAEPosition.Location = new System.Drawing.Point(264, 482);
            this.cmbAEPosition.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbAEPosition.MenuManager = this.barManager1;
            this.cmbAEPosition.Name = "cmbAEPosition";
            this.cmbAEPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAEPosition.Size = new System.Drawing.Size(520, 42);
            this.cmbAEPosition.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 487);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 34);
            this.label1.TabIndex = 44;
            this.label1.Text = "Vị trí:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(936, 487);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 34);
            this.label11.TabIndex = 43;
            this.label11.Text = "Ngày nghỉ việc:";
            // 
            // dpkAESevDate
            // 
            this.dpkAESevDate.CustomFormat = "dd/MM/yyyy";
            this.dpkAESevDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkAESevDate.Location = new System.Drawing.Point(1184, 478);
            this.dpkAESevDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dpkAESevDate.Name = "dpkAESevDate";
            this.dpkAESevDate.Size = new System.Drawing.Size(516, 40);
            this.dpkAESevDate.TabIndex = 42;
            this.dpkAESevDate.ValueChanged += new System.EventHandler(this.dpkAESevDate_ValueChanged);
            // 
            // cmbAEWorkStatus
            // 
            this.cmbAEWorkStatus.Location = new System.Drawing.Point(1184, 399);
            this.cmbAEWorkStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbAEWorkStatus.MenuManager = this.barManager1;
            this.cmbAEWorkStatus.Name = "cmbAEWorkStatus";
            this.cmbAEWorkStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAEWorkStatus.Size = new System.Drawing.Size(520, 42);
            this.cmbAEWorkStatus.TabIndex = 41;
            this.cmbAEWorkStatus.SelectedIndexChanged += new System.EventHandler(this.cmbAEWorkStatus_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(936, 406);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 34);
            this.label10.TabIndex = 40;
            this.label10.Text = "Tình trạng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(936, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 34);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ngày vào làm:";
            // 
            // dpkAEApproveDate
            // 
            this.dpkAEApproveDate.CustomFormat = "dd/MM/yyyy";
            this.dpkAEApproveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkAEApproveDate.Location = new System.Drawing.Point(1184, 315);
            this.dpkAEApproveDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dpkAEApproveDate.Name = "dpkAEApproveDate";
            this.dpkAEApproveDate.Size = new System.Drawing.Size(516, 40);
            this.dpkAEApproveDate.TabIndex = 38;
            this.dpkAEApproveDate.ValueChanged += new System.EventHandler(this.dpkAEApproveDate_ValueChanged);
            // 
            // txteAEPhone
            // 
            this.txteAEPhone.Location = new System.Drawing.Point(1184, 236);
            this.txteAEPhone.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txteAEPhone.MenuManager = this.barManager1;
            this.txteAEPhone.Name = "txteAEPhone";
            this.txteAEPhone.Size = new System.Drawing.Size(520, 40);
            this.txteAEPhone.TabIndex = 37;
            // 
            // txteAEAddress
            // 
            this.txteAEAddress.Location = new System.Drawing.Point(1184, 155);
            this.txteAEAddress.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txteAEAddress.MenuManager = this.barManager1;
            this.txteAEAddress.Name = "txteAEAddress";
            this.txteAEAddress.Size = new System.Drawing.Size(520, 40);
            this.txteAEAddress.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(936, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 34);
            this.label7.TabIndex = 35;
            this.label7.Text = "Địa chỉ:";
            // 
            // txteAEIDNo
            // 
            this.txteAEIDNo.Location = new System.Drawing.Point(264, 399);
            this.txteAEIDNo.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txteAEIDNo.MenuManager = this.barManager1;
            this.txteAEIDNo.Name = "txteAEIDNo";
            this.txteAEIDNo.Size = new System.Drawing.Size(520, 40);
            this.txteAEIDNo.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 34);
            this.label6.TabIndex = 33;
            this.label6.Text = "CMND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 49, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 34);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày sinh:";
            // 
            // cmbAEGender
            // 
            this.cmbAEGender.Location = new System.Drawing.Point(264, 236);
            this.cmbAEGender.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbAEGender.MenuManager = this.barManager1;
            this.cmbAEGender.Name = "cmbAEGender";
            this.cmbAEGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAEGender.Size = new System.Drawing.Size(520, 42);
            this.cmbAEGender.TabIndex = 31;
            // 
            // txteAEEmpName
            // 
            this.txteAEEmpName.Location = new System.Drawing.Point(264, 155);
            this.txteAEEmpName.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txteAEEmpName.MenuManager = this.barManager1;
            this.txteAEEmpName.Name = "txteAEEmpName";
            this.txteAEEmpName.Size = new System.Drawing.Size(520, 40);
            this.txteAEEmpName.TabIndex = 30;
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 704);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.Name = "frmAddEmployee";
            this.Text = "Nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAEPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAEWorkStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEIDNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAEGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAEEmpName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barAIOptions;
        private DevExpress.XtraBars.BarButtonItem bbtniAEBack;
        private DevExpress.XtraBars.BarButtonItem bbtniAEAdd;
        private DevExpress.XtraBars.BarButtonItem bbtniAEPrint;
        private DevExpress.XtraBars.BarButtonItem bbtniAEReset;
        private DevExpress.XtraBars.BarStaticItem bsiAIState;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAIDeleteItem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dpkAESevDate;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAEWorkStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpkAEApproveDate;
        private DevExpress.XtraEditors.TextEdit txteAEPhone;
        private DevExpress.XtraEditors.TextEdit txteAEAddress;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txteAEIDNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAEGender;
        private DevExpress.XtraEditors.TextEdit txteAEEmpName;
        private DevExpress.XtraEditors.TextEdit txteAEEmpCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpickAEBirthday;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAEPosition;
        private System.Windows.Forms.Label label1;
    }
}