namespace PR_3
{
    public partial class Form1 : Form
    {

        // Documentation for the DataGridView class:
        // https://learn.microsoft.com/ru-ru/dotnet/api/system.windows.forms.datagridview
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;

            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);

            // Declaring and initializing a two-dimensional array
            int[,] arr = new int[n, m];

            // Denoting the number of rows and columns in our component
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;

            // Creating a new instance of type Random
            Random random = new Random();

            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    // Filling an array with data
                    arr[i, j] = random.Next(-100, 100);

            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    // Data output
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(arr[i, j]);

            // Variable to store the minimum value in the column
            int temp;

            resultBox.Text = "Finding the minimum number:" + Environment.NewLine;

            for (i = 0; i < m; i++)
            {
                temp = arr[0, i];
                for (j = 0; j < n; j++)
                {
                    if (temp > arr[j, i])
                        temp = arr[j, i];
                }
                resultBox.Text += "Column #" + i + " = " + temp.ToString() + Environment.NewLine;
            }
        }
    }
}