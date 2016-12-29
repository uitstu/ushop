using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Presenter.Interface;
using Presenter.InterfaceImplement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Elements.Supplier;

namespace View.Elements
{
    public partial class frmSupplier : Form, ISupplierView
    {
        private SupplierPresenter preSupplier;
        public frmSupplier()
        {
            InitializeComponent();
            preSupplier = new SupplierPresenter(this);

            GridView gridView = gridSupplier.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }
        }

        //functions from interface
        public void loadSuppliers(List<Model.SUPPLIER> listObj)
        {
            gridSupplier.DataSource = listObj;
        }


        //functions

        //events

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            preSupplier.loadSuppliers();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmAddSupplier frmAdd = new frmAddSupplier(preSupplier);
            //frmAdd.ShowDialog();
            frmAddSupplier frmAdd = new frmAddSupplier(preSupplier,this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure delete it?", "Deleting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GridView gridView = gridSupplier.FocusedView as GridView;
                preSupplier.deleteSupplier(gridView.GetFocusedRowCellValue("SUPPLIER_ID").ToString());
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView gridView = gridSupplier.FocusedView as GridView;
            Model.SUPPLIER obj = new Model.SUPPLIER();

            obj.SUPPLIER_ID = Convert.ToInt32(gridView.GetFocusedRowCellValue("SUPPLIER_ID").ToString());
            obj.SUPPLIER_CODE = gridView.GetFocusedRowCellValue("SUPPLIER_CODE").ToString();
            obj.SUPPLIER_NAME = gridView.GetFocusedRowCellValue("SUPPLIER_NAME").ToString();
            obj.TAX_CODE = gridView.GetFocusedRowCellValue("TAX_CODE").ToString();
            obj.PHONE = gridView.GetFocusedRowCellValue("PHONE").ToString();
            obj.ADDRESS = gridView.GetFocusedRowCellValue("ADDRESS").ToString();

            //frmAddSupplier frmAdd = new frmAddSupplier(preSupplier, obj);
            //frmAdd.ShowDialog();
            frmAddSupplier frmAdd = new frmAddSupplier(preSupplier, obj, this);
            frmAdd.WindowState = FormWindowState.Maximized;
            frmAdd.FormBorderStyle = FormBorderStyle.None;
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Dock = DockStyle.Fill;
            frmAdd.Show();
        }

        private void frmSupplier_Activated(object sender, EventArgs e)
        {
            preSupplier.loadSuppliers();
            this.WindowState = FormWindowState.Maximized;
        }
        
    }
}
