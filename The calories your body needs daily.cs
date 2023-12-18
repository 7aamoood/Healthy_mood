using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp9
{
    public partial class The_calories_your_body_needs_daily : Form
    {
        public The_calories_your_body_needs_daily()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h, w, g, c, a;
            w = double.Parse(textBox3.Text);
            h = double.Parse(textBox2.Text);
            g = double.Parse(textBox1.Text);

            string activity= comboBox2.SelectedItem.ToString(); ;
            string gender = comboBox1.SelectedItem.ToString();
            if (gender == "male")
            {
                c = (10 * w) + (6.25 * h) - (5 * g) + 5;
            }
            else
            {
                c = (10 * w) + (6.25 * h) - (5 * g) + 5;

            }

            if (activity == "نمط حياة خامل")
            {
                // a = 66.47 + (13.7 * w) + (5 * h) - (6.8 * g);
                a = c * 1.25;
                textBox5.Text = (a.ToString());

            }
            else if(activity == "قليل النشاط")
            {
                // a = 655.1 + (9.6 * w) + (1.8 * h) - (4.7 * g);
                a = c * 1.375;
                textBox5.Text = (a.ToString());


            }
            else if(activity == "متوسط النشاط")
            {
                a = c * 1.55;
                textBox5.Text = (a.ToString());

            }
            else if (activity == "مرتفع النشاط")
            {
                a = c * 1.725;
                textBox5.Text = (a.ToString());

            }
            else if (activity == "شديد النشاط ")
            {
                a = c * 1.9;
                textBox5.Text = (a.ToString());

            }


            textBox4.Text = (c.ToString());


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
