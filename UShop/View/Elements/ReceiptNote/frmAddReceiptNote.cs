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

namespace View.Elements.ReceiptNote
{
    public partial class frmAddReceiptNote : Form
    {
        private ReceiptNotePresenter preReceiptNote;
        private Model.RECEIPT_NOTE obj;

        public frmAddReceiptNote()
        {
            InitializeComponent();
        }

        public frmAddReceiptNote(ReceiptNotePresenter preReceiptNote)
        {
            this.preReceiptNote = preReceiptNote;
            InitializeComponent();

            setSource();
        }

        public frmAddReceiptNote(ReceiptNotePresenter preReceiptNote, Model.RECEIPT_NOTE obj)
        {
            this.preReceiptNote = preReceiptNote;
            this.obj = obj;
            InitializeComponent();

            setSource();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        public void setSource()
        {
            List<string> lst = new List<string>();
            DataRow a = preReceiptNote.loadSupplierDT().Rows[0];
            foreach (DataRow d in preReceiptNote.loadSupplierDT().Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxSupplier.Properties.Items.AddRange(lst);
            cboxSupplier.Properties.AutoComplete = false;

            //

            lst = new List<string>();
            a = preReceiptNote.loadProdcutDT().Rows[0];
            foreach (DataRow d in preReceiptNote.loadProdcutDT().Rows)
            {
                lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxProduct.Properties.Items.AddRange(lst);
            cboxProduct.Properties.AutoComplete = false;
        }

        private void cboxSupplier_TextChanged_1(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            DataRow a = preReceiptNote.loadSupplierDT().Rows[0];
            foreach (DataRow d in preReceiptNote.loadSupplierDT().Rows)
            {
                if ((d[0].ToString() + " - " + d[1].ToString()).ToLower().Contains(cboxSupplier.Text.ToString().ToLower()))
                    lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxSupplier.Properties.Items.Clear();
            cboxSupplier.Properties.Items.AddRange(lst);

            cboxSupplier.ShowPopup();
        }

        private void cboxProduct_TextChanged(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            DataRow a = preReceiptNote.loadProdcutDT().Rows[0];
            foreach (DataRow d in preReceiptNote.loadProdcutDT().Rows)
            {
                if ((d[0].ToString() + " - " + d[1].ToString()).ToLower().Contains(cboxProduct.Text.ToString().ToLower()))
                    lst.Add(d[0].ToString() + " - " + d[1].ToString());
            }
            cboxProduct.Properties.Items.Clear();
            cboxProduct.Properties.Items.AddRange(lst);

            cboxProduct.ShowPopup();
        }
    }
}
