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
        List<Vocabulary> vocabularyList;
        #endregion

        #region constructor 
        public VocabularyModel()
        {
            vocabularyList = new List<Vocabulary>();
        }
        #endregion

        #region methods
        private void AddVocabulary(Vocabulary newVocabular)
        {
            vocabularyList.Add(newVocabular);
        }

        private string GetNextWord()
        {
            return "";
        }

        private void LoadFromCSV()
        {

        }




        #endregion
    }
}
