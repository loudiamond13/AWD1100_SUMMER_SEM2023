using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Scanner
{
    public partial class frmNetworkScanner : Form
    {
        public frmNetworkScanner()
        {
            InitializeComponent();
        }

        //global arrays

        //ip address array 
        string[] ipAdd = {"127.0.0.1", "8.8.8.8",  "47.44.246.80" };

        //computer name array
        string[] computerName = {"My-Computer", "google-public-dns-a", "ranken.edu" };

        //services array

        string[] services = {
            "20: FTP_DATA \n21: FTP_CONTROL \n23: TELNET\n25: SMTP \n53: DNS \n80: HTTP \n123: NTP \n389: LDAP \n443: HTTPS",
            "53: DNS",
            "25: SMTP \n80: HTTP \n443: HTTPS"
        
        };


        private void btnExit_Click(object sender, EventArgs e)
        {
            exitYESNO();
        }


        private void exitYESNO()
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
            clearAll();
        }

        private void clearAll() 
        {
            txtIPaddress.Text = "";
            txtShowIP.Text = "";
            txtComputerName.Text = "";
            lblServicesResult.Text = "";

            txtIPaddress.Focus();
            return;
        
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            //txtShowIP.Text = "asd";
            //lblServices.Text = services[0].ToString();

            scanIPaddress(txtIPaddress.Text);
        }


        private void scanIPaddress(string IPadd)
        {
            txtComputerName.Text = "";

            for (int i = 0; i < ipAdd.Length; i++)
            {

                // if input address exist, make a new computer class
                if (ipAdd[i] == IPadd)
                {
                    // input info
                    Computer computer1 = new Computer(computerName[i], ipAdd[i], services[i]);

                    showComputer(computer1);
                }
                
            }

            // if IP add not found, show timed out 
            if (txtComputerName.Text == "")
            {
                txtComputerName.Text = "Request Timed Out!";
                lblServicesResult.Text = "NONE";
                txtShowIP.Text = txtIPaddress.Text;
            }

            return;
        }


        private void showComputer(Computer computer) 
        {
            //display result
            txtShowIP.Text          = computer.IpAddress;
            txtComputerName.Text    = computer.Name;
            lblServicesResult.Text  = computer.Services;

            txtIPaddress.Focus();
            return;
        }
    }


}
