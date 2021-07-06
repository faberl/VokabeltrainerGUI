using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabeltrainerGUI
{
    public interface IView
    {
        event EventHandler<Tuple<int, int>> OnTestStartRequested;
        event EventHandler OnExitRequested;
        event EventHandler OnStatisticResetRequested;

        void UpdateLanguages(object sender, string[] languages);
        void UpdateChart(object sender, int[] results);
        void Show();
    }
}
