using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    interface IStorage
    {
        void saveWordsToCSV();
        List<Vocabulary> loadWordsFromCSV();
        string[] getLanguages();
        void loadStatsFromCSV();
        void saveStatasToCSV();

    }
}
