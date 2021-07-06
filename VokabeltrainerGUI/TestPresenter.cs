using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace VokabeltrainerGUI
{
    class TestPresenter
    {
        #region events
        public event EventHandler<bool> OnUpdateStatistics;
        #endregion

        #region members
        private TestView _testView;
        private VocabularyModel _VocabularyModel;
        private int _indexLang1;
        private int _indexLang2;
        #endregion

        #region constructor 
        public TestPresenter(TestView testView, VocabularyModel model, int indexLanguage1, int indexLanguage2)
        {
            _testView = testView;
            _VocabularyModel = model;
            _VocabularyModel.LoadFromCSV();
            _indexLang1 = indexLanguage1;
            _indexLang2 = indexLanguage2;

            SetupLinks();

            _testView.UpdateLanguageLbl(model.GetLanguageWithIndex(indexLanguage1), model.GetLanguageWithIndex(indexLanguage2));
            GetFirstRandomWord();
        }
        #endregion

        #region methods
        private void SetupLinks()
        {
            _testView.OnNextWordRequested += GetRandomWord;
            _testView.OnCheckingWordRequested += CheckingTranslation;
            _testView.OnExitRequested += ExitProgram;
        }

        //TestView requested random word
        private void GetRandomWord(object sender, EventArgs e)
        {         
            string randomWord = _VocabularyModel.GetNextRandomWord(_indexLang1, _indexLang2);
            _testView.UpdateView(randomWord);
        }

        private void GetFirstRandomWord()
        {
            string randomWord = _VocabularyModel.GetNextRandomWord(_indexLang1, _indexLang2);
            _testView.UpdateView(randomWord);
        }

        private void CheckingTranslation(object sender, Tuple<string, string> randomWordAndTranslation)
        {
            bool result;
            result = _VocabularyModel.CheckingTranslation(randomWordAndTranslation, _indexLang1, _indexLang2);
            OnUpdateStatistics?.Invoke(this, result); 
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            _testView.Close();
        }

        public void Run()
        {
            _testView.Show();
        }
        #endregion
    }
}
