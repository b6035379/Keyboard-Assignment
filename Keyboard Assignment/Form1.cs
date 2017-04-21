using System;
using System.IO;
using System.Windows.Forms;
using MyDialogs;

namespace Keyboard_Assignment
{
    public partial class FormMainWindow : Form
    {
        // Flags changes made and thus file needs saving 
        private bool _booleanRequiresSaving;

        // Timing Functionality
        private bool _boolFirstVisit = true;

        private int _intIntervalRequired = 500;
        private int _intNumberOfCharacters;

        // Is the line from the list that has the highest useage
        private int _intPredictedIndex;

        private int _intPredictedLength;
        private int _intTimesClicked = -1;

        private string _mode;


        private string _strCharChosen;

        private string _strCurrentFileName = ""; //instance variable

        // Prediction.
        private string _strKeyStrokes;

        // The path to the file
        private string _strPresentFilePathName = "";


        // Buttons. Identifies which button is being selected be the user. 
        private readonly bool[] boolButtonPresssed = new bool[18];

        //Character Buttons Array
        private readonly string[] button1Array = { "p", "q", "r", "s", "1", "P", "Q", "R", "S" };

        private readonly string[] button2Array = { "t", "u", "v", "2", "T", "U", "V" };
        private readonly string[] button3Array = { "w", "x", "y", "z", "3", "W", "X", "Y", "Z" };
        private readonly string[] button4Array = { "g", "h", "i", "4", "G", "H", "I" };
        private readonly string[] button5Array = { "j", "k", "l", "5", "J", "K", "L" };
        private readonly string[] button6Array = { "m", "n", "o", "6", "M", "N", "O" };
        private readonly string[] button7Array = { ".", ",", "\"", "7", "'", ":", ";" };
        private readonly string[] button8Array = { "a", "b", "c", "8", "A", "B", "C" };
        private readonly string[] button9Array = { "d", "e", "f", "9", "D", "E", "F" };
        private readonly string[] buttonAsterixArray = { "*", "-", "_" };
        private readonly string[] buttonHashArray = { "#", "-", "_" };
        private readonly string MultiPress = "Multi-Press";
        private readonly string Prediction = "Prediction";


        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void ModeMultiPress()
        {
            txtStatus.Clear();
            _mode = MultiPress;
            txtStatus.Text = "Multi-Press";
        }

        private void ModePrediction()
        {
            txtStatus.Clear();
            _mode = Prediction;
            txtStatus.Text = "Prediction";
        }


        private void btnMode_Click(object sender, EventArgs e)
        {
            if (_mode == Prediction)
                ModeMultiPress(); //Calls Multi-Press Class
            else
                ModePrediction(); //Calls Prediction Class
        }

        private void Form_MainWindow_Load(object sender, EventArgs e)
        {
            ModeMultiPress();
            timer1.Interval = _intIntervalRequired;
        }


        public void timer1_Tick(object sender, EventArgs e)
        {
            //On tick (timer elapsed), enter the letter selected in the array
            timer1.Enabled = false;
            _boolFirstVisit = true;
            _intTimesClicked = -1;

            for (int arrayNumber = 0; arrayNumber < boolButtonPresssed.Length; arrayNumber++)
                boolButtonPresssed[arrayNumber] = false;
        }

        private void txtNotepad_TextChanged(object sender, EventArgs e)
        {
            _booleanRequiresSaving = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtNotepad.AppendText(Environment.NewLine);
        }

        private void btn000_Click(object sender, EventArgs e)
        {
            txtNotepad.AppendText(rtxtBuilder.Text + " ");
            _strKeyStrokes = string.Empty;
            rtxtBuilder.Clear();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[1] == false)
                timer1_Tick(null, null); //Force the timer to tick
            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[1] = true;


            if (timer1.Enabled == true) //start timer cycle
            {

                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button1Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button1Array[_intTimesClicked]; //set variable as the character selected at the current element.


                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "1";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[2] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[2] = true;


            if (timer1.Enabled == true) //start timer cycle
            {

                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button2Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button2Array[_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "2";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[3] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[3] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button3Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button3Array[_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "3";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[4] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[4] = true;

            if (timer1.Enabled == true) //start timer cycle
            {

                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button4Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button4Array[_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "4";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[5] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[5] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button5Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button5Array[_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "5";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[6] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[6] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button6Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button6Array[_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "6";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[7] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[7] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button7Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button7Array[_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "7";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[8] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[8] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button8Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button8Array[_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "8";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[9] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[9] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    button9Array
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    button9Array[_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "9";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }


        private void btnAsterix_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[11] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[11] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    buttonAsterixArray
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    buttonAsterixArray
                        [_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "*";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }


        private void btnHash_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[12] == false)
                timer1_Tick(null, null); //Force the timer to tick

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[12] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                _intTimesClicked =
                    (_intTimesClicked + 1) %
                    buttonHashArray
                        .Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                _strCharChosen =
                    buttonHashArray
                        [_intTimesClicked]; //set variable as the character selected at the current element.

                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (_boolFirstVisit == true)
                {
                    _strKeyStrokes = _strKeyStrokes + "#";
                    txtCharChosen.Text = _strKeyStrokes;
                    rtxtBuilder.AppendText(_strCharChosen);
                    _boolFirstVisit = false;
                }
                else //if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(_strCharChosen);
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If the active file is not a new file, and it requires saving,ask if user wishes to save. If yes, then operate the save function.
            if (_strPresentFilePathName != "" && _booleanRequiresSaving == true)
            {
                if (MessageBox.Show("File has not been saved. Do you wish to save?", "File not saved!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // ask user if they wish to save the current file
                    saveToolStripMenuItem_Click(sender, e);
                }
                _strCurrentFileName = "";
                txtNotepad.Clear();
                _booleanRequiresSaving = false;
                _strPresentFilePathName = Directory.GetCurrentDirectory() + "\\"; 
                return;
            }

            // If the active file is a new file, and requires saving, operate the save as function. 
            else if (_strPresentFilePathName == "" && _booleanRequiresSaving == true)
            {
                if (MessageBox.Show("File has not been saved. Do you wish to save?", "File not saved!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // ask user if they wish to save the current file
                    saveToolStripMenuItem_Click(sender, e);
                }
                _strCurrentFileName = "";
                txtNotepad.Clear();
                _booleanRequiresSaving = false;
                _strPresentFilePathName = Directory.GetCurrentDirectory() + "\\"; 
                return;
            }
            /* If the file doesnt need saving, clear saved file name variable, clear the notepad textbox, set the
               bool 'RequiresSaving' back to false, then set the filepath name variable to the current directory */
            else if (_booleanRequiresSaving == false)
            {
                _strCurrentFileName = "";
                txtNotepad.Clear();
                _booleanRequiresSaving = false;
                _strPresentFilePathName = Directory.GetCurrentDirectory() + "\\";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the current file has no name, redirect to the save as function.
            if (_strCurrentFileName == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            /* If the current file has a name, save the notepad values in the file currently opened text file, set requiredsaving to
               false, change the saved filepath name variable to the current directory and file name, then close the save function */
            else
            {
                StreamWriter outputStream = File.CreateText(openFileDialog1.FileName);
                outputStream.Write(txtNotepad.Text);
                _booleanRequiresSaving = false;
                _strPresentFilePathName = Directory.GetCurrentDirectory() + _strCurrentFileName;
                outputStream.Close();
            }
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        { //Open up a input box from MyDialogs.cs and get user to set _intIntervalRequired (the timer delay).
            _intIntervalRequired = Convert.ToInt32(
                My_Dialogs.InputBox(
                    "Please enter the 'Delay Value' you require. 1000 is equal to a 1 second delay. At present, the 'Delay Value' is set to " +
                    _intIntervalRequired + "."));
            timer1.Interval = _intIntervalRequired;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If current file has no name, 
            if (_strCurrentFileName == "")
            {
                //Open save dialog at file path '.C:\\'
                saveFileDialog1.InitialDirectory = "C:\\";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter outputStream = File.CreateText(saveFileDialog1.FileName);
                    outputStream.Write(txtNotepad.Text);
                    _strCurrentFileName = saveFileDialog1.FileName;
                    _booleanRequiresSaving = false;
                    outputStream.Close();
                }

            }
            else //If file has a name, then call the save function instead.
            {
                saveToolStripMenuItem_Click(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_booleanRequiresSaving == true)
            {
                if (MessageBox.Show("File has not been saved. Do you wish to save?", "File not saved!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // ask user if they wish to save the current file
                    saveToolStripMenuItem_Click(sender, e);
                }
                Close();
            }
            else
                Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_strCurrentFileName == "")
            {
                if (_booleanRequiresSaving == true)
                {
                    if (MessageBox.Show("File has not been saved. Do you wish to save?", "File not saved!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // ask user if they wish to save the current file
                        saveToolStripMenuItem_Click(sender, e);
                    }
                    return;
                    }
                    // If booleanRequires saving is still false, 
                    openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader inputStream = File.OpenText(openFileDialog1.FileName);
                        txtNotepad.Text = inputStream.ReadToEnd();
                        _strCurrentFileName = openFileDialog1.FileName;
                        _strPresentFilePathName = Directory.GetCurrentDirectory() + _strCurrentFileName;
                        _booleanRequiresSaving = false;
                        inputStream.Close();
                    }

                }
            }
        }
    }
