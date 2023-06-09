using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HOT3GUILists
{
    public partial class frmHOT03GUIlists : Form
    {
        public frmHOT03GUIlists()
        {
            InitializeComponent();
        }
        // initializing and declaring the global lists
        // 

        List<string> first_names = new List<string>() 
                                { "Markel", "Luiza", "Byrony", "Giraldo", "Lowri" };

        List<string> last_names = new List<string>()
                                { "Diggory", "Gunnar", "Hester", "Addy", "Hari"  };

        List<decimal> salaryList = new List<decimal>() 
                                { 54321.00M, 88732.00M, 66778.00M, 33445.00M, 99883.00M  };


        //declaring and initializing global const
        const decimal MAXsalary = 100000m;
        const decimal MINsalary = 25000m;


        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramYESNO();
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

            return;
        }


        private void btnSearchByFname_Click(object sender, EventArgs e)
        {
            string firstName = txtInput.Text;
            SearchByFirstName(firstName);
        }


        private void btnSearchByLname_Click(object sender, EventArgs e)
        {

            string lastName = txtInput.Text;
            SearchByLastName(lastName) ;

        }

        private void btnSearchBySalary_Click(object sender, EventArgs e)
        {
            string salary = txtInput.Text;
            SearchBySalary(salary);
        }



        private void SearchByFirstName(string fName) 
        {
            checksFirstNameOrLastName(fName);


            // if firstname input is not empty search input in lists
           if(fName != "")
            { 
                // check if input is in the list
                for (int i = 0; i < first_names.Count; i++)
                {
                    if (first_names[i].ToString().ToLower().Contains(fName.ToString().ToLower()))
                    {
                        // if input is in the array, show infos
                        DisplayResult(i);
                        return;
                    }

                }

                // if not found in the list, show not found
                NoResult();
            }
           
        }

        private void SearchByLastName(string lName) 
        {
            checksFirstNameOrLastName(lName);

            if (lName != "")
            {
                // check if input is in the list
                for (int i = 0; i < first_names.Count; i++)
                {
                    if (last_names[i].ToString().ToLower().Contains(lName.ToString().ToLower()))
                    {
                        // if input is in the array, show infos
                        DisplayResult(i);
                        return;
                    }

                }

                // if not found in the list, show not found
                NoResult();
            }
        }



        private void checksFirstNameOrLastName(string name)
        {
            try
            {
                // checks input string for lastnames or fnames
                CheckInputString(name);

                
                
            }
            catch
            {
                //if not successful try
                // show error message
                ShowMessageString();
                ClearAll();

            }

        }

        private void SearchBySalary(string salary)
        {
            CheckSalary(salary);

            if (salary != "")
            {
                // check if input is in the list
                for (int i = 0; i < first_names.Count; i++)
                {
                    if (salaryList[i].ToString().ToLower().Contains(salary.ToString().ToLower()))
                    {
                        // if input is in the array, show infos
                        DisplayResult(i);
                        return;
                    }

                }

                // if not found in the list, show not found
                NoResult();
            }
        }

        private void CheckSalary(string inputSalary) 
        {
            decimal salary = 0;

            try 
            {
                // if input is empty throw error message
                if (inputSalary.Trim() == "")
                {
                    throw new FormatException();
                }

                //if input salary is not in range 25k-100k
                // throw error
                salary = Convert.ToDecimal(inputSalary);
                if ((salary < MINsalary) || (salary > MAXsalary))
                {
                    throw new ArgumentOutOfRangeException();
                }
            
            }
            catch(ArgumentOutOfRangeException)
            {
                ShowMessageSalary();
                ClearAll() ;
            }
            
            catch(FormatException) 
            {
                ShowMessageSalary() ;
                ClearAll() ;
            }
        }



        private void CheckInputString(string name) 
        {
            // check if input is empty or not
            if (name.Trim() == "")
            {
                //if input is empty, throw error
                throw new FormatException();
            }
            //if input name is not string, throw error 
            else if (decimal.TryParse(name, out _))
            {
                throw new FormatException();
            }
        }



        private void ShowMessageString() 
        {
            MessageBox.Show(
                "The input text box is Empty or Invalid \n" +
                "It Must Be Letters / String!",
                       "ERROR",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            return;
        }

        private void ShowMessageSalary()
        {
            MessageBox.Show(
                "The input text box is Empty or Invalid \n" +
                "It Must Be Valid Salary!" +
                " \n(25,000 - 100,000)",
                       "ERROR",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            return;
        }



        private void DisplayResult(int index) 
        {
            // display infos
            txtFname.Text = first_names[index];
            txtLname.Text = last_names[index];
            txtSalary.Text = salaryList[index].ToString("c");

            txtInput.Focus();
            return;
        }


        private void NoResult() 
        {
            //dislay no record found
            txtFname.Text = "No Record Found!";
            txtLname.Text = "No Record Found!";
            txtSalary.Text = "No Record Found!";

            txtInput.Focus();
            return;
        }

       
    }
}
