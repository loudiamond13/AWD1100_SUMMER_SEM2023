namespace FINAL_PROJECT
{
    partial class frmContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContact));
            btnExit = new System.Windows.Forms.Button();
            btnMainPage = new System.Windows.Forms.Button();
            btnSplashScreen = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsbMainPage = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbSearch = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbExit = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            lblContactPage = new System.Windows.Forms.Label();
            lblPhoneNum = new System.Windows.Forms.Label();
            txtWrittenMsg = new System.Windows.Forms.TextBox();
            btnSubmitMessage = new System.Windows.Forms.Button();
            lblSendMessage = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnExit.Location = new System.Drawing.Point(759, 571);
            btnExit.Margin = new System.Windows.Forms.Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(161, 49);
            btnExit.TabIndex = 16;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = System.Drawing.Color.MidnightBlue;
            btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMainPage.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMainPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnMainPage.Location = new System.Drawing.Point(404, 571);
            btnMainPage.Margin = new System.Windows.Forms.Padding(2);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new System.Drawing.Size(161, 49);
            btnMainPage.TabIndex = 15;
            btnMainPage.Text = "&Main Page";
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // btnSplashScreen
            // 
            btnSplashScreen.BackColor = System.Drawing.Color.MidnightBlue;
            btnSplashScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSplashScreen.Font = new System.Drawing.Font("Modern No. 20", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSplashScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSplashScreen.Location = new System.Drawing.Point(53, 571);
            btnSplashScreen.Margin = new System.Windows.Forms.Padding(2);
            btnSplashScreen.Name = "btnSplashScreen";
            btnSplashScreen.Size = new System.Drawing.Size(194, 49);
            btnSplashScreen.TabIndex = 14;
            btnSplashScreen.Text = "&Splash Screen";
            btnSplashScreen.UseVisualStyleBackColor = false;
            btnSplashScreen.Click += btnSplashScreen_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator3, tsbMainPage, toolStripSeparator2, tsbSearch, toolStripSeparator1, tsbExit, toolStripSeparator4 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            toolStrip1.Size = new System.Drawing.Size(973, 25);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMainPage
            // 
            tsbMainPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbMainPage.Image = (System.Drawing.Image)resources.GetObject("tsbMainPage.Image");
            tsbMainPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbMainPage.Name = "tsbMainPage";
            tsbMainPage.Size = new System.Drawing.Size(67, 22);
            tsbMainPage.Text = "&Main Page";
            tsbMainPage.Click += btnMainPage_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSearch
            // 
            tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbSearch.Image = (System.Drawing.Image)resources.GetObject("tsbSearch.Image");
            tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSearch.Name = "tsbSearch";
            tsbSearch.Size = new System.Drawing.Size(46, 22);
            tsbSearch.Text = "&Search";
            tsbSearch.Click += tsbSearch_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExit
            // 
            tsbExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbExit.Image = (System.Drawing.Image)resources.GetObject("tsbExit.Image");
            tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbExit.Name = "tsbExit";
            tsbExit.Size = new System.Drawing.Size(30, 22);
            tsbExit.Text = "&Exit";
            tsbExit.Click += btnExit_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblContactPage
            // 
            lblContactPage.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblContactPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblContactPage.Location = new System.Drawing.Point(160, 25);
            lblContactPage.Name = "lblContactPage";
            lblContactPage.Size = new System.Drawing.Size(653, 81);
            lblContactPage.TabIndex = 28;
            lblContactPage.Text = "Contact Page";
            lblContactPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNum
            // 
            lblPhoneNum.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPhoneNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblPhoneNum.Location = new System.Drawing.Point(160, 106);
            lblPhoneNum.Name = "lblPhoneNum";
            lblPhoneNum.Size = new System.Drawing.Size(313, 44);
            lblPhoneNum.TabIndex = 37;
            lblPhoneNum.Text = "Phone Number: 123-321-4567";
            lblPhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWrittenMsg
            // 
            txtWrittenMsg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            txtWrittenMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtWrittenMsg.Location = new System.Drawing.Point(160, 247);
            txtWrittenMsg.Multiline = true;
            txtWrittenMsg.Name = "txtWrittenMsg";
            txtWrittenMsg.Size = new System.Drawing.Size(505, 135);
            txtWrittenMsg.TabIndex = 38;
            // 
            // btnSubmitMessage
            // 
            btnSubmitMessage.BackColor = System.Drawing.Color.RoyalBlue;
            btnSubmitMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSubmitMessage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnSubmitMessage.Font = new System.Drawing.Font("Modern No. 20", 11.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSubmitMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSubmitMessage.Location = new System.Drawing.Point(504, 387);
            btnSubmitMessage.Margin = new System.Windows.Forms.Padding(2);
            btnSubmitMessage.Name = "btnSubmitMessage";
            btnSubmitMessage.Size = new System.Drawing.Size(161, 38);
            btnSubmitMessage.TabIndex = 39;
            btnSubmitMessage.Text = "Submit Message";
            btnSubmitMessage.UseVisualStyleBackColor = false;
            // 
            // lblSendMessage
            // 
            lblSendMessage.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSendMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblSendMessage.Location = new System.Drawing.Point(160, 200);
            lblSendMessage.Name = "lblSendMessage";
            lblSendMessage.Size = new System.Drawing.Size(258, 44);
            lblSendMessage.TabIndex = 40;
            lblSendMessage.Text = "Send Us Message:";
            lblSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            lblAddress.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblAddress.Location = new System.Drawing.Point(160, 150);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(313, 44);
            lblAddress.TabIndex = 41;
            lblAddress.Text = "Adress: 132 Main St., Ofallon, MO 63366";
            lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmContact
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SlateGray;
            ClientSize = new System.Drawing.Size(973, 647);
            Controls.Add(lblAddress);
            Controls.Add(lblSendMessage);
            Controls.Add(btnSubmitMessage);
            Controls.Add(txtWrittenMsg);
            Controls.Add(lblPhoneNum);
            Controls.Add(lblContactPage);
            Controls.Add(toolStrip1);
            Controls.Add(btnExit);
            Controls.Add(btnMainPage);
            Controls.Add(btnSplashScreen);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(989, 686);
            MinimumSize = new System.Drawing.Size(989, 670);
            Name = "frmContact";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmContact";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbMainPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label lblContactPage;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtWrittenMsg;
        private System.Windows.Forms.Button btnSubmitMessage;
        private System.Windows.Forms.Label lblSendMessage;
        private System.Windows.Forms.Label lblAddress;
    }
}