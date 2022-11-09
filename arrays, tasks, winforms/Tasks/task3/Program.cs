namespace Tasks
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter x(int): ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.Write($"Result = {2 + x}");
                    break;
                case 2:
                    Console.Write($"Result = {Math.Abs(x - 3)}");
                    break;
                case 3:
                    Console.Write($"Result = {10}");
                    break;
                default:
                    Console.Write("Result: y is not defined :(");
                    break;
            }
            Console.ReadKey();
        }
    }
}