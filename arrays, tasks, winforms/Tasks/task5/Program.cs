namespace Tasks
{
    class Program
    {
        static void Main()
        {
            double x, y, b, z;

            Console.Write("Enter y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());
            x = 3;
            while (x < 6.01)
            {
                double temp = (Math.Pow((b * Math.Pow(x, 2)), 1.0 / 3.0) + Math.Cos(x - y)) / Math.Exp(x + 1.2);
                z = Math.Round(temp, 4);
                Console.WriteLine($"Result: x = {x,3} | z = {z}");
                x = Math.Round(x += 0.2, 2);
            }

            Console.ReadKey();
        }
    }
}