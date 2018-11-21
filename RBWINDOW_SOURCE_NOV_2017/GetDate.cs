using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBWINDOW_SOURCE_NOV_2017
{
    /// <summary>
    ///     DATE MANAGEMENT CLASS
    /// </summary>
    class GetDate
    {
        private string date, year;
        private string[] dateSplit;

        public GetDate()
        {
            // GET FORMATTED DATE
            date = DateTime.Now.ToString("M/d/yyyy");
            dateSplit = date.Split('/');
            year = dateSplit[2];
        }

        // GETTERS FOR DATE NOW AND YEAR
        public string Now
        {
            get
            {
                return date;
            }
        }
        public string Year
        {
            get
            {
                return year;
            }
        }
    }
}
