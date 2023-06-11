namespace HomeWork_CH07_1
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
            this.txtRslt = new System.Windows.Forms.TextBox();
            this.txtOP2 = new System.Windows.Forms.TextBox();
            this.txtOP1 = new System.Windows.Forms.TextBox();
            this.lblRslt = new System.Windows.Forms.Label();
            this.lblOP2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblOP1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.cboOperation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRslt
            // 
            this.txtRslt.Enabled = false;
            this.txtRslt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRslt.Location = new System.Drawing.Point(264, 277);
            this.txtRslt.Multiline = true;
            this.txtRslt.Name = "txtRslt";
            this.txtRslt.Size = new System.Drawing.Size(292, 57);
            this.txtRslt.TabIndex = 3;
            this.txtRslt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOP2
            // 
            this.txtOP2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOP2.Location = new System.Drawing.Point(264, 204);
            this.txtOP2.Multiline = true;
            this.txtOP2.Name = "txtOP2";
            this.txtOP2.Size = new System.Drawing.Size(292, 57);
            this.txtOP2.TabIndex = 2;
            this.txtOP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOP1
            // 
            this.txtOP1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOP1.Location = new System.Drawing.Point(264, 19);
            this.txtOP1.Multiline = true;
            this.txtOP1.Name = "txtOP1";
            this.txtOP1.Size = new System.Drawing.Size(292, 57);
            this.txtOP1.TabIndex = 0;
            this.txtOP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRslt
            // 
            this.lblRslt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRslt.Location = new System.Drawing.Point(87, 272);
            this.lblRslt.Name = "lblRslt";
            this.lblRslt.Size = new System.Drawing.Size(171, 54);
            this.lblRslt.TabIndex = 9;
            this.lblRslt.Text = "Result : ";
            this.lblRslt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOP2
            // 
            this.lblOP2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP2.Location = new System.Drawing.Point(66, 199);
            this.lblOP2.Name = "lblOP2";
            this.lblOP2.Size = new System.Drawing.Size(192, 54);
            this.lblOP2.TabIndex = 8;
            this.lblOP2.Text = "Operand 2 :";
            this.lblOP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(87, 107);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(171, 54);
            this.lblOperator.TabIndex = 7;
            this.lblOperator.Text = "Operator :";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOP1
            // 
            this.lblOP1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP1.Location = new System.Drawing.Point(66, 14);
            this.lblOP1.Name = "lblOP1";
            this.lblOP1.Size = new System.Drawing.Size(192, 54);
            this.lblOP1.TabIndex = 6;
            this.lblOP1.Text = "Operand 1 :";
            this.lblOP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(342, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 62);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(66, 365);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(244, 62);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cboOperation
            // 
            this.cboOperation.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperation.FormattingEnabled = true;
            this.cboOperation.Location = new System.Drawing.Point(264, 114);
            this.cboOperation.Name = "cboOperation";
            this.cboOperation.Size = new System.Drawing.Size(121, 47);
            this.cboOperation.TabIndex = 1;
            this.cboOperation.SelectedIndexChanged += new System.EventHandler(this.cboOperation_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.txtRslt);
            this.Controls.Add(this.txtOP2);
            this.Controls.Add(this.txtOP1);
            this.Controls.Add(this.lblRslt);
            this.Controls.Add(this.lblOP2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOP1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cboOperation);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator - CH7.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRslt;
        private System.Windows.Forms.TextBox txtOP2;
        private System.Windows.Forms.TextBox txtOP1;
        private System.Windows.Forms.Label lblRslt;
        private System.Windows.Forms.Label lblOP2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblOP1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ComboBox cboOperation;
    }
}

