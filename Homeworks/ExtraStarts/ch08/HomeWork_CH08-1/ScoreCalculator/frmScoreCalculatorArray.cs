using static System.Formats.Asn1.AsnWriter;

namespace ScoreCalculator
{
    public partial class frmScoreCalculatorArray : Form
    {
        public frmScoreCalculatorArray()
        {
            InitializeComponent();
        }
        // declare global variables

        
        int total       = 0;
        int count       = 0;
        float average   = 0;



        // declaring global constants

        int[] scoresArray = new int[10];

        //declaring const and initializing
        const int MAX = 100;
        const int MIN = 0;
        const int arraySize = 10;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* int score = Convert.ToInt32(txtScore.Text);

             total += score;
             count += 1;
             int average = total / count;

             txtScoreTotal.Text = total.ToString();
             txtScoreCount.Text = count.ToString();
             txtAverage.Text = average.ToString();
            */


            try
            {

                if (ValidData())
                {
                    int score = Convert.ToInt32(txtScore.Text);

                    // store the score entered in the array
                    scoresArray[count] = score;



                    count++;


                    // adds all scores
                    total = scoresArray.Sum();

                    //gets the average of the scores entered
                    average = (float)total / count;

                    //display 
                    txtScoreTotal.Text = total.ToString();      //Display scores total
                    txtScoreCount.Text = count.ToString();      //Display scores count
                    txtAverage.Text = average.ToString("n2");   //Display scores avg
                }


            }
            catch (Exception exe)
            {
                ShowMessage(exe.Message, "ERROR");

            }


            txtScore.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DisplayScores();
        }




        private bool ValidData()
        {
            string errMsg = "";

            string score = txtScore.Text;

            errMsg += IsPresent(score);  // checks if user did entered a score
            errMsg += IsInt32(score);   // checks the input score 

            // checks the input, must be between 0-100
            errMsg += IsInRange(score, MIN, MAX);

            if (errMsg != "")
            {
                ShowMessage(errMsg, "ERROR");
                return false;
            }
            return true;

        }

        private string IsInRange(string score, int min, int max)
        {
            string msg = "";

            bool input = int.TryParse(score, out int enteredScore);


            //if input is <0 or >100, send error message
            if ((enteredScore < min) || (enteredScore > max))
            {
                msg = "Input Score Must Be Between 0 - 100. \n";
            }

            return msg;
        }

        private string IsPresent(string score)
        {
            string msg = "";

            if (score == "")
            {
                msg = "No Score was Entered.\n";

            }

            return msg;
        }

        private string IsInt32(string score)
        {
            string msg = "";

            bool inputScore = int.TryParse(score, out _);


            if (!inputScore)
            {
                msg = "Input Score Must Be a Valid Integer. \n";

            }

            return msg;

        }



        private void DisplayScores()
         {

             string scoreS = "";


           /* foreach (int score in scoresArray) 
            {
                scoreS += score + "\n";
            }*/


             for (int i = 0; i < count; i++)
             {

                 scoreS += scoresArray[i].ToString() + "\n";

                 // 
             }
             MessageBox.Show(scoreS, "Sorted Scores",
                  MessageBoxButtons.OK);

            txtScore.Focus();
         }
        

        private void ShowMessage(string errMsg, string title)
        {
            MessageBox.Show(errMsg, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            count = 0;

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

             total = 0;
             count = 0;
             average = 0;

            Array.Clear( scoresArray,0, arraySize );
            //Array.Resize(ref scoresArray, newSize: arraySize);

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}