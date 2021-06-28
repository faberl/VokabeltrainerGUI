using System;
using System.Collections.Generic;
using System.Text;

namespace VokabeltrainerGUI
{
    class Statistics
    {
        //#region members
        //int rightOne;
        //int falseOne;
        //int total;
        //#endregion

        //ohne members sinnvoll??

        #region Constructor
        public Statistics()
        {
            RightOne = 0;
            FalseOne = 0;
            Total = 0;
        }
        #endregion

        #region properties
        public int RightOne { get; private set; }
        public int FalseOne { get; private set; }
        public int Total { get; private set; }
        #endregion

        #region methods

        public void UpdateStats(bool answer)
        {
            if (answer == true)
            {
                RightOne++;
            }
            else
            {
                FalseOne++;
            }

            Total++;
        }
        #endregion

    }
}
