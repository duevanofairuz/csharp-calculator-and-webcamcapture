namespace simple_calcul
{
    partial class Form1
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
            txtres = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn0 = new Button();
            btnplus = new Button();
            btnmin = new Button();
            btnmul = new Button();
            btndiv = new Button();
            btnclear = new Button();
            btnres = new Button();
            SuspendLayout();
            // 
            // txtres
            // 
            txtres.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtres.Location = new Point(35, 12);
            txtres.Multiline = true;
            txtres.Name = "txtres";
            txtres.Size = new Size(545, 64);
            txtres.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(35, 106);
            btn1.Name = "btn1";
            btn1.Size = new Size(115, 70);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(177, 106);
            btn2.Name = "btn2";
            btn2.Size = new Size(115, 70);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(325, 106);
            btn3.Name = "btn3";
            btn3.Size = new Size(115, 70);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(35, 208);
            btn4.Name = "btn4";
            btn4.Size = new Size(115, 70);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(177, 208);
            btn5.Name = "btn5";
            btn5.Size = new Size(115, 70);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(325, 208);
            btn6.Name = "btn6";
            btn6.Size = new Size(115, 70);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(35, 313);
            btn7.Name = "btn7";
            btn7.Size = new Size(115, 70);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button7_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(325, 313);
            btn9.Name = "btn9";
            btn9.Size = new Size(115, 70);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(177, 313);
            btn8.Name = "btn8";
            btn8.Size = new Size(115, 70);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button8_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(35, 420);
            btn0.Name = "btn0";
            btn0.Size = new Size(115, 70);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button0_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnplus.Location = new Point(465, 106);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(115, 70);
            btnplus.TabIndex = 3;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += buttonplus_Click;
            // 
            // btnmin
            // 
            btnmin.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmin.Location = new Point(465, 208);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(115, 70);
            btnmin.TabIndex = 3;
            btnmin.Text = "-";
            btnmin.UseVisualStyleBackColor = true;
            btnmin.Click += buttonmin_Click;
            // 
            // btnmul
            // 
            btnmul.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmul.Location = new Point(177, 420);
            btnmul.Name = "btnmul";
            btnmul.Size = new Size(115, 70);
            btnmul.TabIndex = 1;
            btnmul.Text = "*";
            btnmul.UseVisualStyleBackColor = true;
            btnmul.Click += buttonmul_Click;
            // 
            // btndiv
            // 
            btndiv.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndiv.Location = new Point(325, 420);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(115, 70);
            btndiv.TabIndex = 1;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += buttondiv_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.IndianRed;
            btnclear.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnclear.Location = new Point(465, 313);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(115, 70);
            btnclear.TabIndex = 1;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += buttonclear_Click;
            // 
            // btnres
            // 
            btnres.BackColor = SystemColors.ActiveCaption;
            btnres.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnres.Location = new Point(465, 420);
            btnres.Name = "btnres";
            btnres.Size = new Size(115, 70);
            btnres.TabIndex = 1;
            btnres.Text = "=";
            btnres.UseVisualStyleBackColor = false;
            btnres.Click += buttonres_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 502);
            Controls.Add(btnmin);
            Controls.Add(btnplus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnres);
            Controls.Add(btnclear);
            Controls.Add(btndiv);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn0);
            Controls.Add(btnmul);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(txtres);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "netcalculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtres;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btn0;
        private Button btnplus;
        private Button btnmin;
        private Button btnmul;
        private Button btndiv;
        private Button btnclear;
        private Button btnres;
    }
}