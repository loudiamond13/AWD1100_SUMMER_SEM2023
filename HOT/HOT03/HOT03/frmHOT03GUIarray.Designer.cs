﻿namespace HOT03
{
    partial class frmHOT03GUIarray
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSearchByFname = new System.Windows.Forms.Button();
            this.btnSearchByLname = new System.Windows.Forms.Button();
            this.btnSearchBySalary = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Gray;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(56, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(884, 63);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "First Name, Last Name, or Salary";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(61, 108);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(879, 73);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFname
            // 
            this.lblFname.BackColor = System.Drawing.Color.Gray;
            this.lblFname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFname.Location = new System.Drawing.Point(56, 228);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(324, 63);
            this.lblFname.TabIndex = 2;
            this.lblFname.Text = "First Name : ";
            this.lblFname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLname
            // 
            this.lblLname.BackColor = System.Drawing.Color.Gray;
            this.lblLname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLname.Location = new System.Drawing.Point(56, 340);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(324, 63);
            this.lblLname.TabIndex = 3;
            this.lblLname.Text = "Last Name :";
            this.lblLname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalary
            // 
            this.lblSalary.BackColor = System.Drawing.Color.Gray;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalary.Location = new System.Drawing.Point(56, 459);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(324, 63);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salaray :";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.Silver;
            this.txtFname.Enabled = false;
            this.txtFname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(398, 218);
            this.txtFname.Multiline = true;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(542, 73);
            this.txtFname.TabIndex = 5;
            this.txtFname.Tag = "First Name";
            this.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.Silver;
            this.txtLname.Enabled = false;
            this.txtLname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(398, 330);
            this.txtLname.Multiline = true;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(542, 73);
            this.txtLname.TabIndex = 6;
            this.txtLname.Tag = "Last Name";
            this.txtLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Silver;
            this.txtSalary.Enabled = false;
            this.txtSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(398, 449);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(542, 73);
            this.txtSalary.TabIndex = 7;
            this.txtSalary.Tag = "Salary";
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchByFname
            // 
            this.btnSearchByFname.BackColor = System.Drawing.Color.Gray;
            this.btnSearchByFname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchByFname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByFname.Location = new System.Drawing.Point(990, 70);
            this.btnSearchByFname.Name = "btnSearchByFname";
            this.btnSearchByFname.Size = new System.Drawing.Size(350, 69);
            this.btnSearchByFname.TabIndex = 8;
            this.btnSearchByFname.Text = "Search First Name";
            this.btnSearchByFname.UseVisualStyleBackColor = false;
            this.btnSearchByFname.Click += new System.EventHandler(this.btnSearchByFname_Click);
            // 
            // btnSearchByLname
            // 
            this.btnSearchByLname.BackColor = System.Drawing.Color.Gray;
            this.btnSearchByLname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchByLname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByLname.Location = new System.Drawing.Point(990, 340);
            this.btnSearchByLname.Name = "btnSearchByLname";
            this.btnSearchByLname.Size = new System.Drawing.Size(327, 69);
            this.btnSearchByLname.TabIndex = 9;
            this.btnSearchByLname.Text = "Search Last Name";
            this.btnSearchByLname.UseVisualStyleBackColor = false;
            this.btnSearchByLname.Click += new System.EventHandler(this.btnSearchByLname_Click_1);
            // 
            // btnSearchBySalary
            // 
            this.btnSearchBySalary.BackColor = System.Drawing.Color.Gray;
            this.btnSearchBySalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchBySalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBySalary.Location = new System.Drawing.Point(990, 459);
            this.btnSearchBySalary.Name = "btnSearchBySalary";
            this.btnSearchBySalary.Size = new System.Drawing.Size(327, 69);
            this.btnSearchBySalary.TabIndex = 10;
            this.btnSearchBySalary.Text = "Search Salary";
            this.btnSearchBySalary.UseVisualStyleBackColor = false;
            this.btnSearchBySalary.Click += new System.EventHandler(this.btnSearchBySalary_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(61, 616);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(316, 69);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(624, 616);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(316, 69);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHOT03GUIarray
            // 
            this.AcceptButton = this.btnSearchByFname;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1352, 751);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearchBySalary);
            this.Controls.Add(this.btnSearchByLname);
            this.Controls.Add(this.btnSearchByFname);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblHeader);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmHOT03GUIarray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book -1 Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSearchByFname;
        private System.Windows.Forms.Button btnSearchByLname;
        private System.Windows.Forms.Button btnSearchBySalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}
