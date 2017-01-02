using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Model;
using Model.Properties;
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

namespace View.Elements.Account
{
    public partial class frmAccount : Form,IAccountView
    {
        AccountPresenter presenter;
        DataTable table;
        public frmAccount()
        {
            
            InitializeComponent();
            presenter = new AccountPresenter();
            presenter.AccView = this;
            presenter.loadAccountList();

            GridView gridView = grdconAMAccount.FocusedView as GridView;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            }
        }


        public void showAccountList(DataTable table)
        {
            this.table = table;
            grdconAMAccount.DataSource = table;
        }

        public void showMessageBox(string msg, MessageBoxIcon type)
        {
            switch (type)
            {
                case MessageBoxIcon.Error:

                    MessageBox.Show(msg, Resources.ERROR_CAPTION, MessageBoxButtons.OK, type);
                    break;
                case MessageBoxIcon.Information:

                    MessageBox.Show(msg, Resources.INFOR_CAPTION, MessageBoxButtons.OK, type);
                    break;
            }
        }


        private void btnAMUpdateAccount_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
          
            String accCode = table.Rows[gvAMAccount.FocusedRowHandle]["ACC_CODE"] + "";
            Form addAccForm = new frmAddAccount(this, presenter, accCode);
            addAccForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addAccForm.MdiParent = this.MdiParent;
            addAccForm.Dock = DockStyle.Fill;
            addAccForm.Show();
        }

        private void btnAMDeleteAccount_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            int index = gvAMAccount.FocusedRowHandle;
            presenter.removeAccount(index);
        }


        public DataTable getAccountTable()
        {
            table = grdconAMAccount.DataSource as DataTable;
            return table;
        }

        
        

        private void bbtniAMAddAccount_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Form addAccForm = new frmAddAccount(this, presenter);
            addAccForm.FormBorderStyle = FormBorderStyle.None;
            //set fill parent
            addAccForm.MdiParent = this.MdiParent;
            addAccForm.Dock = DockStyle.Fill;
            addAccForm.Show();
        }

        private void frmAccount_Activated(object sender, EventArgs e)
        {
            table.Rows.Clear();
            presenter.loadAccountList();
        }

        private void btnPrintExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconAMAccount.FocusedView as GridView;

                gridView.Columns[4].Visible = false;
                gridView.Columns[5].Visible = false;

                grdconAMAccount.ExportToXlsx(saveFileDialog1.FileName);

                gridView.Columns[4].Visible = true;
                gridView.Columns[5].Visible = true;

            }
        }

        private void btnPrintPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GridView gridView = grdconAMAccount.FocusedView as GridView;

                gridView.Columns[4].Visible = false;
                gridView.Columns[5].Visible = false;

                grdconAMAccount.ExportToPdf(saveFileDialog1.FileName);

                gridView.Columns[4].Visible = true;
                gridView.Columns[5].Visible = true;

            }
        }
    }
}
