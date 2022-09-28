namespace MyArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter columns: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter rows: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(-50, 50);
                }
            }

            /*foreach (int item in arr)
            {
                Console.Write(item + " ");
            }*/

            int max = arr[0, 0];
            int x = 0, y = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j], 3} | ");
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            Console.Write($"\nMax = {max} | row: {x + 1} | column: {y + 1}");

            Console.ReadKey();
        }
    }
}