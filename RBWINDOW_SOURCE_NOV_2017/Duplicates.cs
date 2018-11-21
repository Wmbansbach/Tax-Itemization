using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBWINDOW_SOURCE_NOV_2017
{
    /// <summary>
    ///     STORAGE CLASS FOR DUPLICATE ELEMENTS
    /// </summary>
    class Duplicates
    {
        private string key;
        private double value;

        public Duplicates(string cay, double val)
        {
            key = cay;
            value = val;
        }
        public string getKey
        {
            get { return key; }
        }
        public double getValue
        {
            get { return value; }
        }
    }
}
