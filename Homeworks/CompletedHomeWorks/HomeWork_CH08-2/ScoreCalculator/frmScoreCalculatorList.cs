namespace ScoreCalculator
{
    public partial class frmScoreCalculatorList : Form
    {
        public frmScoreCalculatorList()
        {
            InitializeComponent();
        }

        float average = 0;
        int total = 0;
        int count = 0;
        //int[] scores = new int[10];
       List<int> scoresList = new List<int>(new int[10]);

        
        
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int score = Convert.ToInt32(txtScore.Text);

                scoresList[count] = score;
                count++;

                
                /*foreach (int s in scoresList)
                {
                    total += s;
                }*/

                total = scoresList.Sum();

                average = total / count;

                txtScoreTotal.Text = total.ToString();
                txtScoreCount.Text = count.ToString();
                txtAverage.Text = average.ToString();

                txtScore.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset
            total   = 0;
            average = 0;
            count   = 0;
            scoresList = new List <int>(new int[10]); // replace current array with new empty array

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string scoresString = "";

            scoresList.Sort();
            foreach (int s in scoresList)
            {
                if (s != 0)
                {
                    scoresString += s.ToString() + "\n";
                }
            }
            MessageBox.Show(scoresString, "Sorted Scores");
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}