using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    class MainPresenter
    {
        #region members
        private VocabularyModel _vocabularyModel;
        private TestPresenter _testPresenter;
        private IView _mainView;
        private IStorage _csvPersistor;

        #endregion

        #region constructor

        public MainPresenter(IStorage storage, IView view, VocabularyModel vocabularyModel)
        {
            _vocabularyModel = new VocabularyModel();
            _mainView = view;
            _vocabularyModel = vocabularyModel;
            _csvPersistor = storage;

            SetupLinks();
            _vocabularyModel.LoadFromCSV();

            //initialisieren von vocabularyModel 
            //aufrufen von LoadFromCSV
        }
        #endregion

        private void SetupLinks()
        {
            _mainView.OnExitRequested += ExitProgram;
            _mainView.OnTestStartRequested += StartTest;
        }

        public void Run()
        {
            _mainView.Show();          
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        public void StartTest(object sender, EventArgs e)
        {
            _testPresenter = new TestPresenter();
            
        }




    }
}
