using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    interface IStorage
    {
        void saveWordsToCSV();
        void loadWordsFromCSV();
        void loadStatsFromCSV();
        void saveStatasToCSV();

    }
}
