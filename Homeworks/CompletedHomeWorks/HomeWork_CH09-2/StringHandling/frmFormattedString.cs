using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class frmFormattedString : Form
    {

        public string address { get; set; }


        public frmFormattedString()
        {
            InitializeComponent();
        }

        private void frmFormattedString_Load(object sender, EventArgs e)
        {
            lblAddress.Text = "City, State, Zip Code: " + address;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
