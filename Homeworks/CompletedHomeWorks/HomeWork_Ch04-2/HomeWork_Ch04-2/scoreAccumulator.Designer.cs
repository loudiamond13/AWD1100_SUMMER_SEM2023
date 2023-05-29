namespace HomeWork_Ch04_2
{
    partial class scoreAccumulator
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
            this.btnClearr = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScore_total = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearr
            // 
            this.btnClearr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearr.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearr.Location = new System.Drawing.Point(35, 495);
            this.btnClearr.Name = "btnClearr";
            this.btnClearr.Size = new System.Drawing.Size(221, 63);
            this.btnClearr.TabIndex = 2;
            this.btnClearr.Text = "CLEAR";
            this.btnClearr.UseVisualStyleBackColor = true;
            this.btnClearr.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(50, 29);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(234, 65);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score :";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScore_total
            // 
            this.lblScore_total.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore_total.Location = new System.Drawing.Point(50, 143);
            this.lblScore_total.Name = "lblScore_total";
            this.lblScore_total.Size = new System.Drawing.Size(234, 65);
            this.lblScore_total.TabIndex = 8;
            this.lblScore_total.Text = "Score Total :";
            this.lblScore_total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageScore.Location = new System.Drawing.Point(50, 371);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(234, 65);
            this.lblAverageScore.TabIndex = 10;
            this.lblAverageScore.Text = "Average :";
            this.lblAverageScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCount.Location = new System.Drawing.Point(50, 257);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(234, 65);
            this.lblScoreCount.TabIndex = 9;
            this.lblScoreCount.Text = "Score Count :";
            this.lblScoreCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(290, 29);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(146, 55);
            this.txtScore.TabIndex = 0;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Enabled = false;
            this.txtScoreTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreTotal.Location = new System.Drawing.Point(290, 143);
            this.txtScoreTotal.Multiline = true;
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.Size = new System.Drawing.Size(146, 55);
            this.txtScoreTotal.TabIndex = 4;
            this.txtScoreTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtScoreTotal.TextChanged += new System.EventHandler(this.txtScoreTotal_TextChanged);
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Enabled = false;
            this.txtScoreCount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreCount.Location = new System.Drawing.Point(290, 257);
            this.txtScoreCount.Multiline = true;
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.Size = new System.Drawing.Size(146, 55);
            this.txtScoreCount.TabIndex = 5;
            this.txtScoreCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Enabled = false;
            this.txtAverageScore.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverageScore.Location = new System.Drawing.Point(290, 371);
            this.txtAverageScore.Multiline = true;
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(146, 55);
            this.txtAverageScore.TabIndex = 6;
            this.txtAverageScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(363, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 63);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(457, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // scoreAccumulator
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(635, 608);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.lblScore_total);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnClearr);
            this.Name = "scoreAccumulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Accumulator";
            this.Load += new System.EventHandler(this.scoreAccumulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearr;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScore_total;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
    }
}

