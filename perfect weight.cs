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
    public partial class perfect_weight : Form
    {
        public perfect_weight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            perfect_weight_result perfect_weight = new perfect_weight_result();
            perfect_weight.Show();
            double h = double.Parse(height_textbox.Text);
            h = h / 100;
            double w = double.Parse(weight_textbox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
