using System;
using System.Collections;
using System.IO;

namespace RBWINDOW_SOURCE_NOV_2017
{
    /// <summary>
    ///     DATA MANAGMENT UTILITY 
    ///     CONTAINS FUNCTIONS WHICH CREATE NEW FILES, ADD NEW INFORMATION,
    ///     RECONCILE DUPLICATES, AND WRITE TO
    ///     FILE IN .CSV FORMAT
    /// </summary>
    class ManageData
    {
        private const double taxes = 0.20;
        private string[] expenseArray;
        private string sourcePath;
        private bool Exists;
        private double deduction;
        private int maxIndex;

        private DictUtility expenseObj;

        private ArrayList masterArray = new ArrayList();
        private ArrayList duplicateArray = new ArrayList();
        private ArrayList Expenses = new ArrayList();


        public void Run(ArrayList csvArray, string[] xpenses,
            DictUtility dictHolder, bool fileExists, string filePath)
        {
            // TRANSFER PARAMS TO LOCAL VARIABLES
            masterArray = csvArray;
            expenseObj = dictHolder;
            expenseArray = xpenses;
            
            double.TryParse(expenseArray[1], out deduction); // PARSE STRING DATA TO DOUBLE FOR ARITH
            deduction = deduction * taxes; // PERFORM ARITH TO GET 20% TAX DEDUCTION
            deduction = Math.Round(deduction, 2); // ROUND TO TWO SIG-FIGS
            Exists = fileExists;
            sourcePath = filePath;

            if (fileExists)
            {
                // DuplicateCheck() IS CALLED AFTER AddData(),
                // HELPS FORMATTING
                AddData();
                DuplicateCheck();
            }
            else
            {
                AddData();
                ExtraExpenses(0);
            }
            ToCsv();
        }

        public void ExtraExpenses(int length)
        {
            ///<summary>
            /// ADDS DICTIONARY ITEMS DIRECTLY 
            /// TO ARRAY IF NO ARRAY EXISTS
            /// </summary>
            var expDictionary = expenseObj.getExpense;

            if (expDictionary.Count != 0)
            {
                if (Exists)
                {
                    foreach (var item in expDictionary)
                    {
                        Fields fObj = new Fields(item.Key, item.Value, length);
                        masterArray.Add(fObj);
                    }
                }
                else
                {
                    foreach (var item in expDictionary)
                    {
                        Fields fObj = new Fields(item.Key, item.Value);
                        masterArray.Add(fObj);
                    }
                }
            }
        }

        public void DuplicateCheck()
        {
            ///<summary>
            /// CHECKS FOR DUPLICATE EXPENSES WITHIN ARRAY
            /// </summary>
            var expDictionary = expenseObj.getExpense;
            int ind = 0;
            while (ind < masterArray.Count)
            {
                try
                {
                    foreach (var key in expDictionary.Keys)
                    {
                        Fields Obj = (Fields)masterArray[ind];
                        if (key.Equals(Obj.getName))
                        {//     IF DUPLICATE IS FOUND - ADD VALUE TO OBJECT'S LIST
                            Obj.fieldArray.Add(expDictionary[key]);
                            expDictionary.Remove(key);
                        }
                    }
                }
                catch (InvalidOperationException) { break; }
                ind++;
            }
            ExtraExpenses(maxIndex);
        }

        public void AddData()
        {
            ///<summary>
            /// UPDATES OR CREATES DATA IN ARRAY
            /// </summary>
            Fields Obj;

            if (Exists)
            {// IF FILE EXISTS
                Obj = (Fields)masterArray[0];
                maxIndex = Obj.fieldArray.Count;
                maxIndex++;
                // INCREMENT INDEX OBJECT 1 + THE MAXIMUM INDEX
                Obj.fieldArray.Add(maxIndex.ToString());
                // ADD NEW ROW UNDER ITS GIVEN HEADER
                for (int ind = 1; ind < masterArray.Count; ind++)
                {
                    Obj = (Fields)masterArray[ind];
                    switch (Obj.getName)
                    {
                        case "Date":
                            Obj.fieldArray.Add(expenseArray[0]);
                            break;
                        case "Payment":
                            Obj.fieldArray.Add(expenseArray[1]);
                            break;
                        case "Taxes":
                            Obj.fieldArray.Add(deduction.ToString());
                            break;
                        case "Miles":
                            Obj.fieldArray.Add(expenseArray[2]);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                // CREATE NEW HEADERS AND UPDATE THE FIRST ROW
                Obj = new Fields("0");
                Obj.fieldArray.Add("1");
                masterArray.Add(Obj);

                Obj = new Fields("Date");
                Obj.fieldArray.Add(expenseArray[0]);
                masterArray.Add(Obj);

                Obj = new Fields("Payment");
                Obj.fieldArray.Add(expenseArray[1]);
                masterArray.Add(Obj);

                Obj = new Fields("Taxes");
                Obj.fieldArray.Add(deduction.ToString());
                masterArray.Add(Obj);

                Obj = new Fields("Miles");
                Obj.fieldArray.Add(expenseArray[2]);
                masterArray.Add(Obj);
            }
        }

        public void ToCsv()
        {
            string newString = "";
            Fields fiObj = (Fields)masterArray[0];
            int maxIndex = fiObj.fieldArray.Count;

            using (var writer = new StreamWriter(sourcePath))
            {
                // FORMAT HEADERS
                for (int i = 0; i < masterArray.Count; i++)
                {
                    Fields fObj = (Fields)masterArray[i];
                    if (i == masterArray.Count - 1)
                    {
                        newString += fObj.getName;
                    }
                    else
                    {
                        newString += fObj.getName + ",";
                    }
                }

                // WRITE HEADERS
                writer.WriteLine(newString); 
                // RINSE
                writer.Flush();
                newString = "";

                // REPEAT FOR EACH FIELD IN THE MASTERARRAY
                for (int counter = 0; counter < maxIndex; counter++)
                {
                    for (int i = 0; i < masterArray.Count; i++)
                    {
                        Fields fObj = (Fields)masterArray[i];
                        if (i == masterArray.Count - 1)
                        {
                            newString += fObj.fieldArray[counter];
                        }
                        else
                        {
                            newString += fObj.fieldArray[counter] + ",";
                        }
                    }
                    writer.WriteLine(newString);
                    writer.Flush();
                    newString = "";
                }
            }
        }
        
        // MASTERARRAY GETTER
        public ArrayList getMaster { get { return masterArray; } }
    }
}
