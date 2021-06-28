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

        void UpdateLanguages(object sender, string[] languages);

        void Show();
    }
}
