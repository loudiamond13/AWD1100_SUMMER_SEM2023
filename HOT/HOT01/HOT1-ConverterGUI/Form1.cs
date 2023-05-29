using System;
using System.Windows.Forms;

namespace HOT1_ConverterGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnConvert_Click(object sender, EventArgs e, float text)
        {
            

            
         }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDistance.Text = "";
            lblAns.Text = "";
            txtDistance.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal inches = 0.0m;






            // take the input value
             inches = Convert.ToDecimal(txtDistance.Text);
            //declaring variables
            decimal CM_PER_IN = 2.54m;


            //get the answer
            decimal converted = inches * CM_PER_IN;

            //print the answer
            lblAns.Text = inches + " inches is " + converted.ToString("n2") + " centimeters.";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
