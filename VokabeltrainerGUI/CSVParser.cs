﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace VokabeltrainerGUI
{
    public class CSVParser : IStorage
    {
        private string filePath = @"..\\..\\Übersetzungen.csv";
        //private VocabularyModel _translationList;



        public CSVParser()
        {

        }


        //wenn vokabeln hinzugefügt werden sollen hier die Vokabeln auf die CSV angehängt werden
        //Model verändern und dann ganzes neues Model hierherschicken und speichern 

        #region wordMethods
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

        #region statsMethods

        public void loadStatsFromCSV()
        {
            throw new NotImplementedException();
        }

        public void saveStatasToCSV()
        {
            throw new NotImplementedException();
        }

        public void saveWordsToCSV()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
