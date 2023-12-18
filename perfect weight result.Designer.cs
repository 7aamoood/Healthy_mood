namespace WinFormsApp9
{
    partial class perfect_weight_result
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 21);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "inputs";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(547, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 175);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 2;
            label2.Text = "Your body condition";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(547, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 21);
            label3.Name = "label3";
            label3.Size = new Size(360, 20);
            label3.TabIndex = 4;
            label3.Text = "The normal weight range appropriate for your height";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 241);
            label4.Name = "label4";
            label4.Size = new Size(272, 20);
            label4.TabIndex = 6;
            label4.Text = "The best weight suitable for your height";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(63, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(74, 95);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 8;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 61);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 9;
            label5.Text = "height :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 98);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 10;
            label6.Text = "weight :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 305);
            label7.Name = "label7";
            label7.Size = new Size(205, 20);
            label7.TabIndex = 11;
            label7.Text = "The body mass index (BMI) is:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(63, 341);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(344, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "result";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // perfect_weight_result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "perfect_weight_result";
            Text = "perfect_weight_result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
        private Button button1;
    }
}