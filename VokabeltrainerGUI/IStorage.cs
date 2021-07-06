using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    interface IStorage
    {
        List<Vocabulary> loadWordsFromCSV();
        string[] getLanguages();

    }
}
