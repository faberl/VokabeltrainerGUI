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
        public TestView()
        {
            InitializeComponent();
        }

        //Sagt bescheid sobald input eingegeben und der Button Next gedrückt wird
        public event EventHandler OnVerificationRequested;


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
