namespace LunchOrder
{
    partial class frmLunchOrder
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
            gbxMainCourse = new GroupBox();
            rdoSalad = new RadioButton();
            rdoPizza = new RadioButton();
            rdoHamburger = new RadioButton();
            groupBox3 = new GroupBox();
            txtOrderTotal = new TextBox();
            label3 = new Label();
            txtSalesTax = new TextBox();
            label2 = new Label();
            txtSubTotal = new TextBox();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            gbxAddOns = new GroupBox();
            ckbFrenchFries = new CheckBox();
            ckbKetMusMayo = new CheckBox();
            ckbLetTomOnions = new CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox3.SuspendLayout();
            gbxAddOns.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(rdoSalad);
            gbxMainCourse.Controls.Add(rdoPizza);
            gbxMainCourse.Controls.Add(rdoHamburger);
            gbxMainCourse.Location = new Point(59, 45);
            gbxMainCourse.Margin = new Padding(4);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Padding = new Padding(4);
            gbxMainCourse.Size = new Size(308, 220);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            gbxMainCourse.TextChanged += gbxAddOns_Enter;
            gbxMainCourse.Enter += gbxAddOns_Enter;
            // 
            // rdoSalad
            // 
            rdoSalad.AutoSize = true;
            rdoSalad.Location = new Point(40, 149);
            rdoSalad.Name = "rdoSalad";
            rdoSalad.Size = new Size(183, 36);
            rdoSalad.TabIndex = 2;
            rdoSalad.TabStop = true;
            rdoSalad.Text = "Salad - $6.75";
            rdoSalad.UseVisualStyleBackColor = true;
            rdoSalad.CheckedChanged += rdoSalad_CheckedChanged;
            // 
            // rdoPizza
            // 
            rdoPizza.AutoSize = true;
            rdoPizza.Location = new Point(40, 94);
            rdoPizza.Name = "rdoPizza";
            rdoPizza.Size = new Size(179, 36);
            rdoPizza.TabIndex = 1;
            rdoPizza.TabStop = true;
            rdoPizza.Text = "Pizza - $6.95";
            rdoPizza.UseVisualStyleBackColor = true;
            rdoPizza.CheckedChanged += rdoPizza_CheckedChanged;
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Location = new Point(40, 39);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(247, 36);
            rdoHamburger.TabIndex = 0;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "Hamburger - $7.95";
            rdoHamburger.UseVisualStyleBackColor = true;
            rdoHamburger.CheckedChanged += rdoHamburger_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtOrderTotal);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtSalesTax);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtSubTotal);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(59, 297);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(464, 228);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(195, 154);
            txtOrderTotal.Margin = new Padding(4);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(193, 39);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(195, 98);
            txtSalesTax.Margin = new Padding(4);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(193, 39);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(195, 43);
            txtSubTotal.Margin = new Padding(4);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(193, 39);
            txtSubTotal.TabIndex = 1;
            txtSubTotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(591, 311);
            btnPlaceOrder.Margin = new Padding(4);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(145, 49);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(591, 476);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 49);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // gbxAddOns
            // 
            gbxAddOns.Controls.Add(ckbFrenchFries);
            gbxAddOns.Controls.Add(ckbKetMusMayo);
            gbxAddOns.Controls.Add(ckbLetTomOnions);
            gbxAddOns.Location = new Point(418, 45);
            gbxAddOns.Name = "gbxAddOns";
            gbxAddOns.Size = new Size(409, 220);
            gbxAddOns.TabIndex = 1;
            gbxAddOns.TabStop = false;
            gbxAddOns.Text = "Add-On Items (1.25/each)";
            gbxAddOns.Enter += gbxAddOns_Enter;
            // 
            // ckbFrenchFries
            // 
            ckbFrenchFries.AutoSize = true;
            ckbFrenchFries.Location = new Point(41, 164);
            ckbFrenchFries.Name = "ckbFrenchFries";
            ckbFrenchFries.Size = new Size(174, 36);
            ckbFrenchFries.TabIndex = 2;
            ckbFrenchFries.Text = "French Fries";
            ckbFrenchFries.UseVisualStyleBackColor = true;
            // 
            // ckbKetMusMayo
            // 
            ckbKetMusMayo.AutoSize = true;
            ckbKetMusMayo.Location = new Point(41, 103);
            ckbKetMusMayo.Name = "ckbKetMusMayo";
            ckbKetMusMayo.Size = new Size(358, 36);
            ckbKetMusMayo.TabIndex = 1;
            ckbKetMusMayo.Text = "Ketchup, Mustard, and Mayo.";
            ckbKetMusMayo.UseVisualStyleBackColor = true;
            // 
            // ckbLetTomOnions
            // 
            ckbLetTomOnions.AutoSize = true;
            ckbLetTomOnions.Location = new Point(41, 40);
            ckbLetTomOnions.Name = "ckbLetTomOnions";
            ckbLetTomOnions.Size = new Size(359, 36);
            ckbLetTomOnions.TabIndex = 0;
            ckbLetTomOnions.Text = "Lettuce, Tomato, And Onions.";
            ckbLetTomOnions.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(839, 576);
            Controls.Add(gbxAddOns);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox3);
            Controls.Add(gbxMainCourse);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lunch Order";
            Load += Form1_Load;
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbxAddOns.ResumeLayout(false);
            gbxAddOns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxMainCourse;
        private GroupBox groupBox3;
        private TextBox txtOrderTotal;
        private Label label3;
        private TextBox txtSalesTax;
        private Label label2;
        private TextBox txtSubTotal;
        private Label label1;
        private Button btnPlaceOrder;
        private Button btnExit;
        private RadioButton rdoSalad;
        private RadioButton rdoPizza;
        private RadioButton rdoHamburger;
        private GroupBox gbxAddOns;
        private CheckBox ckbFrenchFries;
        private CheckBox ckbKetMusMayo;
        private CheckBox ckbLetTomOnions;
    }
}