using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    interface IStorage
    {
        void parseVocabularyFromCSV();
        List<Vocabulary> load();
    }
}
