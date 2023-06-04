using System;
using System.Windows.Forms;

namespace HomeWork_CH05_2
{
    public partial class Change_Calc : Form
    {
        public Change_Calc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          

            validateInput();

        }

        private void validateInput() 
        {
            //declaring and  taking the input 
            int num;


            bool isValid  = int.TryParse(txtCents.Text.Trim(), out num);

            if (!isValid)  // if input is invalid ( empty, letters, space)
            {
                errorMessage();
            }
            else if (num > 99 || num <= 0)  // if number is over 99 and below 0, show error
            {
                errorMessage();
            }
            //  if valid, do the calculation
            else    
            {
                countCents(num);
            }


            return;
        }

        private void countCents(int cents) 
        {
           // txtDimes .Text = cents.ToString();


            // declaring constants and initializing 
            const int QUARTERval    = 25;
            const int DIMEval       = 10;
            const int NICKELval     = 5;
            const int PENNIESval    = 1;



            int remainder = 0; // remainder holder


            // initializing and declaring the change holder

            int quarters    = 0;
            int dimes       = 0;
            int nickels     = 0;
            int pennies     = 0;


            //calculate if how many dimes could take part from input value
            //25
            quarters    = cents / QUARTERval;
            remainder   = cents % QUARTERval;

            //calculate if how many dimes could take part from input value
            //10
            dimes = remainder / DIMEval;
            remainder %= DIMEval;

            //calculate if how many nickels could take part from input value
            //5
            nickels = remainder / NICKELval;
            remainder %= NICKELval;

            //calculate if how many nickels could take part from input value
            //1
            pennies = remainder / PENNIESval;
          //  remainder %= PENNIESval;



            // display the result!
            txtQuarters.Text = quarters.ToString(); 
            txtDimes.Text = dimes.ToString();
            txtNickels.Text = nickels.ToString();
            txtPennies.Text = pennies.ToString();

            txtCents.Focus();
            return;
        }

        private void errorMessage()
        {
            MessageBox.Show("Please Enter A valid Input Number (1 - 99)",
                "Invalid Input", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        


            txtCents.Focus();
            return;
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
