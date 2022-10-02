namespace pr1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fx = 0, result = 0;
            double x = Convert.ToDouble(textBox1.Text);
            double m = Convert.ToDouble(textBox2.Text);

            if (radioButton2.Checked == true)
                fx = Math.Pow(x, 2);
            else if (radioButton3.Checked == true)
                fx = Math.Exp(x);
            else
                fx = Math.Sinh(x);

            if (-1 < m && m < x)
            {
                result = Math.Sin((5 * fx) + (3 * m * Math.Abs(fx)));
            }
            else if (x > m)
            {
                result = Math.Cos((3 * fx) + (5 * m * Math.Abs(fx)));
            }
            else
            {
                result = Math.Pow((fx + m), 2);
            }

            textBox3.Text += Convert.ToString(result) + Environment.NewLine;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == '\b')
                return;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (e.KeyChar == '.')
            {
                if ((textBox1.Text.IndexOf('.') != -1) || (textBox1.Text.Length == 0))
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}