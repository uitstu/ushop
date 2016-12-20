namespace View.Elements.ReceiptNote
{
    partial class frmAddReceiptNote
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
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboxProduct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboxSupplier = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxNote = new System.Windows.Forms.TextBox();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tboxAccounted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpickAccounting = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dpickIssued = new System.Windows.Forms.DateTimePicker();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.btnAdd});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm mới";
            this.btnAdd.Id = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1155, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 499);
            this.barDockControlBottom.Size = new System.Drawing.Size(1155, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 477);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1155, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 477);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cboxProduct);
            this.groupControl1.Controls.Add(this.cboxSupplier);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.tboxNote);
            this.groupControl1.Controls.Add(this.btnAddItem);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.lbTotal);
            this.groupControl1.Controls.Add(this.tboxAccounted);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.dpickAccounting);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.dpickIssued);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 22);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1155, 163);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // cboxProduct
            // 
            this.cboxProduct.Location = new System.Drawing.Point(72, 136);
            this.cboxProduct.MenuManager = this.barManager1;
            this.cboxProduct.Name = "cboxProduct";
            this.cboxProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxProduct.Size = new System.Drawing.Size(200, 20);
            this.cboxProduct.TabIndex = 16;
            this.cboxProduct.TextChanged += new System.EventHandler(this.cboxProduct_TextChanged);
            // 
            // cboxSupplier
            // 
            this.cboxSupplier.Location = new System.Drawing.Point(94, 32);
            this.cboxSupplier.MenuManager = this.barManager1;
            this.cboxSupplier.Name = "cboxSupplier";
            this.cboxSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxSupplier.Size = new System.Drawing.Size(200, 20);
            this.cboxSupplier.TabIndex = 15;
            this.cboxSupplier.TextChanged += new System.EventHandler(this.cboxSupplier_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ghi chú:";
            // 
            // tboxNote
            // 
            this.tboxNote.Location = new System.Drawing.Point(757, 32);
            this.tboxNote.Multiline = true;
            this.tboxNote.Name = "tboxNote";
            this.tboxNote.Size = new System.Drawing.Size(386, 54);
            this.tboxNote.TabIndex = 12;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(278, 134);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Thêm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tìm hàng:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(543, 32);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(65, 13);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "/  10000000";
            // 
            // tboxAccounted
            // 
            this.tboxAccounted.Location = new System.Drawing.Point(437, 29);
            this.tboxAccounted.Name = "tboxAccounted";
            this.tboxAccounted.Size = new System.Drawing.Size(100, 21);
            this.tboxAccounted.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đã thanh toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hạn thanh toán:";
            // 
            // dpickAccounting
            // 
            this.dpickAccounting.Location = new System.Drawing.Point(437, 65);
            this.dpickAccounting.Name = "dpickAccounting";
            this.dpickAccounting.Size = new System.Drawing.Size(200, 21);
            this.dpickAccounting.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày lập:";
            // 
            // dpickIssued
            // 
            this.dpickIssued.Location = new System.Drawing.Point(94, 65);
            this.dpickIssued.Name = "dpickIssued";
            this.dpickIssued.Size = new System.Drawing.Size(200, 21);
            this.dpickIssued.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 185);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1155, 314);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn1,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "NAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "STOCK_S";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "VOUCHER_S";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "STOCK_M";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "VOUCHER_M";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "STOCK_L";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "VOUCHER_L";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "STOCK_XL";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 8;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "VOUCHER_XL";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 9;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "STOCK_XXL";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 10;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "VOUCHER_XXL";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 11;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "STOCK_TOTAL";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 12;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "VOUCHER_TOTAL";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 13;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "PRICE";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 14;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "AMOUNT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 15;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Delete";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "click \"Thêm\" grid sẽ add thêm một dòng";
            // 
            // frmAddReceiptNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 522);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAddReceiptNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddReceiptNote";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dpickIssued;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpickAccounting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tboxAccounted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxNote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.ComboBoxEdit cboxSupplier;
        private DevExpress.XtraEditors.ComboBoxEdit cboxProduct;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label5;
    }
}