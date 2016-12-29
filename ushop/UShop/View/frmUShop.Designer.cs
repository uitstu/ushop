namespace View
{
    partial class frmUShop
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProductManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnReceiptNote = new DevExpress.XtraBars.BarButtonItem();
            this.btnPM = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barbtniCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barbtniAppointment = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribpagProductManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribpagSourceManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribpaggrpInvoice = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribpaggrpEmployee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barbtniAccount = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnProductManagement,
            this.btnCategory,
            this.btnReceiptNote,
            this.btnPM,
            this.barbtnInvoice,
            this.barbtnEmployee,
            this.barbtniCustomer,
            this.barbtniAppointment,
            this.barbtniAccount});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribpagProductManagement,
            this.ribpagSourceManagement});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1155, 168);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Caption = "Quản lý Sản phẩm";
            this.btnProductManagement.Id = 1;
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductManagement_ItemClick);
            // 
            // btnCategory
            // 
            this.btnCategory.Caption = "Danh mục";
            this.btnCategory.Id = 7;
            this.btnCategory.ImageUri.Uri = "ListBullets";
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategory_ItemClick);
            // 
            // btnReceiptNote
            // 
            this.btnReceiptNote.Caption = "Phiếu nhập";
            this.btnReceiptNote.Id = 9;
            this.btnReceiptNote.ImageUri.Uri = "AddItem";
            this.btnReceiptNote.Name = "btnReceiptNote";
            this.btnReceiptNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReceiptNote_ItemClick);
            // 
            // btnPM
            // 
            this.btnPM.Caption = "barButtonItem1";
            this.btnPM.Id = 10;
            this.btnPM.Name = "btnPM";
            // 
            // barbtnInvoice
            // 
            this.barbtnInvoice.Caption = "Hóa đơn";
            this.barbtnInvoice.Id = 11;
            this.barbtnInvoice.Name = "barbtnInvoice";
            this.barbtnInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnInvoice_ItemClick);
            // 
            // barbtnEmployee
            // 
            this.barbtnEmployee.Caption = "Nhân sự";
            this.barbtnEmployee.Id = 12;
            this.barbtnEmployee.Name = "barbtnEmployee";
            this.barbtnEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnEmployee_ItemClick);
            // 
            // barbtniCustomer
            // 
            this.barbtniCustomer.Caption = "Khách hàng";
            this.barbtniCustomer.Id = 13;
            this.barbtniCustomer.Name = "barbtniCustomer";
            this.barbtniCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtniCustomer_ItemClick);
            // 
            // barbtniAppointment
            // 
            this.barbtniAppointment.Caption = "Phiếu hẹn";
            this.barbtniAppointment.Id = 14;
            this.barbtniAppointment.Name = "barbtniAppointment";
            this.barbtniAppointment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtniAppointment_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProductManagement);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "QLSP";
            // 
            // ribpagProductManagement
            // 
            this.ribpagProductManagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribpagProductManagement.Name = "ribpagProductManagement";
            this.ribpagProductManagement.Text = "Quản lý Sản phẩm";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCategory);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "#1";
            // 
            // ribpagSourceManagement
            // 
            this.ribpagSourceManagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribpaggrpInvoice,
            this.ribpaggrpEmployee,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribpagSourceManagement.Name = "ribpagSourceManagement";
            this.ribpagSourceManagement.Text = "Quản lý nguồn hàng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReceiptNote);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Phiếu nhập";
            // 
            // ribpaggrpInvoice
            // 
            this.ribpaggrpInvoice.ItemLinks.Add(this.barbtnInvoice);
            this.ribpaggrpInvoice.Name = "ribpaggrpInvoice";
            this.ribpaggrpInvoice.Text = "Hóa đơn";
            // 
            // ribpaggrpEmployee
            // 
            this.ribpaggrpEmployee.ItemLinks.Add(this.barbtnEmployee);
            this.ribpaggrpEmployee.Name = "ribpaggrpEmployee";
            this.ribpaggrpEmployee.Text = "Nhân sự";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barbtniCustomer);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Khách hàng";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barbtniAppointment);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Phiếu hẹn";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReceiptNote);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Phiếu nhập";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barbtniAccount);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Tài khoản";
            // 
            // barbtniAccount
            // 
            this.barbtniAccount.Caption = "Tài khoản";
            this.barbtniAccount.Id = 15;
            this.barbtniAccount.Name = "barbtniAccount";
            this.barbtniAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtniAccount_ItemClick);
            // 
            // frmUShop
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 794);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUShop";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUShop_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUShop_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnProductManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribpagProductManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribpagSourceManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnReceiptNote;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.BarButtonItem btnPM;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barbtnInvoice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribpaggrpInvoice;
        private DevExpress.XtraBars.BarButtonItem barbtnEmployee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribpaggrpEmployee;
        private DevExpress.XtraBars.BarButtonItem barbtniCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barbtniAppointment;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barbtniAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
    }
}

