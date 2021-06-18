using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace VokabeltrainerGUI
{
    public class CSVParser: IStorage
    {
        string filePath = @"";
        

        public CSVParser()
        {
            
        }

        //wenn vokabeln hinzugefügt werden sollen hier die Vokabeln auf die CSV angehängt werden
        //Model verändern und dann ganzes neues Model hierherschicken und speichern 
        public void AddWordsToCSV(string filePath, string[] newTranslation)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    string output = "";
                    foreach (string word in newTranslation)
                    {
                        output += word + ";";
                    }
                    output = output.Remove(output.Length - 1);
                    writer.Write(output);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Soll die CSV Datei einlesen und eine Liste mit Vokabeln zurückgeben
        public List<Vocabulary> parseVocabularyFromCSV()
        {
            List<Vocabulary> translationList = new List<Vocabulary>();
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
                            translationList.Add(new Vocabulary { Languages = languagesArray, Translations = translations });
                        }
                    }
                }
                return translationList;
            }
            catch (Exception)
            {
                throw;
            }
        }


        List<Vocabulary> IStorage.load()
        {
            throw new NotImplementedException();
        }

        void IStorage.parseVocabularyFromCSV()
        {
            throw new NotImplementedException();
        }
    }
}
