using Model;
using Model.InterfaceImplement;
using Presenter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.InterfaceImplement
{
    public class AnalyzingPresenter
    {
        private AnalyzingModel _model;
        private IAnalyzingView _view;

        public AnalyzingPresenter()
            : this(null , new AnalyzingModel())
        { 
        }

        public AnalyzingPresenter(IAnalyzingView view)
            : this(view, new AnalyzingModel())
        {
        }

        public AnalyzingPresenter(IAnalyzingView view, AnalyzingModel model)
        {
            _view = view;
            _model = model;
        }

        public void loadEmp()
        {
            _view.loadEmp(_model.getEmpList());
        }

        public void loadCus()
        {
            _view.loadCus(_model.getCusList());
        }

        public void loadAnalyzing(DateTime begin, DateTime end, int empID, int cusID)
        {
            List<INVOICE> lst = _model.getInvoiceList(begin, end, empID, cusID);
            double total, cost, tax, win;
            total = cost = tax = win = 0;
            foreach (INVOICE i in lst)
            {
                total += i.TOTAL_AMOUNT??0;
                cost += i.TOTAL_PAYMENT??0;
                tax += i.VAT_RATE ?? 0;
            }
            win = total - cost - tax;

            _view.loadAnalyzing(total, cost, tax, win);
        }

        public void loadAnalyzing(DateTime begin, DateTime end, int empID, bool isEmp)
        {
            List<INVOICE> lst = _model.getInvoiceList(begin, end, empID);
            double total, cost, tax, win;
            total = cost = tax = win = 0;
            foreach (INVOICE i in lst)
            {
                total += i.TOTAL_AMOUNT ?? 0;
                cost += i.TOTAL_PAYMENT ?? 0;
                tax += i.VAT_RATE ?? 0;
            }
            win = total - cost - tax;

            _view.loadAnalyzing(total, cost, tax, win);
        }

        public void loadAnalyzing(DateTime begin, DateTime end, int cusID)
        {
            List<INVOICE> lst = _model.getInvoiceList(begin, end, cusID);
            double total, cost, tax, win;
            total = cost = tax = win = 0;
            foreach (INVOICE i in lst)
            {
                total += i.TOTAL_AMOUNT ?? 0;
                cost += i.TOTAL_PAYMENT ?? 0;
                tax += i.VAT_RATE ?? 0;
            }
            win = total - cost - tax;

            _view.loadAnalyzing(total, cost, tax, win);
        }

        public void loadAnalyzing(DateTime begin, DateTime end)
        {
            List<INVOICE> lst = _model.getInvoiceList(begin, end);
            double total, cost, tax, win;
            total = cost = tax = win = 0;
            foreach (INVOICE i in lst)
            {
                total += i.TOTAL_AMOUNT ?? 0;
                cost += i.TOTAL_PAYMENT ?? 0;
                tax += i.VAT_RATE ?? 0;
            }
            win = total - cost - tax;

            _view.loadAnalyzing(total, cost, tax, win);
        }
    }
}
