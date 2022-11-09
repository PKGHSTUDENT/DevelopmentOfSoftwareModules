namespace wf_independent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "password")
            {
                label3.Text = "Welcome!";
                pictureBox2.Visible = true;
            }
            else
            {
                label3.Text = "Wrong password!";
                pictureBox2.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString((Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text)) / 2);
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == '\b')
                return;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (e.KeyChar == '.')
            {
                if ((textBox3.Text.IndexOf('.') != -1) || (textBox.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Perimetr
            if ((textBox5.Text.Length == 0 && textBox6.Text.Length == 0) || textBox5.Text.Length == 0 || textBox6.Text.Length == 0)
                textBox7.Text = "Enter value!";
            else
                textBox7.Text = Convert.ToString(2 * (Convert.ToDouble(textBox5.Text) + Convert.ToDouble(textBox6.Text)));
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // Square
            if ((textBox5.Text.Length == 0 && textBox6.Text.Length == 0) || textBox5.Text.Length == 0 || textBox6.Text.Length == 0)
                textBox7.Text = "Enter value!";
            else
                textBox7.Text = Convert.ToString((Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text)));
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == '\b')
                return;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (e.KeyChar == '.')
            {
                if ((textBox5.Text.IndexOf('.') != -1) || (textBox5.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || e.KeyChar == '\b')
                return;
            if (e.KeyChar == ',')
                e.KeyChar = '.';
            if (e.KeyChar == '.')
            {
                if ((textBox6.Text.IndexOf('.') != -1) || (textBox6.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0 || textBox3.Text.Length == 0)
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Sequential
            textBox10.Text = Convert.ToString((Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox9.Text)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Parallel
            textBox10.Text = Convert.ToString(1.0 / (1.0 / (Convert.ToDouble(textBox8.Text)) + (1.0 / Convert.ToDouble(textBox9.Text))));
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 0 || textBox9.Text.Length == 0)
            {
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 0 || textBox9.Text.Length == 0)
            {
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }
    }
}