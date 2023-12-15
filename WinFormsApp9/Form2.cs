using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(GetTextBox2());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 check = new Form3();
            check.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             float age = float.Parse(textBox2.Text);

           


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float height = float.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
