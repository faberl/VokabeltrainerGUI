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

        #endregion

        #region Events
        public event EventHandler<string[]> NewLanguagesUpdated;
        #endregion


        #region constructor

        public MainPresenter(IView view, VocabularyModel vocabularyModel)
        {
            _mainView = view;
            _vocabularyModel = vocabularyModel;

            SetupLinks();

            _vocabularyModel.LoadFromCSV();

            string[] languages = _vocabularyModel.GetLanguages();
            NewLanguagesUpdated.Invoke(this, languages);


            //event welches view bescheid gibt das aktuelle sprachen verfügbar sind 
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
