namespace PR_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1;
            int i = 0, temp = 1;

            for (i = 0; i < 21; i++)
                Console.Write(Convert.ToInt32(Math.Pow(2, i)) + " ");

            Console.WriteLine();

            // Task 2;
            double e;
            Console.Write("Enter e: ");
            e = Convert.ToDouble(Console.ReadLine());
            double m = 1, s = 0;

            double x;
            Console.Write("Enter x: ");
            x = Convert.ToDouble(Console.ReadLine());

            i = 1;
            while (Math.Abs(m) > e)
            {
                m = (Math.Pow(-1, i - 1) * (i / Math.Pow(x, i)));
                s = s + m;
                i++;
            }
            Console.WriteLine("S: " + s);

            // Task 3;
            int perviden = 10;
            double summa = perviden, mileage = 1.1;
            do
            {
                summa *= mileage;
                temp++;
            } while (summa <= 100);
            Console.WriteLine("Days: " + temp);


            // Task 4;
            temp = 1;
            for (i = 3; i < 25; i += 3)
            {
                temp *= 2;
                Console.WriteLine("Hour: " + i + " | Ameba: " + temp);
            }

            Console.ReadKey();
        }
    }
}