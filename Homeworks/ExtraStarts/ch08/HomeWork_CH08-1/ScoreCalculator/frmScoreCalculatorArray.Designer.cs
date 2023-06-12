namespace ScoreCalculator
{
    partial class frmScoreCalculatorArray
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
            txtScore = new TextBox();
            btnAdd = new Button();
            txtScoreTotal = new TextBox();
            label2 = new Label();
            txtScoreCount = new TextBox();
            label3 = new Label();
            txtAverage = new TextBox();
            label4 = new Label();
            btnClear = new Button();
            btnExit = new Button();
            btnDisplayScores = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 8;
            label1.Text = "Score:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(197, 45);
            txtScore.Margin = new Padding(4);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(84, 39);
            txtScore.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(316, 43);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.Location = new Point(197, 107);
            txtScoreTotal.Margin = new Padding(4);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.ReadOnly = true;
            txtScoreTotal.Size = new Size(84, 39);
            txtScoreTotal.TabIndex = 5;
            txtScoreTotal.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 32);
            label2.TabIndex = 9;
            label2.Text = "Score total:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtScoreCount
            // 
            txtScoreCount.Location = new Point(197, 169);
            txtScoreCount.Margin = new Padding(4);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.ReadOnly = true;
            txtScoreCount.Size = new Size(84, 39);
            txtScoreCount.TabIndex = 6;
            txtScoreCount.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 10;
            label3.Text = "Score count:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(197, 228);
            txtAverage.Margin = new Padding(4);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(84, 39);
            txtAverage.TabIndex = 7;
            txtAverage.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 233);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 11;
            label4.Text = "Average:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(316, 233);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(139, 49);
            btnClear.TabIndex = 2;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(316, 305);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 49);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDisplayScores
            // 
            btnDisplayScores.Location = new Point(45, 305);
            btnDisplayScores.Name = "btnDisplayScores";
            btnDisplayScores.Size = new Size(200, 46);
            btnDisplayScores.TabIndex = 3;
            btnDisplayScores.Text = "Display Scores";
            btnDisplayScores.UseVisualStyleBackColor = true;
            btnDisplayScores.Click += button1_Click;
            // 
            // frmScoreCalculatorArray
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(507, 395);
            Controls.Add(btnDisplayScores);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(txtAverage);
            Controls.Add(label4);
            Controls.Add(txtScoreCount);
            Controls.Add(label3);
            Controls.Add(txtScoreTotal);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "frmScoreCalculatorArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtScore;
        private Button btnAdd;
        private TextBox txtScoreTotal;
        private Label label2;
        private TextBox txtScoreCount;
        private Label label3;
        private TextBox txtAverage;
        private Label label4;
        private Button btnClear;
        private Button btnExit;
        private Button btnDisplayScores;
    }
}