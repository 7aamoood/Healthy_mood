namespace WinFormsApp9
{
    partial class The_calories_your_body_needs_daily
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 30);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = "age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 79);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 117);
            label3.Name = "label3";
            label3.Size = new Size(229, 20);
            label3.TabIndex = 4;
            label3.Text = "enter your height with centimeter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 158);
            label4.Name = "label4";
            label4.Size = new Size(179, 20);
            label4.TabIndex = 5;
            label4.Text = "enter your weight with KG";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(239, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(239, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "male", "female" });
            comboBox1.Location = new Point(82, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(560, 79);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "result";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 196);
            label5.Name = "label5";
            label5.Size = new Size(789, 20);
            label5.TabIndex = 10;
            label5.Text = "----------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(341, 216);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 11;
            label6.Text = "Calorie check";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(320, 263);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 266);
            label7.Name = "label7";
            label7.Size = new Size(315, 20);
            label7.TabIndex = 13;
            label7.Text = "Your body's basal metabolic rate (BMR) at rest";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(451, 266);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 14;
            label8.Text = "Calories";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 312);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 15;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 312);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 16;
            label9.Text = "Total calories";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(239, 22);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 17;
            label10.Text = "مستوي النشاط";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "نمط حياة خامل", "قليل النشاط", "متوسط النشاط", "مرتفع النشاط ", "شديد النشاط " });
            comboBox2.Location = new Point(348, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 18;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // The_calories_your_body_needs_daily
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "The_calories_your_body_needs_daily";
            Text = "The_calories_your_body_needs_daily";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
    }
}