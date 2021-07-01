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
        public event EventHandler<Tuple<string, string>> OnNextWordRequested;
        public event EventHandler OnExitRequested;


        public TestView()
        {
            InitializeComponent();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            string randomWord = tbxLanguage1.Text;
            string userInput = tbxLanguage2.Text;


            OnNextWordRequested(this, new Tuple<string, string>(randomWord,userInput));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnExitRequested(this, e);
        }

        public void UpdateLanguageLbl(string language1, string language2)
        {
            lblLanguage1.Text = language1;
            lblLanguage2.Text = language2;
        }
    }
}
