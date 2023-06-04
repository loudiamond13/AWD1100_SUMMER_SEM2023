using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_CH_05_1
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
           



            validateInput(); //validates input
            
          
        }

        private void validateInput() 
        {
            //declaring variables
            
          
            int number;
            
         

            bool validInt = int.TryParse(txtNumber.Text.Trim(), out number);



            if (txtNumber.Text.Trim() == "")
            {
                displayError();
                return;
            }
            //if input is not integer
            else if (!validInt)
            {
                displayError();
                return;
            }
          
            
             
             factorTheNumber(number);
                

               

               

            }


        //error Messsage
        private void displayError()
        {
            MessageBox.Show("THE INPUT MUST BE VALID NUMBER!!!!",
                            "UNACCEPTABLE INPUT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);


            txtNumber.Focus();
            return;
        }

        private void factorTheNumber(int num) 
        {


            long facorialResult = 1;

                // get and convert input value to int.
            int i = 1;      // incrememt var

            while (num != 1)
            { 
                facorialResult *= num;
                num -= 1;
            }
           

           

            txtFactors.Text = facorialResult.ToString("n0");

            txtNumber.Focus();
            return;
        }
    }
}
