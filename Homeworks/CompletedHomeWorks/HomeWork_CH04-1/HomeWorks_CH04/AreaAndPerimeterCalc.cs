using System;
using System.Windows.Forms;

namespace HomeWorks_CH04
{
    public partial class AreaAndPerimeterCalc : Form
    {
        public AreaAndPerimeterCalc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AreaAndPerimeterCalc_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            //clear all
            txtLength.Text = "";

            txtWidth.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";

            txtLength.Focus();
        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           

                calculateArea();
            calculatePerimeter();



        }


        //validates the input
       

        // calculates the Area
        private void calculateArea()
        {
            //declaring and initializing variables
            decimal length = 0.0m;  
            decimal width = 0.0m;
            decimal area = 0.0m;

            //convert input into decimal 
            length = Decimal.Parse(txtLength.Text);
            width = Decimal.Parse(txtWidth.Text);

            area = length * width;

            // display area result
            txtArea.Text = area.ToString();
        }


        // calculates the perimeter
        private void calculatePerimeter()
        {
            //declaring and initializing variables
            decimal length = 0.0m;
            decimal width = 0.0m;
            decimal perimeter = 0.0m;

            //convert input into decimal 
            length = Decimal.Parse(txtLength.Text);
            width = Decimal.Parse(txtWidth.Text);

            perimeter = length + width;

            perimeter = perimeter * 2;

            // display perimeter result
            txtPerimeter.Text = perimeter.ToString();
            txtLength.Focus();
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
        
    }

}
