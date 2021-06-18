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
    public partial class MainView : Form
    {

        public MainView(IStorage storage, PersonListModel model)
        {
            InitializeComponent();

            //in den Presenter? Oder Model?
            Vocabulary vocabulary = new Vocabulary();
            string[] languages = vocabulary.GetLanguages();

            for (int i = 0; i < languages.Length; i++)
            {
                cbxLanguage1.Items.Add(languages[i]);
            }

            for (int i = 0; i < languages.Length; i++)
            {
                cbxLanguage2.Items.Add(languages[i]);
            }

            //Aufrufen von Model für reinladen der CSV Datei

            InitializeComponent();
        }

        public void Run()
        {
            _mainView.Show();
            Application.Run();
        }


        public event EventHandler OnTestStartRequested;

        public event EventHandler OnExitRequested;

        #region Click Events

        private void btnStartTest_Click(object sender, EventArgs e)
        {

            if (IsLanguageSelected() && !IsSelectedIndexEqual())
            {
                OnTestStartRequested(this, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            OnExitRequested(this, e);
        }
        #endregion


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
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
