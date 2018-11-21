using System;
using System.Collections.Generic;

namespace RBWINDOW_SOURCE_NOV_2017
{
    /// <summary>
    ///     CREATE NEW STORAGE DICTIONARY VARIABLE AND GETTER
    /// </summary>
    class DictUtility
    {
        private Dictionary<string, double> expenses = new Dictionary<string, double>();

        public Dictionary<string, double> getExpense
        {
            get { return expenses; }
        }

        public void add(string name, double value)
        {
            expenses.Add(name, value);
        }
    }
}
