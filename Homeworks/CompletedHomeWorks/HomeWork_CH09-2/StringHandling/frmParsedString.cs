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

    public partial class frmParsedString : Form
    {

        public string userName { get; set; }
        public string domain { get; set; }


        public frmParsedString()
        {
            InitializeComponent();
        }

        private void frmParsedString_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "User Name: " + userName;
            lblDomain.Text = "Domain: " + domain;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
