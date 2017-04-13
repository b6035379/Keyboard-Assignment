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

namespace Keyboard_Assignment
{
    public partial class Form_MainWindow : Form
    {
        // Flags changes made and thus file needs saving 
        bool booleanRequiresSaving = false;

        // The Path to the 'Dictionary'
        string strPresentFilePathName = "";

        // Timing Functionality
        bool boolFirstVisit = true;
        int intIntervalRequired = 500;

        // Global ListBox can be place on the Form instead of here. 
        ListBox lstGlobalListbox = new ListBox();
        int intMyListIndex = 0;

        // Buttons. Identifies which button is being selected be the user. 
        bool[] boolButtonPresssed = new bool[18];

        // Prediction.
        string Str_KeyStrokes;

        // Is the line from the list that has the highest useage
        int intPredictedIndex;
        int intNumberOfCharacters;
        int intPredictedLength;

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
        }

        private void OnTick(object sender, EventArgs e)
        {
            //On tick (timer elapsed), enter the letter selected in the array
            BackColor = Color.Red;
            timer1.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {

                timer1.Enabled = false;
                timer1.Enabled = true;
            }

            else
            {
                timer1.Enabled = true;

            }
        }
    }
}
