namespace StringHandling
{
    partial class frmParsedString
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
            lblUserName = new Label();
            lblDomain = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(63, 89);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(381, 65);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDomain
            // 
            lblDomain.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDomain.Location = new Point(63, 194);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(381, 65);
            lblDomain.TabIndex = 1;
            lblDomain.Text = "label2";
            lblDomain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(516, 369);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(207, 46);
            btnOK.TabIndex = 2;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmParsedString
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOK;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(lblDomain);
            Controls.Add(lblUserName);
            Name = "frmParsedString";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "parsedString";
            Load += frmParsedString_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblUserName;
        private Label lblDomain;
        private Button btnOK;
    }
}