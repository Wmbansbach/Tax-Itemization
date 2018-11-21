using System;
using System.Collections;
using Microsoft.VisualBasic.FileIO;


namespace RBWINDOW_SOURCE_NOV_2017
{
    /// <summary>
    ///     CSV FILE PARSING UTILITIES
    /// </summary>
    class FileParser
    {
        private ArrayList infoArray = new ArrayList();

        public ArrayList Load
        {
            get
            {
                return infoArray;
            }
        }

        public FileParser(string path)
        {
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                // PROCESS HEADERS, ADD TO NEW OBJECTS
                string[] headers = parser.ReadFields();
                for (int i = 0; i < headers.Length; i++)
                {
                    Fields headerObj = new Fields(headers[i]);
                    infoArray.Add(headerObj);
                }
                while (!parser.EndOfData)
                {
                    // PROCESS DATA, ADD TO NEW OBJECT'S LIST
                    string[] fields = parser.ReadFields();
                    for (int i = 0; i <= fields.Length; i++)
                    {
                        try
                        {
                            Fields Object = (Fields)infoArray[i];
                            Object.fieldArray.Add(fields[i]);
                        }
                        catch (ArgumentOutOfRangeException) { }
                    }
                }
            }
        }
    }
}
