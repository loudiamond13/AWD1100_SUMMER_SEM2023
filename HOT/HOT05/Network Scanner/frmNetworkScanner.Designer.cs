namespace Network_Scanner
{
    partial class frmNetworkScanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIPaddress = new System.Windows.Forms.Label();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.txtShowIP = new System.Windows.Forms.TextBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblServicesResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIPaddress
            // 
            this.lblIPaddress.Location = new System.Drawing.Point(46, 32);
            this.lblIPaddress.Name = "lblIPaddress";
            this.lblIPaddress.Size = new System.Drawing.Size(178, 43);
            this.lblIPaddress.TabIndex = 8;
            this.lblIPaddress.Text = "IP Address";
            this.lblIPaddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Location = new System.Drawing.Point(51, 78);
            this.txtIPaddress.Multiline = true;
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(500, 46);
            this.txtIPaddress.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnScan.Location = new System.Drawing.Point(588, 78);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(155, 46);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtComputerName
            // 
            this.txtComputerName.Enabled = false;
            this.txtComputerName.Location = new System.Drawing.Point(51, 156);
            this.txtComputerName.Multiline = true;
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(418, 46);
            this.txtComputerName.TabIndex = 4;
            this.txtComputerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtShowIP
            // 
            this.txtShowIP.Enabled = false;
            this.txtShowIP.Location = new System.Drawing.Point(51, 233);
            this.txtShowIP.Multiline = true;
            this.txtShowIP.Name = "txtShowIP";
            this.txtShowIP.Size = new System.Drawing.Size(418, 46);
            this.txtShowIP.TabIndex = 5;
            this.txtShowIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblServices
            // 
            this.lblServices.Location = new System.Drawing.Point(46, 327);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(178, 43);
            this.lblServices.TabIndex = 6;
            this.lblServices.Text = "Services";
            this.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServicesResult
            // 
            this.lblServicesResult.Location = new System.Drawing.Point(46, 386);
            this.lblServicesResult.Name = "lblServicesResult";
            this.lblServicesResult.Size = new System.Drawing.Size(402, 298);
            this.lblServicesResult.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(588, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(588, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 46);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmNetworkScanner
            // 
            this.AcceptButton = this.btnScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 722);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblServicesResult);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.txtShowIP);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtIPaddress);
            this.Controls.Add(this.lblIPaddress);
            this.Name = "frmNetworkScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIPaddress;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.TextBox txtShowIP;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblServicesResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

