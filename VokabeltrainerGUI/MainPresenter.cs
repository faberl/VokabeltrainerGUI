using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    class MainPresenter
    {
        #region members
        private VocabularyModel vocabularyModel;   

        #endregion

        public MainPresenter(IStorage storage, VocabularyModel vocabularyModel)
        {   
            
            //initialisieren von vocabularyModel 
            //aufrufen von LoadFromCSV
        }

        public void Run()
        {
            MainPresenter.Show();
            Application.Run();
        }

        public void StartTest()
        {

        }




    }
}
