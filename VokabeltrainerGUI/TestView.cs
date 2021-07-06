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
        #region eventhandler
        public event EventHandler<Tuple<string, string>> OnCheckingWordRequested;
        public event EventHandler OnNextWordRequested;
        public event EventHandler OnExitRequested;
        #endregion


        #region constructor
        public TestView()
        {
            InitializeComponent();
        }
        #endregion


        #region ClickEvents
        //next word requested and checking translation
        private void btnNext_Click(object sender, EventArgs e)
        {
            string randomWord = tbxLanguage1.Text;
            string userInput = tbxLanguage2.Text;

            OnNextWordRequested?.Invoke(this, e);
            OnCheckingWordRequested?.Invoke(this, new Tuple<string, string>(randomWord,userInput));

            tbxLanguage2.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnExitRequested(this, e);
        }
        #endregion

        #region methods
        public void UpdateLanguageLbl(string language1, string language2)
        {
            lblLanguage1.Text = language1;
            lblLanguage2.Text = language2;
        }

        public void UpdateView(string randomWord)
        {
            tbxLanguage1.Text = randomWord;
        }
        #endregion
    }
}
