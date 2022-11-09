namespace Tasks
{
    class Program
    {
        static void Main()
        {
            double a, b, c, result;
            Console.Write("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter c: ");
            c = Convert.ToDouble(Console.ReadLine());

            result = Math.Round(a + (Math.Sin(10 * b) / Math.Exp(c + 2)), 2);

            Console.Write($"Result = {result}");
            Console.ReadKey();
        }
    }
}