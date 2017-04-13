using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Assignment
{
    public partial class Form1 : Form
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
        bool[] boolsButtonPresssed = new bool[19];

        // Prediction.
        string Str_KeyStrokes;

        // Is the line from the list that has the highest useage
        int intPredictedIndex;
        int intNumberOfCharacters;
        int intPredictedLength;

        string Mode;
        string MultiPress = "Multi-Press";
        string Prediction = "Prediction";
        

        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            ModeMultiPress();
        }
    }
}
