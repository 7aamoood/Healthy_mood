namespace WinFormsApp9
{
    partial class perfect_weight
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
            height_textbox = new TextBox();
            weight_textbox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(226, 20);
            label1.TabIndex = 0;
            label1.Text = "enter your height Ball centimeter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 82);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 1;
            label2.Text = "enter your weight by kg";
            label2.Click += label2_Click;
            // 
            // height_textbox
            // 
            height_textbox.Location = new Point(280, 34);
            height_textbox.Name = "height_textbox";
            height_textbox.Size = new Size(125, 27);
            height_textbox.TabIndex = 2;
            height_textbox.TextChanged += textBox1_TextChanged;
            // 
            // weight_textbox
            // 
            weight_textbox.Location = new Point(280, 82);
            weight_textbox.Name = "weight_textbox";
            weight_textbox.Size = new Size(125, 27);
            weight_textbox.TabIndex = 3;
            weight_textbox.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(327, 233);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // perfect_weight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(weight_textbox);
            Controls.Add(height_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "perfect_weight";
            Text = "perfect_weight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        public TextBox height_textbox;
        public TextBox weight_textbox;
    }
}