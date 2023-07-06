using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Cracker
{
    public partial class frmPasswordCracker : Form
    {
        public frmPasswordCracker()
        {
            InitializeComponent();
        }

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

        private void btnCrack_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            crackPassword();
        }

        private void crackPassword() 
        {
            //array for hashes
            string[] hashes = 
                {
                "e10adc3949ba59abbe56e057f20f883e",
                "25f9e794323b453885f5181f1b624d0b",
                "d8578edf8458ce06fbc5bb76a58c5ca4",
                "96e79218965eb72c92a549dd5a330112",
                "5f4dcc3b5aa765d61d8327deb882cf99",
                "6eea9b7ef19179a06954edd0f6c05ceb",
                "c8837b23ff8aaa8a2dde915473ce0991",
                "c822c1b63853ed273b89687ac505f9fa",
                "161ebd7d45089b3446ee4e0d86dbcf92",
                "4ece57a61323b52ccffdbef021956754"
            };


            // password array
            string[] passwords =
                { 
                "123456",
                "123456789",
                "qwerty",
                "111111",
                "password",
                "qwertyuiop",
                "123321",
                "google",
                "P@ssw0rd",
                "Tr0ub4dor&3"

            };

            // initializing and declaring var
            string inputHash = txtHash.Text;

            for (int i = 0; i < hashes.Length; i++)
            {
                // if input hash exist in hashes array, make a new password class
                if (hashes[i] == inputHash)
                {
                    Password password = new Password(inputHash, passwords[i]);

                    txtPassword.Text = password.ToString();

                    txtHash.Focus();
                }
                /*if (hashes[i] != inputHash) 
                {
                    txtPassword.Text = "Input Hash Not Found.";
                }*/


            }

            // if 
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Input Hash Not Found.";
                txtHash.Focus();
            }

            return;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll() 
        {
            txtHash.Text        = "";
            txtPassword.Text    = "";

            txtHash.Focus();
            return;
        }
    }
}
