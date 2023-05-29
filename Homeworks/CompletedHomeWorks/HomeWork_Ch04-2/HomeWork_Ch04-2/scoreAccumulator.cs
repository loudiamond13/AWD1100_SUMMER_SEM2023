using System;
using System.Linq;
using System.Windows.Forms;

namespace HomeWork_Ch04_2
{

    public partial class scoreAccumulator : Form
    {


        public scoreAccumulator()
        {
            InitializeComponent();

        }


        private void txtScoreTotal_TextChanged(object sender, EventArgs e)
        {

        }
        bool buttonIsClicked = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {


            bool validInput; // local var for checking the input. (false default)

            validInput = checkInput(); // validate input


            // if input is invalid, display error message.
            if (!validInput)
            {
                displayError();
                return;
            }
            else
            {
                calculateGrades();
                txtScore.Focus();
                return;
            }

        }



        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit The Program?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        bool inputAccepted; // global variable for the boolean return

      

        private bool checkInput()
        {


            string input = txtScore.Text; //stores the input
            int isNumber;


            //checks the input if a an integer or not.
            bool inputValid = int.TryParse(input, out isNumber);

            // if input is integer
            if (inputValid)
            {
                //if true integer get convert to integer
                isNumber = int.Parse(input);

                // check if the input is between 0-100
                
                if ((isNumber >= 0) && (isNumber <= 100))
                {

                    inputAccepted = true; //return true if input is between 0-100 
                }
                else if (txtScore.Text.Trim() == "")
                {
                    inputAccepted = false;
                }
                else
                {
                    inputAccepted = false;
                }
            }



            return inputAccepted;

        }

        private void displayError()
        {
            MessageBox.Show("Score Input Must Be Between 0-100",
            "Invalid Input",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);

            txtScore.Text = "";
            txtScore.Focus();
        }

        
        //declaring and initializing global variables 
        int totalScores = 0;    // global var for totalScores

        float averageScore = 0; //  global var averageScore;
        int scoreCounts = 0;    // global var for score counts
        int[] scores = new int[0]; // global array for scores
        private void calculateGrades()
        {


           
            //Adjust the size of the array
            Array.Resize(ref scores, (scores.Length + 1) );
            
            //Add the new input/score into the scores Array
            scores[scores.Length - 1] = int.Parse(txtScore.Text);

            //total scores added or count of the scores
            scoreCounts = scores.Length;
            txtScoreCount.Text = scoreCounts.ToString(); // display result


            // the sum or total of the input/scores
            totalScores = scores.Sum();
            txtScoreTotal.Text = totalScores.ToString(); // display result


            // average of the scores
            averageScore            = totalScores / scores.Length;
            txtAverageScore.Text    = averageScore.ToString();        // display result



        }

        private void scoreAccumulator_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //reseting all
            txtScore.Text = "";
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
            txtAverageScore.Text = "";

            //resets value
            averageScore = 0;
            scoreCounts = 0;
            totalScores = 0;
            Array.Resize(ref scores, newSize: 0);


            txtScore.Select();
        }
    }

    
}
