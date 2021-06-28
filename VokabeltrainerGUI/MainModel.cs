using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VokabeltrainerGUI
{
    class MainModel 
    {
        private IStorage _csvParser;

        public MainModel(IStorage csvParser)
        {
            _csvParser = csvParser;
        }

        #region properties
        public string[] Languages { get; private set; }
        #endregion


        public string[] GetLanguages()
        {
            Languages = _csvParser.getLanguages();
            return Languages;
        }
    }
}
