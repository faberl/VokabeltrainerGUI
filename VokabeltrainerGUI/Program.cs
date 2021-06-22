using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VokabeltrainerGUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initialisieren von IStorage & VocabularyModel
            IStorage storage = new CSVParser();
            IView view = new MainView();

            VocabularyModel vocabularyList = new VocabularyModel();
            MainPresenter mainPresenter = new MainPresenter(storage, view, vocabularyList);
            


            //neuen Mainpresenter und übergeben von IStorage & VocabularyModel

            //MainView.Run
            


        }
    }
}
