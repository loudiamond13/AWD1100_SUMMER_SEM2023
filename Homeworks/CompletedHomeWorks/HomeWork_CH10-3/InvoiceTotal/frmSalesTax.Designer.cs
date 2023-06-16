namespace InvoiceTotal
{
    partial class frmSalesTax
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
            btnCancel = new Button();
            lblSalesTaxPct = new Label();
            txtNewPercent = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(51, 327);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(235, 50);
            btnOK.TabIndex = 1;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(474, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(235, 50);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSalesTaxPct
            // 
            lblSalesTaxPct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalesTaxPct.Location = new Point(62, 179);
            lblSalesTaxPct.Name = "lblSalesTaxPct";
            lblSalesTaxPct.Size = new Size(193, 66);
            lblSalesTaxPct.TabIndex = 3;
            lblSalesTaxPct.Text = "Sales Tax Pct:";
            lblSalesTaxPct.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNewPercent
            // 
            txtNewPercent.Location = new Point(301, 179);
            txtNewPercent.Multiline = true;
            txtNewPercent.Name = "txtNewPercent";
            txtNewPercent.Size = new Size(322, 66);
            txtNewPercent.TabIndex = 0;
            txtNewPercent.TextAlign = HorizontalAlignment.Center;
            // 
            // frmSalesTax
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNewPercent);
            Controls.Add(lblSalesTaxPct);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Name = "frmSalesTax";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSalesTax";
            Load += frmSalesTax_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private Label lblSalesTaxPct;
        private TextBox txtNewPercent;
    }
}