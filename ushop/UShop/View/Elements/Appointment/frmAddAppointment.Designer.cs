﻿namespace View.Elements.Appointment
{
    partial class frmAddAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAppointment));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnAIDeleteItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barAAOptions = new DevExpress.XtraBars.Bar();
            this.bbtniAABack = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniAAAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniAAPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbtniAAReset = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bsiAIState = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txteAAAppCode = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAENewCustomer = new System.Windows.Forms.Button();
            this.txteAAEmployee = new DevExpress.XtraEditors.TextEdit();
            this.txteAANote = new System.Windows.Forms.TextBox();
            this.txteAADescription = new System.Windows.Forms.TextBox();
            this.dpkAAAppDate = new System.Windows.Forms.DateTimePicker();
            this.dpkAACreatedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAACusId = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAAAppCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteAAEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAACusId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAIDeleteItem
            // 
            this.btnAIDeleteItem.AutoHeight = false;
            this.btnAIDeleteItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnAIDeleteItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnAIDeleteItem.Name = "btnAIDeleteItem";
            this.btnAIDeleteItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barAAOptions,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtniAAAdd,
            this.bbtniAAPrint,
            this.bbtniAAReset,
            this.bbtniAABack,
            this.bsiAIState});
            this.barManager1.MainMenu = this.barAAOptions;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barAAOptions
            // 
            this.barAAOptions.BarName = "Main menu";
            this.barAAOptions.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barAAOptions.DockCol = 0;
            this.barAAOptions.DockRow = 0;
            this.barAAOptions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barAAOptions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAABack, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAAAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAAPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtniAAReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barAAOptions.OptionsBar.AllowQuickCustomization = false;
            this.barAAOptions.OptionsBar.MultiLine = true;
            this.barAAOptions.OptionsBar.UseWholeRow = true;
            this.barAAOptions.Text = "Main menu";
            // 
            // bbtniAABack
            // 
            this.bbtniAABack.Caption = "Quay về";
            this.bbtniAABack.Id = 3;
            this.bbtniAABack.ImageUri.Uri = "Undo";
            this.bbtniAABack.Name = "bbtniAABack";
            this.bbtniAABack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAABack_ItemClick);
            // 
            // bbtniAAAdd
            // 
            this.bbtniAAAdd.Caption = "Lưu";
            this.bbtniAAAdd.Id = 0;
            this.bbtniAAAdd.ImageUri.Uri = "Apply";
            this.bbtniAAAdd.Name = "bbtniAAAdd";
            this.bbtniAAAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAAAdd_ItemClick);
            // 
            // bbtniAAPrint
            // 
            this.bbtniAAPrint.Caption = "In";
            this.bbtniAAPrint.Id = 1;
            this.bbtniAAPrint.ImageUri.Uri = "Print";
            this.bbtniAAPrint.Name = "bbtniAAPrint";
            this.bbtniAAPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAAPrint_ItemClick);
            // 
            // bbtniAAReset
            // 
            this.bbtniAAReset.Caption = "Xóa";
            this.bbtniAAReset.Id = 2;
            this.bbtniAAReset.ImageUri.Uri = "Cancel";
            this.bbtniAAReset.Name = "bbtniAAReset";
            this.bbtniAAReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtniAAReset_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsiAIState)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(785, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(785, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 331);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(785, 30);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 331);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày lập:";
            // 
            // txteAAAppCode
            // 
            this.txteAAAppCode.Location = new System.Drawing.Point(592, 34);
            this.txteAAAppCode.MenuManager = this.barManager1;
            this.txteAAAppCode.Name = "txteAAAppCode";
            this.txteAAAppCode.Properties.ReadOnly = true;
            this.txteAAAppCode.Size = new System.Drawing.Size(181, 22);
            this.txteAAAppCode.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày trả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã phiếu hẹn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nhân viên lập:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAENewCustomer);
            this.groupControl1.Controls.Add(this.txteAAEmployee);
            this.groupControl1.Controls.Add(this.txteAANote);
            this.groupControl1.Controls.Add(this.txteAADescription);
            this.groupControl1.Controls.Add(this.dpkAAAppDate);
            this.groupControl1.Controls.Add(this.dpkAACreatedDate);
            this.groupControl1.Controls.Add(this.cmbAACusId);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txteAAAppCode);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 30);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(785, 329);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Thông tin Phiếu hẹn";
            // 
            // btnAENewCustomer
            // 
            this.btnAENewCustomer.Location = new System.Drawing.Point(355, 36);
            this.btnAENewCustomer.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.btnAENewCustomer.Name = "btnAENewCustomer";
            this.btnAENewCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAENewCustomer.TabIndex = 49;
            this.btnAENewCustomer.Text = "KH Mới";
            this.btnAENewCustomer.UseVisualStyleBackColor = true;
            this.btnAENewCustomer.Click += new System.EventHandler(this.btnAENewCustomer_Click);
            // 
            // txteAAEmployee
            // 
            this.txteAAEmployee.Location = new System.Drawing.Point(592, 77);
            this.txteAAEmployee.MenuManager = this.barManager1;
            this.txteAAEmployee.Name = "txteAAEmployee";
            this.txteAAEmployee.Properties.ReadOnly = true;
            this.txteAAEmployee.Size = new System.Drawing.Size(181, 22);
            this.txteAAEmployee.TabIndex = 48;
            // 
            // txteAANote
            // 
            this.txteAANote.Location = new System.Drawing.Point(126, 241);
            this.txteAANote.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.txteAANote.Multiline = true;
            this.txteAANote.Name = "txteAANote";
            this.txteAANote.Size = new System.Drawing.Size(210, 64);
            this.txteAANote.TabIndex = 47;
            // 
            // txteAADescription
            // 
            this.txteAADescription.Location = new System.Drawing.Point(126, 159);
            this.txteAADescription.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.txteAADescription.Multiline = true;
            this.txteAADescription.Name = "txteAADescription";
            this.txteAADescription.Size = new System.Drawing.Size(210, 64);
            this.txteAADescription.TabIndex = 46;
            // 
            // dpkAAAppDate
            // 
            this.dpkAAAppDate.Location = new System.Drawing.Point(126, 116);
            this.dpkAAAppDate.Name = "dpkAAAppDate";
            this.dpkAAAppDate.Size = new System.Drawing.Size(210, 23);
            this.dpkAAAppDate.TabIndex = 45;
            // 
            // dpkAACreatedDate
            // 
            this.dpkAACreatedDate.Location = new System.Drawing.Point(126, 75);
            this.dpkAACreatedDate.Name = "dpkAACreatedDate";
            this.dpkAACreatedDate.Size = new System.Drawing.Size(210, 23);
            this.dpkAACreatedDate.TabIndex = 44;
            // 
            // cmbAACusId
            // 
            this.cmbAACusId.Location = new System.Drawing.Point(126, 36);
            this.cmbAACusId.MenuManager = this.barManager1;
            this.cmbAACusId.Name = "cmbAACusId";
            this.cmbAACusId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAACusId.Size = new System.Drawing.Size(210, 22);
            this.cmbAACusId.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 24, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nội dung:";
            // 
            // frmAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 395);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAddAppointment";
            this.Text = "Chỉnh sửa phiếu hẹn";
            ((System.ComponentModel.ISupportInitialize)(this.btnAIDeleteItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteAAAppCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteAAEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAACusId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAIDeleteItem;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barAAOptions;
        private DevExpress.XtraBars.BarButtonItem bbtniAABack;
        private DevExpress.XtraBars.BarButtonItem bbtniAAAdd;
        private DevExpress.XtraBars.BarButtonItem bbtniAAPrint;
        private DevExpress.XtraBars.BarButtonItem bbtniAAReset;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem bsiAIState;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txteAAAppCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpkAAAppDate;
        private System.Windows.Forms.DateTimePicker dpkAACreatedDate;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAACusId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txteAANote;
        private System.Windows.Forms.TextBox txteAADescription;
        private DevExpress.XtraEditors.TextEdit txteAAEmployee;
        private System.Windows.Forms.Button btnAENewCustomer;
    }
}