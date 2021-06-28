using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    public class Vocabulary
    {
        #region members
        public string[] _languages;
        public string[] _translations;
        #endregion

        #region constructor
        public Vocabulary()
        {

        }
        public Vocabulary(string[] languages, string[] translations)
        {
            _languages = languages;
            _translations = translations;
        }
        #endregion


        #region properties
       
        public string[] Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                _languages = value;
            }
        }
       
        public string[] Translations
        {
            get
            {
                return _translations;
            }
            set
            {
                _translations = value;
            }
        }
        #endregion


        #region methods
        //return a choosen word of a translation
        public string GetTranslations(int index)
        {
            return Translations[index];
        }      

        //returns all current Languages
        public string[] GetLanguages()
        {
            return _languages;
        }
        #endregion
    }
}
