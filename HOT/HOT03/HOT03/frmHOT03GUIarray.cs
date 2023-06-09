using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT03
{
    public partial class frmHOT03GUIarray : Form
    {
        public frmHOT03GUIarray()
        {
            InitializeComponent();
        }

        //declaring the global arrays
        string[] first_names = { "Markel", "Luiza", "Byrony", "Giraldo", "Lowri" };

        string[] last_names = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };

        decimal[] salary = { 54321.00M, 88732.00M, 66778.00M, 33445.00M, 99883.00M };


        // initializing and declaring min and max salary const
        const decimal MAXsalary = 100000.00m;
        const decimal MINsalary = 25000.00m;
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            ExitProgramYESNO();
        }


        // exit function (Yes or No)
        private void ExitProgramYESNO()
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
            ClearAll();
        }

        // clears ALl
        private void ClearAll()
        {
            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtInput.Text = string.Empty;

            txtInput.Focus();
            return;
            
        }

        // checks if there is anything in the input
        private string isPresent(string val, string name, Control ctrl)
        {
            string message = "";

            // if nothing, show error
            if (val == "")
            {
                message = name + " is required field. \n";
                SetTheFocusToCorrectControl(ctrl);
            }
            return message;
        }

        //chechs if valid salary
        private string isDecimal(string val, string name, Control ctrl)
        {

            string message = "";

            // if not, show error
            if (Decimal.TryParse(val, out _))
            {
                message = name + " must be valid salary. \n";
                SetTheFocusToCorrectControl(ctrl);
            }
            return message;

        }

        // checks if input salart is between 25k - 100k
        private string IsInRange(string val, string name, decimal min, decimal max,  Control ctrl)
        {

            string message = "";
            decimal salary = 0m;


            //  if salary is not between 25k - 100k, show error
            if (Decimal.TryParse(val, out salary))
            {
                if ((salary < min) || (salary > max))
                { 
                    message = name + " must be valid salary. (25,000 - 100,000)\n";
                    SetTheFocusToCorrectControl(ctrl);
                }
            }

            return message;

        }


        // if input is empty show error message
        private void ShowError(string message)
        {
            if (message != "")
            {
                showMessage(message, "ERROR");

                ClearAll();
                return;
            }
        }

        //clears the control and focus
        private void SetTheFocusToCorrectControl(Control ctrl)
        {
            ctrl.Text = string.Empty;
            ctrl.Focus();
        }

        // shows error message (customized) 
        private void showMessage(string message, string title)
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }


        //  searching by FirstName
        private void btnSearchByFname_Click(object sender, EventArgs e)
        {
            SearchByFirstName();

           
        }

        // searching by last name
        private void btnSearchByLname_Click_1(object sender, EventArgs e)
        {
            SearchByLastName();
            return;
        }




        // searching by salary
        private void btnSearchBySalary_Click(object sender, EventArgs e)
        {
            SearchBySalary();
            return;
        }
        private void SearchByFirstName()
        {
            string input = txtInput.Text; // taking input

            string message = isPresent(input.Trim(), "First Name", txtInput);

            // if firstname is empty show error
            ShowError(message);

            // if input fname is valid check if it exist in the array of fname
            if (message == "")
            {

            
                for (int i = 0; i < first_names.Length; i++)
                {
                    // if input exist, select and display info's
                    if (first_names[i].ToLower().Contains(input.ToLower()))
                    {
                        //returns and display the result inquiry
                        displayResultData(i);
                        return;
                    }
               
                }
                // if not in the array, display not found
                noDisplay();
            }
        }



        private void SearchByLastName()
        {
            string input = txtInput.Text; // taking input

            //checks if there is anything in input box
            string message = isPresent(input.Trim(), "Last Name", txtInput);

            // if lastname is empty show error
            ShowError(message);


            // if input last name is valid check if it exist in the array of last name
            if (message == "")
            {


                for (int i = 0; i < last_names.Length; i++)
                {
                    // if input exist, select and display info's
                    if (last_names[i].ToLower().Contains(input.ToLower()))
                    {
                        //returns and display the result inquiry
                        displayResultData(i);
                        return;
                    }

                }
                // if not in the array, display not found
                noDisplay();
            }
        }

        private void SearchBySalary()
        {

             
            string input = txtInput.Text; // getting the input

            string message = isPresent(input.Trim(), "Salary", txtInput);
            
            // if salary is empty show error
            ShowError(message);


            if (message == "") // if there is input salary, check if its in range.
            {

                // checks if salary is valid
                message = IsInRange(input.Trim(), "Salary", MINsalary, MAXsalary, txtInput);

                // if input salary is not in range
                ShowError(message);
            }

            // if input salary is valid check if it exist in the array of salary
            if (message == "")
            {


                for (int i = 0; i < salary.Length; i++)
                {
                    // if input exist, select and display info's
                    if ((salary[i].ToString().ToLower()).Contains(input.ToString().ToLower()))
                    {
                        //returns and display the result inquiry
                        displayResultData(i);
                        return;
                    }

                }
                // if not in the array, display not found
                noDisplay();
            }
        }


        private void displayResultData(int i) // displays the result on what ever matches from input
        {
            txtFname.Text = first_names[i];
            txtLname.Text = last_names[i];
            txtSalary.Text = salary[i].ToString("c");

            txtInput.Focus();
            return;
        }

        private void noDisplay()
        {

            
            txtFname.Text = "No Record Found!";
            txtLname.Text = "No Record Found!";
            txtSalary.Text ="No Record Found!";

           // txtInput.BackColor = Color.Red;
           
            //txtLname.ForeColor = Color.Red;


            txtInput.Focus();
            return;
        }


    }
}
