using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT1_TShirtsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   

            //When clicked Get the number of shirts ordered
            int shirtsOrdered = int.Parse(txtShirtNumbers.Text);

            const decimal TAXpercentage           = 0.08m;    // tax percentage 8%
            const decimal SHIRTprice    = 14.99m;   // a shirt price 
            //decimal tax                 = 00.00m;   // tax var

            decimal subTotal = 0.0m;


            // solve and get the total price, tax 
             subTotal = shirtsOrdered * SHIRTprice;
            decimal tax = subTotal * TAXpercentage;
            decimal total = subTotal + tax;

            //print or diplay the values 

            txtTax.Text = tax.ToString("c");
            txtSubTotal.Text = subTotal.ToString("c");
            txtGrandTotal.Text = total.ToString("c");
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text        = "";
            txtAddress.Text     = "";
            txtCity.Text        = "";
            txtState.Text       = "";
            txtZipCode.Text     = "";
            txtShirtNumbers.Text = "";
            txtSubTotal.Text = "";
            txtTax.Text = "";
            txtGrandTotal.Text = "";

            txtName.Focus();
        }

        private void txtShirtNumbers_TextChanged(object sender, EventArgs e)
        {

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

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Form1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
