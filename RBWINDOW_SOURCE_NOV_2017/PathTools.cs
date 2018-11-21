using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace RBWINDOW_SOURCE_NOV_2017
{
    /// <summary>
    ///     PATH MANIPULATION UTILITY
    ///     CONTAINS ALL METHODS TO MOVE PATHS
    /// </summary>
    class PathTools
    {
        protected bool exists = true;
        protected string sourceFile;

        public string PointToPath()
        {
            ///<summary>
            /// POINT THE APPLICATION TO WHERE .csv IS STORED
            /// </summary>
            string curDirectory;
            string[] curDirectoryArray;

            curDirectory = Directory.GetCurrentDirectory();

            curDirectoryArray = curDirectory.Split('\\');
            curDirectoryArray[0] += "\\";

            curDirectory = Path.Combine(curDirectoryArray[0], curDirectoryArray[1],
                                        curDirectoryArray[2], "Documents", "RABTAX");

            return curDirectory;
        }

        public ArrayList File_Exist(string path, GetDate dateClass)
        {
            ///<summary>
            /// CHECK IF A FILE FOR THE CURRENT YEAR EXISTS
            /// </summary>
            /// 
            var date = dateClass.Now;
            var year = dateClass.Year;

            ArrayList infoArray = new ArrayList();

            path = Path.Combine(path, "RABTAX" + year + ".csv");

            sourceFile = path;

            // IF PATH EXISTS - READ CONTENT
            if (File.Exists(path))
            {
                FileParser fpObj = new FileParser(path);
                infoArray = fpObj.Load;
            }
            else
            {
                // BOOLEAN CHANGED TO SIGNIFY FILE DOES NOT EXIST
                // NEW FILE IS CREATED
                exists = false;
                CreateDirectory(path);
            }
            return infoArray;
        }

        public void CreateDirectory(string File)
        {
            ///<summary>
            /// CREATE A NEW DIRECTORY IF ONE DOES NOT EXIST
            /// </summary>
            string path;

            path = Path.GetDirectoryName(File);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        // GETTERS
        public bool Exists
        {
            get { return exists; }
        }

        public string GetPath
        {
            get { return sourceFile; }
        }
    }
}
