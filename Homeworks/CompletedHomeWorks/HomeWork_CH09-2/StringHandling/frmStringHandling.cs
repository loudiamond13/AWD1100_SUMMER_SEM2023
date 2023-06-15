using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StringHandling
{
    public partial class frmStringHandling : Form
    {
        public frmStringHandling()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (IsValidData())
                {
                    string email = txtEmail.Text;


                    getUserNameAndDomain(email);                
                }
            
            }
            catch(Exception exe) 
            {

                MessageBox.Show(exe.Message, "ERROR");

            }
        }


        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // Validate the email txt box
            errorMessage += IsPresentAndValid(txtEmail.Text, "Email Address");


            if (errorMessage != "")
            {

                MessageBox.Show(errorMessage, "Invalid Input! ");
                success = false;
            
            }

            return success;
        }

        private string IsPresentAndValid(string value, string name)
        {
            string msg = "";

            // check input email
            if (value.Trim() == "" ||
                !value.Contains("@"))
            {

                msg = "Email Must Be Valid! ex: asdasd@example.com. \n";
            }
        
            return msg;
        }


        private void getUserNameAndDomain(string value) 
        {

            value = value.Trim();
            string[] splittedEmail = value.Split("@");  // split emails before and after "@"
            
            frmParsedString form = new frmParsedString();
            form.userName   = splittedEmail[0];
            form.domain     = splittedEmail[1];

            form.ShowDialog();
       
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            /*string  city    = txtState.Text.Trim();
            string  state   = txtState.Text.Trim();
            int     zipCode = Convert.ToInt32(txtZipCode.Text);*/

            string cityStateZip = txtCity.Text + ", " + 
                                  txtState.Text.ToUpper()+", " 
                                  + txtZipCode.Text;
            
            frmFormattedString form = new frmFormattedString();
            form.address = cityStateZip;

            form.ShowDialog(this);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}