using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace VokabeltrainerGUI
{
    class MainPresenter
    {
        #region members

        private MainModel _mainModel;
        private TestPresenter _testPresenter;
        private VocabularyModel _vocabularyModel;
        private Statistics _statisticsModel;
        private IView _mainView;
        

        #endregion

        #region Events
        public event EventHandler<string[]> NewLanguagesUpdated;
        #endregion


        #region constructor

        public MainPresenter(IView view, MainModel mainModel, VocabularyModel vocabularyModel, Statistics statisticsModel)
        {
            _mainView = view;
            _mainModel = mainModel;
            _vocabularyModel = vocabularyModel;
            _statisticsModel = statisticsModel;

            SetupLinks();

            string[] languages = _mainModel.GetLanguages();
            NewLanguagesUpdated.Invoke(this, languages);

        }
        #endregion

        private void SetupLinks()
        {
            _mainView.OnExitRequested += ExitProgram;
            _mainView.OnTestStartRequested += StartTest;

            NewLanguagesUpdated += _mainView.UpdateLanguages;
        }

        private void UpdateStats(object sender, bool result)
        {
            _statisticsModel.UpdateStats(result);
        }

        public void Run()
        {
            _mainView.Show();
            Application.Run();
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void StartTest(object sender,Tuple<int, int> selectedLanguages)
        {
            _testPresenter = new TestPresenter(new TestView(), _vocabularyModel, selectedLanguages.Item1, selectedLanguages.Item2);
            _testPresenter.OnTranslationChecked += UpdateStats;
            _testPresenter.Run();
        }
    }
}
