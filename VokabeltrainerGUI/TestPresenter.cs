using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace VokabeltrainerGUI
{
    class TestPresenter
    {
        public event EventHandler<bool> OnTranslationChecked;

        private TestView _testView;
        private int _indexLang1;
        private int _indexLang2;
        private VocabularyModel _model;

        public TestPresenter(TestView testView, VocabularyModel model, int indexLanguage1, int indexLanguage2)
        {
            _testView = testView;

            _model = model;
            _model.LoadFromCSV();
            _indexLang1 = indexLanguage1;
            _indexLang2 = indexLanguage2;

            SetupLinks();

            _testView.UpdateLanguageLbl(model.GetLanguage(indexLanguage1), model.GetLanguage(indexLanguage2));

        }

        private void GetRandomWord(object sender, string[] selectedLanguages)
        {
            string[] randomWord;
            randomWord = _model.GetNextRandomWord(_indexLang1, _indexLang2);
        }

        private void SetupLinks()
        {
            _testView.OnNextWordRequested += GetRandomWord;
            _testView.OnNextWordRequested += CheckingTranslation;
            _testView.OnExitRequested += ExitProgram;
        }

        private void CheckingTranslation(object sender,string[] forChecking)
        {
            bool result;
            result = _model.CheckingTranslation(forChecking, _indexLang1, _indexLang2);
            OnTranslationChecked?.Invoke(this, result); //hier hören alle zu die an dem Ergebnis interessiert sind z.B Stats
        }

        public void Run()
        {
            _testView.Show();
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
