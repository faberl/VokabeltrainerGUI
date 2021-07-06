using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace VokabeltrainerGUI
{
    class Statistics
    {
        #region members
        private string filePath = @"..\\..\\Results.csv";
        #endregion

        #region Constructor
        public Statistics()
        {
            if (File.Exists(filePath))
            {
                GetExistingStatisticsFromCSV();
            }
            else
            {
                File.Create(filePath);
                TrueOne = 0;
                FalseOne = 0;
            }
     
        }
        #endregion

        #region properties
        public int TrueOne { get; private set; }
        public int FalseOne { get; private set; }
        #endregion
        
        #region private methods
        private void GetExistingStatisticsFromCSV()
        {
            string[] results = new string[2];
            int rightOne;
            int falseOne;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                if (firstLine== null)
                {
                    rightOne = 0;
                    falseOne = 0;
                }
                else
                {
                    results = firstLine.Split(';');
                    int.TryParse(results[0], out rightOne);
                    int.TryParse(results[1], out falseOne);
                }            
            }
            TrueOne = rightOne;
            FalseOne = falseOne;
        }

        private void UpdateCSV()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string output = TrueOne + ";" + FalseOne;
                writer.Write(output);
            }
        }
        #endregion

        #region public methods
        public void UpdateStatisticModel(bool answer)
        {
            if (answer == true)
            {
                TrueOne++;
            }
            else
            {
                FalseOne++;
            }

            UpdateCSV();
        }

        public void DeleteData()
        {
            TrueOne = 0;
            FalseOne = 0;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            
        }

        public int[] GetCurrentStatistic()
        {
            int[] results = new int[2];
            results[0] = TrueOne;
            results[1] = FalseOne;

            return results;
        }
        #endregion

    }
}
