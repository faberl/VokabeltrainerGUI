using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    class VocabularyModel
    {
        #region members
        private IStorage _csvParser;
        private List<Vocabulary> _vocabularyList;
        #endregion

        #region constructor 
        public VocabularyModel()
        {

        }

        public VocabularyModel(IStorage csvParser)
        {
            _vocabularyList = new List<Vocabulary>();
            _vocabularyList = VocabularyList;
            _csvParser = csvParser;
        }
        #endregion

        #region properties
        public List<Vocabulary> VocabularyList { get; private set; }
        public string[] Languages { get; private set; }
        #endregion

        #region methods

        public string GetLanguageWithIndex(int index)
        {
            return Languages[index];
        }

        public string GetNextRandomWord(int firstLangIndex, int secLangIndex)
        {
            bool wordInside = false;
            string randomWord;

            do
            {
                var random = new Random();
                int index = random.Next(VocabularyList.Count);
                Vocabulary randomTranslation = VocabularyList[index];
                randomWord = randomTranslation.Translations[firstLangIndex];
                if (randomWord == "")
                {
                    wordInside = false;
                }
                else
                {
                    wordInside = true;
                }

            } while (!wordInside);

            return randomWord;
        }

        public void LoadFromCSV()
        {
            VocabularyList = _csvParser.loadWordsFromCSV();
            Languages = _csvParser.getLanguages();
        }

        public bool CheckingTranslation(Tuple<string,string> words, int indexLanguage1, int indexLanguage2)
        {
            string correctTranslation;
            try
            {
                correctTranslation = VocabularyList.Find(x => x.Translations[indexLanguage1].Contains(words.Item1)).GetTranslations(indexLanguage2);
            }
            catch (Exception)
            {
                throw;
            }

            if (correctTranslation == words.Item2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
