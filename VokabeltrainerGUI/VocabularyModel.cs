using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    class VocabularyModel
    {
        //presenter bekommt von hier wörter

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

        public string GetLanguage(int index)
        {
            return Languages[index];
        }

        #region methods

        public string[] GetNextRandomWord(int firstLangIndex, int secLangIndex)
        {
            bool wordInside = true;
            string[] randomWord = new string[2];

            do
            {
                var random = new Random();
                int index = random.Next(VocabularyList.Count);
                Vocabulary randomTranslation = VocabularyList[index];
                randomWord[0] = randomTranslation.Translations[firstLangIndex];
                randomWord[1] = randomTranslation.Translations[secLangIndex];

            } while (!wordInside);


            return randomWord;
        }

        public void LoadFromCSV()
        {
            VocabularyList = _csvParser.loadWordsFromCSV();
            Languages = _csvParser.getLanguages();
        }

        public void AddWord(Vocabulary newVocabulary)
        {
            VocabularyList.Add(newVocabulary);
            Languages = newVocabulary.GetLanguages();
        }


        public bool CheckingTranslation(string[] words, int indexLanguage1, int indexLanguage2)
        {
            string correctTranslation;
            try
            {
                correctTranslation = VocabularyList.Find(x => x.Translations[indexLanguage1].Contains(words[0])).GetTranslations(indexLanguage2);
            }
            catch (Exception)
            {
                throw;
            }

            if (correctTranslation == words[1])
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
