using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    class VocabularyModel
    {
        //presenter bekommt von hier wörter
        //methode nextWord

        #region members
        public Vocabulary _vocabulary;
        public string[] _languages;
        private IStorage _csvParser;
        #endregion

        #region constructor 
        public VocabularyModel()
        {

        }

        public VocabularyModel(IStorage csvParser)
        {
            VocabularyList = new List<Vocabulary>();
            _csvParser = csvParser;

        }
        #endregion

        #region properties
        public List<Vocabulary> VocabularyList { get; private set; }
        public string[] Languages { get; private set; }
        #endregion


        #region methods

        public string GetNextRandomWord()
        {
            return "";
        }

        public void LoadFromCSV()
        {
            _csvParser.loadWordsFromCSV();
        }

        public void AddWord(Vocabulary newVocabulary)
        {
            VocabularyList.Add(newVocabulary);
        }

        public string[] GetLanguages()
        {
            Languages = _vocabulary.GetLanguages();

            return Languages;
        }

        public bool CheckingTranslation()
        {

            return false;
        }

        #endregion
    }
}
