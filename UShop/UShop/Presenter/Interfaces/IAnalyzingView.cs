using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interface
{
    public interface IAnalyzingView
    {
        void loadAnalyzing(double total, double cost, double tax, double win);
        void loadEmp(List<string> lst);
        void loadCus(List<string> lst);
    }
}
