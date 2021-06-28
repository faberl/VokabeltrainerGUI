using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VokabeltrainerGUI
{
    public partial class MainView : Form, IView
    {

        //mainpresenter deklarieren?

        public event EventHandler<Tuple<int, int>> OnTestStartRequested;
        public event EventHandler OnExitRequested;

        public MainView()
        {
            InitializeComponent();             
        }


        #region methods
        public void UpdateLanguages(object sender, string[] languages)
        {
            cbxLanguage1.Items.Clear();
            cbxLanguage2.Items.Clear();
            for (int i = 0; i < languages.Length; i++)
            {
                cbxLanguage1.Items.Add(languages[i]);
            }

            cbxLanguage1.SelectedItem = cbxLanguage1.Items[0];

            for (int i = 0; i < languages.Length; i++)
            {
                cbxLanguage2.Items.Add(languages[i]);
            }

            cbxLanguage2.SelectedItem = cbxLanguage2.Items[0];
        }
        #endregion


        #region Click Events

        private void btnStartTest_Click(object sender, EventArgs e)
        {

            if (IsLanguageSelected() && !IsSelectedIndexEqual())
            {
                OnTestStartRequested?.Invoke(this, new Tuple<int, int>(cbxLanguage1.SelectedIndex, cbxLanguage2.SelectedIndex));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnExitRequested?.Invoke(this, e);
        }
        #endregion


        #region checkingMethods

        private bool IsLanguageSelected()
        {
            if (cbxLanguage1.SelectedItem != null && cbxLanguage2.SelectedItem != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No Language selected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private bool IsSelectedIndexEqual()
        {
            if (cbxLanguage1.SelectedIndex == cbxLanguage2.SelectedIndex)
            {
                MessageBox.Show("Select two different languages!");
                return true;
            }
            else
            {
                return false;
            }    
        }

        #endregion


        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
