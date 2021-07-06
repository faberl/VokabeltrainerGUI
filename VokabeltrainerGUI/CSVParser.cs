using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace VokabeltrainerGUI
{
    public class CSVParser : IStorage
    {
        #region members
        private string filePath = @"..\\..\\Übersetzungen.csv";
        #endregion

        #region constructor
        public CSVParser()
        {

        }
        #endregion

        #region methods
        public List<Vocabulary> loadWordsFromCSV()
        {
            List<Vocabulary> vocabularyList = new List<Vocabulary>();
            string[] languagesArray;
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string readedLanguages = reader.ReadLine();
                    languagesArray = readedLanguages.Split(';');
                    string[] translations = new string[languagesArray.Length];

                    while (reader.Peek() > 0)
                    {
                        string line = reader.ReadLine();
                        if (!line.StartsWith(languagesArray[0]))
                        {
                            translations = line.Split(';');
                            Vocabulary newVocabulary = new Vocabulary(languagesArray, translations);
                            vocabularyList.Add(newVocabulary);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return vocabularyList;
        }

        public string[] getLanguages()
        {
            string[] languagesArray;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string readedLanguages = reader.ReadLine();
                languagesArray = readedLanguages.Split(';');
                string[] translations = new string[languagesArray.Length];

                while (reader.Peek() > 0)
                {
                    string line = reader.ReadLine();
                    if (!line.StartsWith(languagesArray[0]))
                    {
                        translations = line.Split(';');
                        Vocabulary newVocabulary = new Vocabulary(languagesArray, translations);
                    }
                }
            }
            return languagesArray;
        }


        #endregion


    }
}
