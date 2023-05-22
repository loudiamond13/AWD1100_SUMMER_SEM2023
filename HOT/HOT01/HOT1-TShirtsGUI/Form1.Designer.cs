namespace HOT1_TShirtsGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblNumShirt = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTaxableTotal = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtShirtNumbers = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Name = "lblName";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblAddress, "lblAddress");
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Name = "lblAddress";
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblCity, "lblCity");
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Name = "lblCity";
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblState, "lblState");
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Name = "lblState";
            this.lblState.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblZipCode
            // 
            this.lblZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblZipCode, "lblZipCode");
            this.lblZipCode.ForeColor = System.Drawing.Color.Black;
            this.lblZipCode.Name = "lblZipCode";
            // 
            // lblNumShirt
            // 
            this.lblNumShirt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblNumShirt, "lblNumShirt");
            this.lblNumShirt.ForeColor = System.Drawing.Color.Black;
            this.lblNumShirt.Name = "lblNumShirt";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblSubTotal, "lblSubTotal");
            this.lblSubTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubTotal.Name = "lblSubTotal";
            // 
            // lblTaxableTotal
            // 
            this.lblTaxableTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblTaxableTotal, "lblTaxableTotal");
            this.lblTaxableTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTaxableTotal.Name = "lblTaxableTotal";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.lblGrandTotal, "lblGrandTotal");
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotal.Name = "lblGrandTotal";
            // 
            // btnCalculate
            // 
            resources.ApplyResources(this.btnCalculate, "btnCalculate");
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.HideSelection = false;
            this.txtName.Name = "txtName";
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTax.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtTax, "txtTax");
            this.txtTax.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTax.HideSelection = false;
            this.txtTax.Name = "txtTax";
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtSubTotal, "txtSubTotal");
            this.txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSubTotal.HideSelection = false;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
            // 
            // txtShirtNumbers
            // 
            this.txtShirtNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtShirtNumbers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShirtNumbers.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtShirtNumbers, "txtShirtNumbers");
            this.txtShirtNumbers.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtShirtNumbers.HideSelection = false;
            this.txtShirtNumbers.Name = "txtShirtNumbers";
            this.txtShirtNumbers.TextChanged += new System.EventHandler(this.txtShirtNumbers_TextChanged);
            // 
            // txtZipCode
            // 
            this.txtZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipCode.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtZipCode, "txtZipCode");
            this.txtZipCode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtZipCode.HideSelection = false;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtZipCode_TextChanged);
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtState, "txtState");
            this.txtState.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtState.HideSelection = false;
            this.txtState.Name = "txtState";
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtCity, "txtCity");
            this.txtCity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCity.HideSelection = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAddress.HideSelection = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txtGrandTotal, "txtGrandTotal");
            this.txtGrandTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtGrandTotal.HideSelection = false;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnClear;
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtShirtNumbers);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblTaxableTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblNumShirt);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblNumShirt;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTaxableTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtShirtNumbers;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}

