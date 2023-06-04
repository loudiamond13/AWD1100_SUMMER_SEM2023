namespace HomeWork_CH05_03
{
    partial class IncomeTaxCalc
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
            this.lblTaxIncome = new System.Windows.Forms.Label();
            this.lblTaxOwed = new System.Windows.Forms.Label();
            this.txtTaxIncome = new System.Windows.Forms.TextBox();
            this.txtTaxOwed = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaxIncome
            // 
            this.lblTaxIncome.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxIncome.Location = new System.Drawing.Point(72, 54);
            this.lblTaxIncome.Name = "lblTaxIncome";
            this.lblTaxIncome.Size = new System.Drawing.Size(222, 55);
            this.lblTaxIncome.TabIndex = 4;
            this.lblTaxIncome.Text = "Tax Income : ";
            this.lblTaxIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxOwed
            // 
            this.lblTaxOwed.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxOwed.Location = new System.Drawing.Point(72, 125);
            this.lblTaxOwed.Name = "lblTaxOwed";
            this.lblTaxOwed.Size = new System.Drawing.Size(222, 55);
            this.lblTaxOwed.TabIndex = 5;
            this.lblTaxOwed.Text = "Tax Owed : ";
            this.lblTaxOwed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaxIncome
            // 
            this.txtTaxIncome.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxIncome.Location = new System.Drawing.Point(331, 52);
            this.txtTaxIncome.Multiline = true;
            this.txtTaxIncome.Name = "txtTaxIncome";
            this.txtTaxIncome.Size = new System.Drawing.Size(304, 56);
            this.txtTaxIncome.TabIndex = 0;
            this.txtTaxIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxOwed
            // 
            this.txtTaxOwed.Enabled = false;
            this.txtTaxOwed.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxOwed.Location = new System.Drawing.Point(331, 124);
            this.txtTaxOwed.Multiline = true;
            this.txtTaxOwed.Name = "txtTaxOwed";
            this.txtTaxOwed.Size = new System.Drawing.Size(304, 56);
            this.txtTaxOwed.TabIndex = 3;
            this.txtTaxOwed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalc
            // 
            this.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(12, 290);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(252, 62);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(523, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 62);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(312, 290);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 62);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // IncomeTaxCalc
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTaxOwed);
            this.Controls.Add(this.txtTaxIncome);
            this.Controls.Add(this.lblTaxOwed);
            this.Controls.Add(this.lblTaxIncome);
            this.Name = "IncomeTaxCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaxIncome;
        private System.Windows.Forms.Label lblTaxOwed;
        private System.Windows.Forms.TextBox txtTaxIncome;
        private System.Windows.Forms.TextBox txtTaxOwed;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

