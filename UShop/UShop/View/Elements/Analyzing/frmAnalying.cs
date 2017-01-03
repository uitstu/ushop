using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Model;
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
    public partial class frmAnalyzing : Form, IAnalyzingView
    {
        Form beforeForm;
        private AnalyzingPresenter preAnalyzing;

        public frmAnalyzing()
        {
            InitializeComponent();
            preAnalyzing = new AnalyzingPresenter(this);
        }

        public frmAnalyzing(Form beforeForm)
        {
            InitializeComponent();
            preAnalyzing = new AnalyzingPresenter(this);
            this.beforeForm = beforeForm;
        }

        public void loadAnalyzing(double total, double cost, double tax, double win)
        {
            tboxTotal.Text = total+"";
            tboxCost.Text = cost+"";
            tboxTax.Text = tax+"";
            tboxWin.Text = win+"";
        }

        public void loadEmp(List<string> lst)
        {
            try
            {
                cboxEmp.Properties.Items.Clear();
            }
            catch
            { }

            cboxEmp.Properties.Items.AddRange(lst);
        }

        public void loadCus(List<string> lst)
        {
            try
            {
                cboxCus.Properties.Items.Clear();
            }
            catch
            { }

            cboxCus.Properties.Items.AddRange(lst);
        }

        private void frmAnalyzing_Activated(object sender, EventArgs e)
        {
            preAnalyzing.loadEmp();
            preAnalyzing.loadCus();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            int empID = -1;
            int cusID = -1;
            try
            {
                empID = Int32.Parse(cboxEmp.Text.Substring(cboxEmp.Text.IndexOf('0'), cboxEmp.Text.IndexOf(' ') - cboxEmp.Text.IndexOf('0')));
            }
            catch
            { }

            try
            {
                cusID = Int32.Parse(cboxCus.Text.Substring(cboxCus.Text.IndexOf('0'), cboxCus.Text.IndexOf(' ')  - cboxCus.Text.IndexOf('0')));
            }
            catch
            { }
            Console.WriteLine("emp: "+empID+", cus: "+cusID);
            if (empID == -1 && cusID == -1)
            {
                preAnalyzing.loadAnalyzing(dpickBegin.Value, dpickEnd.Value);
            }

            if (empID != -1 && cusID == -1)
            {
                preAnalyzing.loadAnalyzing(dpickBegin.Value, dpickEnd.Value, empID, true);
            }

            if (empID == -1 && cusID != -1)
            {
                preAnalyzing.loadAnalyzing(dpickBegin.Value, dpickEnd.Value, cusID);
            }

            if (empID != -1 && cusID != -1)
            {
                preAnalyzing.loadAnalyzing(dpickBegin.Value, dpickEnd.Value, empID, cusID);
            }
        }

        private void dpickBegin_ValueChanged(object sender, EventArgs e)
        {
            dpickEnd.MinDate = dpickBegin.Value;
        }

        private void dpickEnd_ValueChanged(object sender, EventArgs e)
        {
            dpickBegin.MaxDate = dpickEnd.Value;
        }

        private void cboxEmp_TextChanged(object sender, EventArgs e)
        {
            preAnalyzing.loadEmp();

            List<string> lst = new List<string>();

            foreach (string str in cboxEmp.Properties.Items)
            {
                if (str.ToLower().Contains(cboxEmp.Text.ToLower()))
                {
                    lst.Add(str);
                }
            }

            try
            {
                cboxEmp.Properties.Items.Clear();
            }
            catch { }
            
            cboxEmp.Properties.Items.AddRange(lst);

            cboxEmp.ShowPopup();
        }

        private void cboxCus_TextChanged(object sender, EventArgs e)
        {
            preAnalyzing.loadCus();

            List<string> lst = new List<string>();

            foreach (string str in cboxCus.Properties.Items)
            {
                if (str.ToLower().Contains(cboxCus.Text.ToLower()))
                {
                    lst.Add(str);
                }
            }

            try
            {
                cboxCus.Properties.Items.Clear();
            }
            catch { }

            cboxCus.Properties.Items.AddRange(lst);

            cboxCus.ShowPopup();
        }
    }
}
