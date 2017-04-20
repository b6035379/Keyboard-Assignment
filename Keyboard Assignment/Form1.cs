using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyDialogs;


namespace Keyboard_Assignment
{
    public partial class Form_MainWindow : Form
    {

        // Flags changes made and thus file needs saving 
        bool booleanRequiresSaving = false;


        // The path to the file
        string strPresentFilePathName = "";

        // Timing Functionality
        bool boolFirstVisit = true;
        int intIntervalRequired = 500;

        // Global ListBox can be place on the Form instead of here. 
        ListBox lstGlobalListbox = new ListBox();
        int intMyListIndex = 0;

         string strCurrentFileName = ""; //instance variable

        //Character Buttons Array
        string[] button1Array = { "p", "q", "r", "s", "1", "P", "Q", "R", "S" };
        string[] button2Array = { "t", "u", "v", "2", "T", "U", "V" };
        string[] button3Array = { "w", "x", "y", "z", "3", "W", "X", "Y", "Z" };
        string[] button4Array = { "g", "h", "i", "4", "G", "H", "I" };
        string[] button5Array = { "j", "k", "l", "5", "J", "K", "L" };
        string[] button6Array = { "m", "n", "o", "6", "M", "N", "O" };
        string[] button7Array = { ".", ",", "\"", "7", "'", ":", ";" };
        string[] button8Array = { "a", "b", "c", "8", "A", "B", "C" };
        string[] button9Array = { "d", "e", "f", "9", "D", "E", "F" };
        string[] buttonHashArray = { "#", "-", "_" };
        string[] buttonAsterixArray = { "*", "-", "_" };


        // Buttons. Identifies which button is being selected be the user. 
        bool[] boolButtonPresssed = new bool[18];

        // Prediction.
        string Str_KeyStrokes;

        // Is the line from the list that has the highest useage
        int intPredictedIndex;
        int intNumberOfCharacters;
        int intPredictedLength;
        int intTimesClicked = -1;

        //
        string strCharChosen;

        string Mode;
        string MultiPress = "Multi-Press";
        string Prediction = "Prediction";


        public Form_MainWindow()
        {
            InitializeComponent();
        }

        private void ModeMultiPress()
        {
            txtStatus.Clear();
            Mode = MultiPress;
            txtStatus.Text = "Multi-Press";
        }

        private void ModePrediction()
        {
            txtStatus.Clear();
            Mode = Prediction;
            txtStatus.Text = "Prediction";
        }

        /*private void ButtonClicked()
        {
            timer1.Enabled = false;
            timer1.Enabled = true;
            intTimesClicked = intTimesClicked + 1;
            Index = -1 + intTimesClicked;
        }*/

        /* private void CycleThrough()
         {
             if (Index < 6)
             {
                 ButtonClicked();
             }
             else
             {
                 Reset();
                 ButtonClicked();
             }
         }*/


        private void btnMode_Click(object sender, EventArgs e)
        {
            if (Mode == Prediction)
            {
                ModeMultiPress(); //Calls Multi-Press Class
            }
            else
            {
                ModePrediction(); //Calls Prediction Class
            }
        }

        private void Form_MainWindow_Load(object sender, EventArgs e)
        {
            ModeMultiPress();
            timer1.Interval = intIntervalRequired;
        }


        public void timer1_Tick(object sender, EventArgs e)
        {
            //On tick (timer elapsed), enter the letter selected in the array
            timer1.Enabled = false;
            boolFirstVisit = true;
            intTimesClicked = -1;

            for (int ArrayNumber = 0; ArrayNumber < boolButtonPresssed.Length; ArrayNumber++)
            {
                boolButtonPresssed[ArrayNumber] = false;
            }
        }

        private void txtNotepad_TextChanged(object sender, EventArgs e)
        {
           booleanRequiresSaving = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtNotepad.AppendText(Environment.NewLine);
        }

        private void btn000_Click(object sender, EventArgs e)
        {
            txtNotepad.AppendText(rtxtBuilder.Text + " ");
            Str_KeyStrokes = string.Empty;
            rtxtBuilder.Clear();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[1] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }
            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[1] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button1Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button1Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button1Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "1";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[2] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[2] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button2Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button2Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button2Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "2";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[3] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[3] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button3Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button3Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button3Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "3";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[4] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[4] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button4Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button4Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button4Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "4";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[5] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[5] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button5Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button5Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button5Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "5";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[6] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[6] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button6Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button6Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button6Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "6";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[7] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[7] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button7Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button7Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button7Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "7";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[8] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[8] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button8Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button8Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button8Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "8";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }


        private void btn9_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[9] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[9] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < button9Array.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % button9Array.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (button9Array[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "9";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }


        private void btnAsterix_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[11] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[11] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < buttonAsterixArray.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % buttonAsterixArray.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (buttonAsterixArray[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "*";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }


        private void btnHash_Click(object sender, EventArgs e)
        {
            if (boolButtonPresssed[12] == false)
            {
                timer1_Tick(null, null); //Force the timer to tick
            }

            //restart the timer
            timer1.Enabled = false;
            timer1.Enabled = true;
            boolButtonPresssed[12] = true;


            if (timer1.Enabled == true) //start timer cycle
            {
                if (intTimesClicked < buttonHashArray.Length)
                {
                    intTimesClicked = (intTimesClicked + 1) % buttonHashArray.Length; //increase the value of intTimesClicked by for the length of the buttons associated array.
                    strCharChosen = (buttonHashArray[intTimesClicked]); //set variable as the character selected at the current element.
                }
                else
                {
                    intTimesClicked = -1;
                }
                //if its the first time the button has been pressed during this timer, add the chosen character.
                if (boolFirstVisit == true)
                {
                    Str_KeyStrokes = Str_KeyStrokes + "#";
                    txtCharChosen.Text = Str_KeyStrokes;
                    rtxtBuilder.AppendText(strCharChosen);
                    boolFirstVisit = false;
                }
                else//if the button is pressed again, remove the previous character, and add the new character.
                {
                    rtxtBuilder.Text = rtxtBuilder.Text.Remove(rtxtBuilder.TextLength - 1, 1);
                    rtxtBuilder.AppendText(strCharChosen);
                }
            }
        }

        private void txtCharChosen_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (strPresentFilePathName != "" && booleanRequiresSaving == true)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            
            else if (strPresentFilePathName =="" && booleanRequiresSaving == true)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }

            else if (booleanRequiresSaving == false)
            {
                strPresentFilePathName = "";
                strCurrentFileName = "";
                txtNotepad.Clear();
                booleanRequiresSaving = false;
                //This gets us the location where the Application is being
                // executed from and this a place where we can create files
                string applicationPath = Directory.GetCurrentDirectory() + "\\";


            }
            /*
            

            //Creates a file on the HDD at the applicationPath location called, "MyFile.txt"
            StreamWriter myOutputStream = File.CreateText(applicationPath + ".txt");

            //Close the file
            myOutputStream.Close();
             */
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strCurrentFileName == "")
            {
                // This redirect it to the Save As function
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                StreamWriter outputStream = File.CreateText(openFileDialog1.FileName);
                outputStream.Write(txtNotepad.Text);
                booleanRequiresSaving = false;
                strPresentFilePathName = Directory.GetCurrentDirectory() + strCurrentFileName;
                outputStream.Close();
            }
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intIntervalRequired = Convert.ToInt32(My_Dialogs.InputBox("Please enter the 'Delay Value' you require. 1000 is equal to a 1 second delay. At present, the 'Delay Value' is set to " + intIntervalRequired + "."));
            timer1.Interval = intIntervalRequired;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strCurrentFileName == "")
            {
                saveFileDialog1.InitialDirectory = "C:\\";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter outputStream = File.CreateText(saveFileDialog1.FileName);
                    outputStream.Write(txtNotepad.Text);
                    strCurrentFileName = saveFileDialog1.FileName;
                    outputStream.Close();
                }
                booleanRequiresSaving = false;
            }
            else
            {
                saveToolStripMenuItem_Click(sender, e);
                booleanRequiresSaving = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            if (strCurrentFileName == "")
            {
                if (booleanRequiresSaving == true)
                {
                    saveToolStripMenuItem_Click(sender, e);
                } 
                
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader inputStream = File.OpenText(openFileDialog1.FileName);
                    txtNotepad.Text = inputStream.ReadToEnd();
                    strCurrentFileName = openFileDialog1.FileName;
                    strPresentFilePathName = Directory.GetCurrentDirectory() + strCurrentFileName;
                    booleanRequiresSaving = false;
                    inputStream.Close();
                }
            }
            else
            {
                // ask user if they wish to save the current file
                saveToolStripMenuItem_Click(sender, e);
            }
        }
    }
}

