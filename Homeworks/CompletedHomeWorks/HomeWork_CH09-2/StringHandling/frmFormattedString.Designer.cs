namespace StringHandling
{
    partial class frmFormattedString
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
            btnOK = new Button();
            lblAddress = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(536, 367);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(176, 54);
            btnOK.TabIndex = 0;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(12, 159);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(758, 55);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "label1";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmFormattedString
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnOK;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAddress);
            Controls.Add(btnOK);
            Name = "frmFormattedString";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFormattedString";
            Load += frmFormattedString_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Label lblAddress;
    }
}