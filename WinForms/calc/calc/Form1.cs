namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString((double)(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString((double)(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString((double)(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString((double)(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == '\b')
                return;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (e.KeyChar == '.')
            {
                if ((textBox2.Text.IndexOf('.') != -1) || (textBox2.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == '\b')
                return;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (e.KeyChar == '.')
            {
                if ((textBox2.Text.IndexOf('.') != -1) || (textBox2.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }
    }
}