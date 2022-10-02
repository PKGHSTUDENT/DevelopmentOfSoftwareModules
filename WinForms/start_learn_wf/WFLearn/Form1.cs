namespace WFLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Hi, " + textBox1.Text;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "Bye, " + textBox1.Text;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = (radioButton2.Checked) ? "Right!" : "Error:(";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = (checkBox1.Checked && checkBox3.Checked && !checkBox2.Checked && !checkBox4.Checked) ? "Right" : "Error";
        }
    }
}