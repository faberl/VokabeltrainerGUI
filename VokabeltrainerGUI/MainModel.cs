using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabeltrainerGUI
{
    class MainModel 
    {
        #region members
        private IStorage _csvParser;
        #endregion

        #region constructor
        public MainModel(IStorage csvParser)
        {
            _csvParser = csvParser;
        }
        #endregion

        #region properties
        public string[] Languages { get; private set; }
        #endregion

        #region methods
        public string[] LoadLanguagesFromCSV()
        {
            Languages = _csvParser.getLanguages();
            return Languages;
        }
        #endregion


    }
}
