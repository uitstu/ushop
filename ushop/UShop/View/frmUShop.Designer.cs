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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUShop));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProductManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnReceiptNote = new DevExpress.XtraBars.BarButtonItem();
            this.btnPM = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barbtniCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductSize = new DevExpress.XtraBars.BarButtonItem();
            this.btnSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.barbtniAppointment = new DevExpress.XtraBars.BarButtonItem();
            this.barbtniAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.btnAppointment = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribpagProductManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribpagSourceManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribpaggrpEmployee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnProduct,
            this.btnProductSize,
            this.btnSupplier,
            this.barbtniAppointment,
            this.barbtniAccount,
            this.btnInvoice,
            this.btnAppointment,
            this.btnCustomer,
            this.btnChangePassword,
            this.btnLogout});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 29;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribpagProductManagement,
            this.ribpagSourceManagement});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1155, 168);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Caption = "Đổi mật khẩu";
            this.btnProductManagement.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProductManagement.Glyph")));
            this.btnProductManagement.Id = 1;
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.btnReceiptNote.Caption = "Phiếu nhập hàng";
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
            this.barbtnEmployee.Caption = "Nhân viên";
            this.barbtnEmployee.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnEmployee.Glyph")));
            this.barbtnEmployee.Id = 12;
            this.barbtnEmployee.Name = "barbtnEmployee";
            this.barbtnEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnEmployee_ItemClick);
            // 
            // barbtniCustomer
            // 
            this.barbtniCustomer.Caption = "Khách hàng";
            this.barbtniCustomer.Id = 13;
            this.barbtniCustomer.Name = "barbtniCustomer";
            this.barbtniCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtniCustomer_ItemClick);
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "Sản phẩm";
            this.btnProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProduct.Glyph")));
            this.btnProduct.Id = 14;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnProductSize
            // 
            this.btnProductSize.Caption = "Số lượng";
            this.btnProductSize.Id = 15;
            this.btnProductSize.ImageUri.Uri = "SendBehindText";
            this.btnProductSize.Name = "btnProductSize";
            this.btnProductSize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductSize_ItemClick);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Caption = "Nhà cung cấp";
            this.btnSupplier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Glyph")));
            this.btnSupplier.Id = 16;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSupplier_ItemClick);
            // 
            // barbtniAppointment
            // 
            this.barbtniAppointment.Caption = "Phiếu hẹn";
            this.barbtniAppointment.Id = 17;
            this.barbtniAppointment.Name = "barbtniAppointment";
            this.barbtniAppointment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtniAppointment_ItemClick);
            // 
            // barbtniAccount
            // 
            this.barbtniAccount.Caption = "Tài khoản";
            this.barbtniAccount.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtniAccount.Glyph")));
            this.barbtniAccount.Id = 18;
            this.barbtniAccount.Name = "barbtniAccount";
            this.barbtniAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtniAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtniAccount_ItemClick);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Caption = "Hóa đơn";
            this.btnInvoice.Glyph = ((System.Drawing.Image)(resources.GetObject("btnInvoice.Glyph")));
            this.btnInvoice.Id = 19;
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInvoice_ItemClick);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Caption = "Phiếu hẹn";
            this.btnAppointment.Id = 20;
            this.btnAppointment.ImageUri.Uri = "New";
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAppointment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAppointment_ItemClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách hàng";
            this.btnCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Glyph")));
            this.btnCustomer.Id = 21;
            this.btnCustomer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCustomer.LargeGlyph")));
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Mật khẩu";
            this.btnChangePassword.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Glyph")));
            this.btnChangePassword.Id = 27;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.Glyph")));
            this.btnLogout.Id = 28;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // ribpagProductManagement
            // 
            this.ribpagProductManagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribpagProductManagement.Name = "ribpagProductManagement";
            this.ribpagProductManagement.Text = "Bán hàng";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnInvoice);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnCustomer);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnAppointment);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            this.ribbonPageGroup8.Text = "Bán hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCategory);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProductSize);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Quản hàng";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Hệ thống";
            // 
            // ribpagSourceManagement
            // 
            this.ribpagSourceManagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribpaggrpEmployee});
            this.ribpagSourceManagement.Name = "ribpagSourceManagement";
            this.ribpagSourceManagement.Text = "Quản lý";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSupplier);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReceiptNote);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Nguồn hàng";
            // 
            // ribpaggrpEmployee
            // 
            this.ribpaggrpEmployee.ItemLinks.Add(this.barbtnEmployee);
            this.ribpaggrpEmployee.ItemLinks.Add(this.barbtniAccount);
            this.ribpaggrpEmployee.Name = "ribpaggrpEmployee";
            this.ribpaggrpEmployee.Text = "Nhân sự";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReceiptNote);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Phiếu nhập";
            // 
            // frmUShop
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 775);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUShop";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUShop_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUShop_FormClosed);
            this.Load += new System.EventHandler(this.frmUShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
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
        private DevExpress.XtraBars.BarButtonItem barbtnEmployee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribpaggrpEmployee;
        private DevExpress.XtraBars.BarButtonItem barbtniCustomer;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.BarButtonItem btnProductSize;
        private DevExpress.XtraBars.BarButtonItem btnSupplier;
        private DevExpress.XtraBars.BarButtonItem barbtniAppointment;
        private DevExpress.XtraBars.BarButtonItem barbtniAccount;
        private DevExpress.XtraBars.BarButtonItem btnInvoice;
        private DevExpress.XtraBars.BarButtonItem btnAppointment;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}