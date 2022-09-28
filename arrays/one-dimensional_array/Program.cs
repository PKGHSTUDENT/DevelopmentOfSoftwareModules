namespace MyArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
                arr[i] = rand.Next(-50, 50);

            foreach (int item in arr) Console.Write($"{item} | ");
            
            Console.WriteLine($"\nNumber of elements in the array: {arr.Length}");

            int positive = 0, even = 0;

            foreach (int item in arr)
            {
                positive += item > 0 ? item : 0;
                even += (item % 2 == 0) ? 1 : 0;
            }

            Console.Write($"Summa positive numbers: {positive} | Even numbers: {even}");

            Console.ReadKey();
        }
    }
}