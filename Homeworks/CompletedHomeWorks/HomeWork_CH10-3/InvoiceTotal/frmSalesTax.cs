using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {
        public frmSalesTax()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsValidData())
                {
                    frmInvoiceTotal frmInvoiceTotal = new frmInvoiceTotal();



                    frmInvoiceTotal.SalesTaxPct = Convert.ToDecimal(txtNewPercent.Text);


                    frmInvoiceTotal.ShowDialog();
                    this.Close();

                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "ERROR!");
            }

        }


        public bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += IsPresent(txtNewPercent.Text, "New Tax Percent");
            errorMessage += IsDecimal(txtNewPercent.Text, "New Tax Percent");
            errorMessage += IsWithinRange(txtNewPercent.Text, "Percent", 0, 10);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        public string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = $"{name} is a required field.\n";
            }
            return msg;
        }

        public string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = $"{name} must be a valid decimal value.\n";
            }
            return msg;
        }

        public string IsWithinRange(string value, string name, decimal min,
        decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = $"{name} must be between {min} and {max}.\n";
                }
            }
            return msg;
        }

        private void frmSalesTax_Load(object sender, EventArgs e)
        {
            txtNewPercent.Focus();
        }
    }
}
