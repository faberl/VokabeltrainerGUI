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
        public event EventHandler<string[]> OnNextWordRequested;
        public event EventHandler OnExitRequested;


        public TestView()
        {
            InitializeComponent();
        }

        //Sagt bescheid sobald input eingegeben und der Button Next gedrückt wird


        private void btnNext_Click(object sender, EventArgs e)
        {
            string[] selectedLanguages = new string[2];

            selectedLanguages[0] = tbxLanguage1.Text;
            selectedLanguages[1] = tbxLanguage2.Text;

            OnNextWordRequested(this, selectedLanguages);
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
