namespace HomeWork_CH05_2
{
    partial class Change_Calc
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
            this.lblChange = new System.Windows.Forms.Label();
            this.lblQuarters = new System.Windows.Forms.Label();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblNickels = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.txtCents = new System.Windows.Forms.TextBox();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(8, 41);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(282, 63);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "Change Due (0-99)";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuarters
            // 
            this.lblQuarters.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarters.Location = new System.Drawing.Point(56, 131);
            this.lblQuarters.Name = "lblQuarters";
            this.lblQuarters.Size = new System.Drawing.Size(223, 63);
            this.lblQuarters.TabIndex = 8;
            this.lblQuarters.Text = "Quarters :";
            this.lblQuarters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDimes
            // 
            this.lblDimes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimes.Location = new System.Drawing.Point(56, 221);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(223, 63);
            this.lblDimes.TabIndex = 9;
            this.lblDimes.Text = "Dimes :";
            this.lblDimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNickels
            // 
            this.lblNickels.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickels.Location = new System.Drawing.Point(56, 311);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(223, 63);
            this.lblNickels.TabIndex = 10;
            this.lblNickels.Text = "Nickels :";
            this.lblNickels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPennies
            // 
            this.lblPennies.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPennies.Location = new System.Drawing.Point(56, 401);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(223, 63);
            this.lblPennies.TabIndex = 11;
            this.lblPennies.Text = "Pennies :";
            this.lblPennies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCents
            // 
            this.txtCents.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCents.Location = new System.Drawing.Point(296, 38);
            this.txtCents.Multiline = true;
            this.txtCents.Name = "txtCents";
            this.txtCents.Size = new System.Drawing.Size(282, 66);
            this.txtCents.TabIndex = 0;
            this.txtCents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCents.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQuarters
            // 
            this.txtQuarters.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuarters.Enabled = false;
            this.txtQuarters.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarters.HideSelection = false;
            this.txtQuarters.Location = new System.Drawing.Point(296, 128);
            this.txtQuarters.Multiline = true;
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.Size = new System.Drawing.Size(282, 66);
            this.txtQuarters.TabIndex = 3;
            this.txtQuarters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDimes
            // 
            this.txtDimes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDimes.Enabled = false;
            this.txtDimes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimes.HideSelection = false;
            this.txtDimes.Location = new System.Drawing.Point(296, 218);
            this.txtDimes.Multiline = true;
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.Size = new System.Drawing.Size(282, 66);
            this.txtDimes.TabIndex = 4;
            this.txtDimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNickels
            // 
            this.txtNickels.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNickels.Enabled = false;
            this.txtNickels.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickels.HideSelection = false;
            this.txtNickels.Location = new System.Drawing.Point(296, 308);
            this.txtNickels.Multiline = true;
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.Size = new System.Drawing.Size(282, 66);
            this.txtNickels.TabIndex = 5;
            this.txtNickels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPennies
            // 
            this.txtPennies.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPennies.Enabled = false;
            this.txtPennies.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPennies.HideSelection = false;
            this.txtPennies.Location = new System.Drawing.Point(296, 398);
            this.txtPennies.Multiline = true;
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.Size = new System.Drawing.Size(282, 66);
            this.txtPennies.TabIndex = 6;
            this.txtPennies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPennies.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(62, 543);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 64);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(391, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 64);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Change_Calc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(648, 710);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.txtCents);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblNickels);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.lblQuarters);
            this.Controls.Add(this.lblChange);
            this.Name = "Change_Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblQuarters;
        private System.Windows.Forms.Label lblDimes;
        private System.Windows.Forms.Label lblNickels;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.TextBox txtCents;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

