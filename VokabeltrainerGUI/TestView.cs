using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VokabeltrainerGUI
{
    public partial class TestView : Form
    {
        public event EventHandler OnNextWordRequested;
        public event EventHandler OnExitRequested;


        public TestView()
        {
            InitializeComponent();
        }

        //Sagt bescheid sobald input eingegeben und der Button Next gedrückt wird


        private void btnNext_Click(object sender, EventArgs e)
        {
            OnNextWordRequested(this, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnExitRequested(this, e);
        }
    }
}
