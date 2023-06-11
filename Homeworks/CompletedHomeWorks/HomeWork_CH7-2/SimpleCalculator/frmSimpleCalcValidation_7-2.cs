namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declaring and initializing const
        const int MAX = 1000000;
        const int MIN = 0;



        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //declaring and initializing 
            string message = "";

            decimal operand1 = 0; //Convert.ToDecimal(txtOperand1.Text);
            string operator1 = "";//txtOperator.Text;
            decimal operand2 = 0;//Convert.ToDecimal(txtOperand2.Text);

          //  ValidEntry();
           
            try 
            {
                if (ValidEntry()) 
                {
                    operand1 = Convert.ToDecimal(txtOperand1.Text);
                    operator1 = txtOperator.Text;
                    operand2 = Convert.ToDecimal(txtOperand2.Text);
                    
                    //if all inputs are valid, calculate inputs
                    Calculate(operand1, operator1, operand2);


                }

            }
            catch (Exception ex)
            {
               ShowMessages($"Error : {message}\n{ex.Message}\n", "ERROR");
            
            }

            

            //IsPresent(operand1,operator1, operand2);


            //result

          
            


            /*
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format. Please check all entries.",
                    "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Overflow error. Please enter smaller values.",
                    "Entry Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Divide-by-zero error. Please enter a non-zero value for operand 2.",
                    "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }*/
        }

        private bool ValidEntry( )
        {
            //initialize and declaring
            string ErrMess = "";
            
            string operatoR = txtOperator.Text;
            string num1     = txtOperand1.Text.Trim();
            string num2     = txtOperand2.Text.Trim();

            // validate inputs
            ErrMess += IsPresent( num1, num2);
            ErrMess += IsDecimal(num1, num2);
            ErrMess += IsWithInRange(num1, num2, MAX, MIN);
            ErrMess += IsOperator(operatoR);
            ErrMess += IsValidOperation(operatoR, num2);

            if (ErrMess != "")
            {
                ShowMessages($"ERROR : {ErrMess}\n", "ERROR MESSAGES!");

                return false;

            }
           
            
            return true;
        }


        private string IsPresent( string num1, string num2)
        {
            string mess = "";

           // bool asd = decimal.TryParse(txtOperand1.Text, out _);
            
            // if one of the inputs or both are empty, send error message
            if (num1 == "" || num2 == "") 
            {
                mess = "\nOperand 1 or/and Operand 2 Must not be EMPTY! \n";
            }

            return mess;
        }

        private string IsDecimal(string num1, string num2)
        {
            // check the input
            string mess = "";

            if ((!decimal.TryParse(num1, out _)) || 
                (!decimal.TryParse(num2, out _)))
            {
                mess = "Operand 1 and/or Operand 2 Must be valid decimals! \n";
            }
                

            return mess;
        
        }

        private string IsWithInRange(string num1, string num2, int max, int min) 
        {
            string mess = "";

            decimal input1;
            decimal input2;

            bool operand1 = decimal.TryParse(num1, out input1);
            bool operand2 = decimal.TryParse(num2, out input2);

            
                // check if inputs are between 0 - 1,000,000
            if ((input1 < min) || 
            (input2 < min) ||
            (input2 > max) ||
            (input1 > max))
            {

                mess = "Inputs must be between 0 - 1,000,000 \n";
            
            }

            return mess;
        }


        private string IsOperator(string op) 
        {
            string errMess = "";

            //checks the operator
            if ((op != "*") &&
                (op != "+") &&
                (op != "-") &&
                (op != "/"))
            {

                errMess = "Operator must be +, -, /, or *. \n";
            }
        
            return errMess;
        }

        private string IsValidOperation(string op, string num2)
        {
            string errMess = "";

            bool input2 = decimal.TryParse(num2, out decimal denominator);
            
            
            if(op == "/") 
            { 
                if (denominator == 0)// checks the denominator if divide operator
                {
                    errMess = "Can not divide by 0!";
                }
             }
            return errMess;
        }

        private void Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;


            result = Math.Round(result, 4);
            txtResult.Text = result.ToString();
            txtOperand1.Focus();

           // return;
        }

        private void ClearResult(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowMessages(string message, string title) 
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        
        }
    }
}