using System;
using System.Windows.Forms;

namespace HomeWork_CH05_03
{
    public partial class IncomeTaxCalc : Form
    {
        public IncomeTaxCalc()
        {
            InitializeComponent();
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //validate users input
            validateInput();
        }

        private void validateInput() 
        {
            //decalaring and initializing users input
            decimal usersInput = 0;

            bool validateNow = decimal.TryParse((txtTaxIncome.Text).Trim(), out usersInput);

            if (!validateNow)
            {
                showInvalidMessage();
            }
            else if ((usersInput <= 0))
            {
                showInvalidMessage();
            
            }
            else
            {
                calculateTax(usersInput);
            }

            return;
        
        }

        private void showInvalidMessage() 
        {
            MessageBox.Show("Invalid Input! Please enter > 0 numbers.",
                            "Invalid Input",
                            MessageBoxButtons.OK,
                             MessageBoxIcon.Error);

            txtTaxIncome.Focus();
            return;
        }

        private void calculateTax( decimal userIncome) 
        {
            decimal taxOwed = 0;

            if (userIncome < 11000m)
            {
                taxOwed = userIncome * 0.10m;
            }

            else if (userIncome >= 11000.00m)
            {
                taxOwed = 1100m + (userIncome * 0.12m);
            }
             if (userIncome >= 44725.00m) 
            {
                taxOwed = 5147m + (userIncome * 0.22m);
            }



            // display tax owed 
            txtTaxOwed.Text = taxOwed.ToString("c");

            txtTaxIncome.Focus();
            return;
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void clearScreen() 
        {

            txtTaxIncome.Text = "";
            txtTaxOwed.Text = "";

            txtTaxIncome.Focus();
            return;
        }
    }
}
