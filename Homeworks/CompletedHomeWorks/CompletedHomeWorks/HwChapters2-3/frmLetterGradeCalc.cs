using System;
using System.Windows.Forms;

/*  Extra 2-1 Design a simple form

    In this exercise, you’ll design a form that lets the user enter 
    a number grade and then displays the letter grade when the user clicks the
    Calculate button.
*/

namespace HwChapters2_3
{
    public partial class frmLetterGradeCalc : Form
    {
        public frmLetterGradeCalc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberGrade.Text = "";
            txtLetterGrade.Text = "";
            txtNumberGrade.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);

            string letterGrade = "";

            if (numberGrade >= 88)
            {

                letterGrade = "A";
            }

            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }

            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }

            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }

            else
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;
            txtNumberGrade.Focus();
        }

        private void frmLetterGradeCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
