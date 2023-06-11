using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_CH07_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cboOperation.Items.Add("+");
            cboOperation.Items.Add("-");
            cboOperation.Items.Add("/");
            cboOperation.Items.Add("*");
            cboOperation.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           ExitYesOrNo();
        }

        private void ExitYesOrNo()
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

        private void cboOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            validateInput();
        }


        private void validateInput()
        {
            //initializing and declaring variables 

            float input1 = 0;
            float input2 = 0;
            string operation = cboOperation.Text;


            // checking if input 1 and 2 are valid numbers
            bool validateInput1 = float.TryParse((txtOP1.Text).Trim(), out input1);
            bool validateInput2 = float.TryParse((txtOP2.Text).Trim(), out input2);



            try
            {
                if (!validateInput1 || !validateInput2)
                {
                    throw new FormatException();
                }
              
            }
            catch (FormatException)
            {
                errorMessage();

            }
            catch (OverflowException ex)
            {
               txtRslt.Text = ex.Message;
            }
           // 222222222222222222222222222222


            //if valid, perform calculation
                performOperation(input1, input2);
            

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

        private void performOperation(float input1, float input2)
        {
            // declaring and initialing variables
            string oPerator = cboOperation.Text;
            float result = 0;
            //string illegal = string.Empty;

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

                    try
                    {
                       result = input1 / input2;
                    }
                    catch (DivideByZeroException fe)
                    {
                        MessageBox.Show(fe.Message + "");
                        return;
                    }
                    //if (input2 == 0)
                  //  {
                  //      illegal = "Invalid Devide by 0";
                  //  }
                  //  else
                  //  {
                  //      result = input1 / input2;
                 //   }
                    break;
                default:
                    break;


            }

            //display result
            txtRslt.Text = result.ToString("");

            //txtRslt.Text = (illegal != "") ? illegal : result.ToString("n2");
            //Display result

            // txtRslt.Text = input1.ToString() + cboOperation.Text + input2.ToString() + " = " + result.ToString("n4");

            txtOP1.Focus();
            return;

        }
    }
}
