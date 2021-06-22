using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabeltrainerGUI
{
    public interface IView
    {
        event EventHandler OnTestStartRequested;
        event EventHandler OnExitRequested;

        void Show();
    }
}
