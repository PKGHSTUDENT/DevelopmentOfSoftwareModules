namespace Tasks
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            
            double result = x > 0 ? x * 2 : Math.Abs(x - 5);

            Console.Write($"Result = {result}");
            Console.ReadKey();
        }
    }
}