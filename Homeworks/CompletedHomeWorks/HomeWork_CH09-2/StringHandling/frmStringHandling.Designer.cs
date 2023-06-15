namespace StringHandling
{
    partial class frmStringHandling
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtEmail = new TextBox();
            btnParse = new Button();
            txtCity = new TextBox();
            label2 = new Label();
            txtState = new TextBox();
            label3 = new Label();
            txtZipCode = new TextBox();
            label4 = new Label();
            btnFormat = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 32);
            label1.TabIndex = 7;
            label1.Text = "Email:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 53);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(390, 39);
            txtEmail.TabIndex = 0;
            // 
            // btnParse
            // 
            btnParse.Location = new Point(622, 53);
            btnParse.Margin = new Padding(4, 4, 4, 4);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(139, 49);
            btnParse.TabIndex = 1;
            btnParse.Text = "&Parse";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.Click += btnParse_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(186, 203);
            txtCity.Margin = new Padding(4, 4, 4, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(390, 39);
            txtCity.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 8;
            label2.Text = "City:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtState
            // 
            txtState.Location = new Point(186, 273);
            txtState.Margin = new Padding(4, 4, 4, 4);
            txtState.Name = "txtState";
            txtState.Size = new Size(71, 39);
            txtState.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 277);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 9;
            label3.Text = "State:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(186, 341);
            txtZipCode.Margin = new Padding(4, 4, 4, 4);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(193, 39);
            txtZipCode.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 346);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 10;
            label4.Text = "Zip code:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnFormat
            // 
            btnFormat.Location = new Point(622, 339);
            btnFormat.Margin = new Padding(4, 4, 4, 4);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(139, 49);
            btnFormat.TabIndex = 5;
            btnFormat.Text = "&Format";
            btnFormat.UseVisualStyleBackColor = true;
            btnFormat.Click += btnFormat_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(622, 439);
            btnExit.Margin = new Padding(4, 4, 4, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 49);
            btnExit.TabIndex = 6;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmStringHandling
            // 
            AcceptButton = btnParse;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(819, 527);
            Controls.Add(btnExit);
            Controls.Add(btnFormat);
            Controls.Add(txtZipCode);
            Controls.Add(label4);
            Controls.Add(txtState);
            Controls.Add(label3);
            Controls.Add(txtCity);
            Controls.Add(label2);
            Controls.Add(btnParse);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmStringHandling";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "String Handling";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnParse;
        private TextBox txtCity;
        private Label label2;
        private TextBox txtState;
        private Label label3;
        private TextBox txtZipCode;
        private Label label4;
        private Button btnFormat;
        private Button btnExit;
    }
}