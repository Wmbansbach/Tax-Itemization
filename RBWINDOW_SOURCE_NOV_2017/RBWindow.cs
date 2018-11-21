using System;
using System.Collections;
using System.Windows.Forms;

namespace RBWINDOW_SOURCE_NOV_2017
{
    public partial class RBWindow : Form
    {
        // INITIALIZING MANAGMENT CLASSES FOR LATER USE
        GetDate dateManager;
        PathTools pathManager;
        DictUtility dictManager;
        ManageData dataManager;

        // CREATE MASTER ARRAY FOR FIELD OBJ DATA
        ArrayList csvMaster = new ArrayList();

        // VARIABLES USED FOR INITIAL DIRECTORY PROCESS
        bool fileExists = false;
        string filePath;

        public RBWindow()
        {
            InitializeComponent();
        }

        private void RBWindow_Load(object sender, EventArgs e)
        {
            // CALLED ON WINDOWS LOAD - INTIALIZE ALL CLASS OBJECTS NEEDED'
            // CALL AND RECIEVE PATH FROM DIRECTORY CRAWLER TOOL
            dateManager = new GetDate();
            pathManager = new PathTools();
            dictManager = new DictUtility();
            dataManager = new ManageData();

            filePath = pathManager.PointToPath();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // EVENT CALLED WHEN START BUTTON CLICKED
            // MOVING BOOLEANS TO MAKE APP ELEMENTS VISIBLE / INVISIBLE
            RegularGB.Visible = true;
            ExtrasButton.Visible = true;
            DoneButton.Visible = true;
            StartButton.Enabled = false;

            // FILE_EXISTS WILL PARSE DATA AS WELL RETURN ARRAYLIST TO csvMaster
            csvMaster = pathManager.File_Exist(filePath, dateManager);
            // GRABS BOOLEAN INDICATING IF A FILE EXISTS FROM TOOLS CLASS
            fileExists = pathManager.Exists;
            filePath = pathManager.GetPath;
        }

        private void ExtrasButton_Click(object sender, EventArgs e)
        {
            ExpensesGB.Visible = true;
            MessageBox.Show("Type the name and value of the expense\n" +
                            "Then, type submit to save it. Repeat as needed.\n" +
                            "When finished, click the finished button", "Extra Expenses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExtrasButton.Enabled = false;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (DateTB.Text == "" || AmountTB.Text == "" || GasTB.Text == "")
            {
                MessageBox.Show("Be sure that all Regular Expenses have been filled out...", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RegularGB.Enabled = false;
                ExpensesGB.Enabled = false;
                StartButton.Enabled = false;
                ExtrasButton.Enabled = false;
                DoneButton.Enabled = false;

                // CREATE ARRAY TO STORE TEXTBOX DATA INPUT
                string[] primaryHeaders = new string[3];
                primaryHeaders[0] = DateTB.Text;
                primaryHeaders[1] = AmountTB.Text;
                primaryHeaders[2] = GasTB.Text;
                dataManager.Run(csvMaster, primaryHeaders, dictManager, fileExists, filePath);
                csvMaster = dataManager.getMaster;

                DialogResult userInput = MessageBox.Show("Do you have more to input?", "Finished!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                switch (userInput)
                {
                    case DialogResult.Yes:
                        RBWindow_Reset();
                        break;
                    case DialogResult.No:
                        Close();
                        break;

                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // OBTAINS AND PARSES VALUE TEXT INFORMATION
            // ADDS NAME AND VALUE TO DICTIONARY IN dictUtility OBJECT
            // CLEARS VALUES FOR NEW INPUTS
            double parsedValue;
            double.TryParse(ExpAmountTB.Text, out parsedValue);

            dictManager.add(NameTB.Text, parsedValue);
            NameTB.Clear();
            ExpAmountTB.Clear();
        }

        private void RBWindow_Reset()
        {
            // RESET ENTIRE WINDOW INCLUDING DICTIONARY CONTAINING EXTRA EXPENSES
            // csvMaster IS KEPT WITH UPDATED VARIABLES TO BE USED AGAIN
            RegularGB.Enabled = true;
            ExpensesGB.Enabled = true;
            StartButton.Enabled = true;
            ExtrasButton.Enabled = true;
            DoneButton.Enabled = true;

            DateTB.Clear();
            AmountTB.Clear();
            GasTB.Clear();
            dictManager.getExpense.Clear();
        }
    }
}
