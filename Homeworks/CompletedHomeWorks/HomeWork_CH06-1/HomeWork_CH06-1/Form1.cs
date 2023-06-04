using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_CH06_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   cboOperation.FocusIndex = 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            validateInput();
        }

        private void validateInput() 
        {
            //initializing and declaring variables 

            decimal input1 = 0;
            decimal input2 = 0;


            // checking if input 1 and 2 are valid numbers
            bool validateInput1 = decimal.TryParse((txtOP1.Text).Trim(), out input1);
            bool validateInput2 = decimal.TryParse((txtOP2.Text).Trim(),out input2);

            if (!validateInput1 || !validateInput2)
            {
                errorMessage();
            }

            else 
            {
                performOperation(input1, input2);
            }

            txtOP1.Focus();
            return;
        }

        private void errorMessage() 
        {
            MessageBox.Show("Please Enter Valid Numbers! ",
                "Invalid Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            txtOP1.Focus();
            return;
        }

        private void performOperation(decimal input1, decimal input2) 
        {
            // declaring and initialing variables
            string oPerator = cboOperation.Text;
            decimal result = 0;
            string illegal = string.Empty;

            switch (oPerator) 
            {
                case "+":
                    result = input1 + input2;
                    break;

                case "-":
                    result = input1 - input2;
                    break;

                case "*":
                    result = input1 * input2;
                    break;
                case "/":
                    if (input2 == 0)
                    {
                        illegal = "Invalid Devide by 0";
                    }
                    else { 
                    result = input1 / input2;
                    }
                    break;
                default:
                    break;
                    
            
            }

            txtRslt.Text = (illegal != "") ? illegal : result.ToString("n2");
            //Display result

           // txtRslt.Text = input1.ToString() + cboOperation.Text + input2.ToString() + " = " + result.ToString("n4");

            txtOP1.Focus();
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

        private void txtOP1_TextChanged(object sender, EventArgs e)
        {
           // clearTexts();
        }

        private void clearTexts()
        { 
            txtOP1.Text = string.Empty;
          //  txtOP2.Text = string.Empty;
        }
    }
}
