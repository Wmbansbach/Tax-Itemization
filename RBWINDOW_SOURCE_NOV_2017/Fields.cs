using System;
using System.Collections;


namespace RBWINDOW_SOURCE_NOV_2017
{
    /// <summary>
    ///     STORAGE CLASS FOR EACH ELEMENT IN FILE
    ///     objname REFERS TO HEADER NAME
    ///     fieldArray REFERS TO ARRAY CONTAINING EACH VALUE AFTER
    /// </summary>
    class Fields
    {
        private string objName;
        public ArrayList fieldArray = new ArrayList();

        // CONSTRUCTOR USED FOR FILEPARSER CLASS
        public Fields(string name)
        {
            objName = name;
        }

        // CONSTRUCTOR USED FOR DUPLICATE OBJ CLASS
        public Fields(string key, double value, int fLength)
        {
            objName = key;
            for (int i = 0; i < fLength - 1; i++)
            {
                fieldArray.Add("NaN");
            }
            fieldArray.Add(value.ToString());
        }

        public Fields(string key, double value)
        {
            objName = key;
            fieldArray.Add(value.ToString());
        }

        public string getName
        {
            get { return objName; }
        }
    }
}
