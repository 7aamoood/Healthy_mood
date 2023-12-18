namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form02 inbody = new Form02();
            inbody.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perfect_weight_result perfect_weight = new perfect_weight_result();
            perfect_weight.Show();
        }
    }
}