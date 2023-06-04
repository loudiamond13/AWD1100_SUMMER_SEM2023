namespace HomeWork_CH06_1
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
            this.lblOP1 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblOP2 = new System.Windows.Forms.Label();
            this.lblRslt = new System.Windows.Forms.Label();
            this.txtOP1 = new System.Windows.Forms.TextBox();
            this.txtOP2 = new System.Windows.Forms.TextBox();
            this.txtRslt = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cboOperation = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOP1
            // 
            this.lblOP1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP1.Location = new System.Drawing.Point(12, 15);
            this.lblOP1.Name = "lblOP1";
            this.lblOP1.Size = new System.Drawing.Size(192, 54);
            this.lblOP1.TabIndex = 6;
            this.lblOP1.Text = "Operand 1 :";
            this.lblOP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(33, 108);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(171, 54);
            this.lblOperator.TabIndex = 7;
            this.lblOperator.Text = "Operator :";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOP2
            // 
            this.lblOP2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP2.Location = new System.Drawing.Point(12, 200);
            this.lblOP2.Name = "lblOP2";
            this.lblOP2.Size = new System.Drawing.Size(192, 54);
            this.lblOP2.TabIndex = 8;
            this.lblOP2.Text = "Operand 2 :";
            this.lblOP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRslt
            // 
            this.lblRslt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRslt.Location = new System.Drawing.Point(33, 273);
            this.lblRslt.Name = "lblRslt";
            this.lblRslt.Size = new System.Drawing.Size(171, 54);
            this.lblRslt.TabIndex = 9;
            this.lblRslt.Text = "Result : ";
            this.lblRslt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOP1
            // 
            this.txtOP1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOP1.Location = new System.Drawing.Point(210, 20);
            this.txtOP1.Multiline = true;
            this.txtOP1.Name = "txtOP1";
            this.txtOP1.Size = new System.Drawing.Size(292, 57);
            this.txtOP1.TabIndex = 0;
            this.txtOP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOP1.TextChanged += new System.EventHandler(this.txtOP1_TextChanged);
            // 
            // txtOP2
            // 
            this.txtOP2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOP2.Location = new System.Drawing.Point(210, 205);
            this.txtOP2.Multiline = true;
            this.txtOP2.Name = "txtOP2";
            this.txtOP2.Size = new System.Drawing.Size(292, 57);
            this.txtOP2.TabIndex = 2;
            this.txtOP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRslt
            // 
            this.txtRslt.Enabled = false;
            this.txtRslt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRslt.Location = new System.Drawing.Point(210, 278);
            this.txtRslt.Multiline = true;
            this.txtRslt.Name = "txtRslt";
            this.txtRslt.Size = new System.Drawing.Size(292, 57);
            this.txtRslt.TabIndex = 5;
            this.txtRslt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboOperation
            // 
            this.cboOperation.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperation.FormattingEnabled = true;
            this.cboOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cboOperation.Location = new System.Drawing.Point(210, 115);
            this.cboOperation.Name = "cboOperation";
            this.cboOperation.Size = new System.Drawing.Size(121, 47);
            this.cboOperation.TabIndex = 1;
            this.cboOperation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(12, 366);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(244, 62);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(288, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 62);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cboOperation);
            this.Controls.Add(this.txtRslt);
            this.Controls.Add(this.txtOP2);
            this.Controls.Add(this.txtOP1);
            this.Controls.Add(this.lblRslt);
            this.Controls.Add(this.lblOP2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOP1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOP1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblOP2;
        private System.Windows.Forms.Label lblRslt;
        private System.Windows.Forms.TextBox txtOP1;
        private System.Windows.Forms.TextBox txtOP2;
        private System.Windows.Forms.TextBox txtRslt;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cboOperation;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

