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
        public event EventHandler<int[]> NewStaticsUpdated;
        public event EventHandler<int[]> StatisicsDeleted;
        #endregion

        #region constructor
        public MainPresenter(IView view, MainModel mainModel, VocabularyModel vocabularyModel, Statistics statisticsModel)
        {
            _mainView = view;
            _mainModel = mainModel;
            _vocabularyModel = vocabularyModel;
            _statisticsModel = statisticsModel;
   
            SetupLinks();

            //Inform MainView for Update
            NewLanguagesUpdated?.Invoke(this, _mainModel.LoadLanguagesFromCSV());
            NewStaticsUpdated?.Invoke(this, _statisticsModel.GetCurrentStatistic());

        }
        #endregion

        #region private methods
        private void SetupLinks()
        {
            //mainView to mainPresenter
            _mainView.OnExitRequested += ExitProgram;
            _mainView.OnTestStartRequested += StartTest;
            _mainView.OnStatisticResetRequested += ResetStatistics;

            //mainPresenter to mainView
            NewLanguagesUpdated += _mainView.UpdateLanguages;
            NewStaticsUpdated += _mainView.UpdateChart;
            StatisicsDeleted += _mainView.UpdateChart;

        }

        //Request from TestPresenter for Updating Statistics
        private void UpdateStatistic(object sender, bool result)
        {
            _statisticsModel.UpdateStatisticModel(result);
            NewStaticsUpdated?.Invoke(this, _statisticsModel.GetCurrentStatistic());
        }

        //Request from MainView for Deleting Statistics
        private void ResetStatistics(object sender, EventArgs e)
        {
            _statisticsModel.DeleteData();
            StatisicsDeleted?.Invoke(this, _statisticsModel.GetCurrentStatistic());
        }

        //Request from MainView for Starting TestView
        private void StartTest(object sender,Tuple<int, int> selectedLanguages)
        {
            _testPresenter = new TestPresenter(new TestView(), _vocabularyModel, selectedLanguages.Item1, selectedLanguages.Item2);
            _testPresenter.OnUpdateStatistics += UpdateStatistic;
            _testPresenter.Run();
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region methods
        public void Run()
        {
            _mainView.Show();
            Application.Run();
        }
        #endregion

    }
}
