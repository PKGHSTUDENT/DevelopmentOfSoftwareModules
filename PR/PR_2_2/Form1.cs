namespace PR_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 0)
                || (textBox2.Text.Length == 0)
                || (textBox3.Text.Length == 0)
                || (textBox4.Text.Length == 0))
                MessageBox.Show("Enter all values!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                double x0 = Convert.ToDouble(textBox1.Text);
                double xk = Convert.ToDouble(textBox2.Text);
                double dx = Convert.ToDouble(textBox3.Text);
                double a = Convert.ToDouble(textBox4.Text);
                textBox5.Text = "Practical work by @dobrodelete." + Environment.NewLine;
                double x = x0;
                while (x <= (xk + dx / 2))
                {
                    double y = a * Math.Log(x);
                    textBox5.Text += "x = " + Convert.ToString(Math.Round(x, 2)) + "; y =" + Convert.ToString(y) + Environment.NewLine;
                    x = x + dx;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '-')
                return;

            if (e.KeyChar == ',')
                e.KeyChar = '.';

            if (e.KeyChar == '.')
            {
                if (textBox1.Text.IndexOf('.') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '-')
                return;

            if (e.KeyChar == ',')
                e.KeyChar = '.';

            if (e.KeyChar == '.')
            {
                if (textBox2.Text.IndexOf('.') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '-')
                return;

            if (e.KeyChar == ',')
                e.KeyChar = '.';

            if (e.KeyChar == '.')
            {
                if (textBox3.Text.IndexOf('.') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '-')
                return;

            if (e.KeyChar == ',')
                e.KeyChar = '.';

            if (e.KeyChar == '.')
            {
                if (textBox4.Text.IndexOf('.') != -1)
                    e.Handled = true;
                return;
            }
            
            if (Char.IsControl(e.KeyChar))
                return;
            
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox7.Text.Length == 0)
                || (textBox9.Text.Length == 0)
                || (textBox10.Text.Length == 0))
                MessageBox.Show("Enter all values!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                double x0 = Convert.ToDouble(textBox7.Text);
                double xk = Convert.ToDouble(textBox9.Text);
                double dx = Convert.ToDouble(textBox10.Text);
                textBox6.Text = "Practical work by @dobrodelete." + Environment.NewLine;
                double x = x0;
                while (x >= (xk + dx))
                {
                    double y = (9 * Math.Pow(x, 4)) + Math.Sin(57.2 + x);
                    textBox6.Text += "x = " + Convert.ToString(Math.Round(x, 2)) + "; y =" + Convert.ToString(y) + Environment.NewLine;
                    x = x + dx;
                }
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == ',')
                e.KeyChar = '.';

            if (e.KeyChar == '-')
                return;


            if (e.KeyChar == '.')
            {
                if (textBox7.Text.IndexOf('.') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '-')
                return;

            if (e.KeyChar == ',')
                e.KeyChar = '.';

            if (e.KeyChar == '.')
            {
                if (textBox9.Text.IndexOf('.') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '-')
                return;

            if (e.KeyChar == ',')
                e.KeyChar = '.';

            if (e.KeyChar == '.')
            {
                if (textBox10.Text.IndexOf('.') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
                return;

            e.Handled = true;
        }
    }
}