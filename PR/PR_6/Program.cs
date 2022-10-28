namespace PR_6
{
    internal class Program
    {
        static void Perimeter(int a, int b)
        {
            Console.WriteLine($"Perimeter of a rectangle: {2 * (a + b)}");
        }

        static void Perimeter(int a, int b, int c)
        {
            Console.WriteLine($"Perimeter of a triangle: {a + b + c}");
        }

        static void Perimeter(params int[] args)
        {
            // Modification No.1.2
            if (args.Length == 4)
            {
                if ((args[0] == args[1] && args[1] == args[2] && args[2] == args[3]))
                {
                    Console.WriteLine($"Perimeter of a square: {args[1] * 4}");
                    return;
                }
            }

            int p = 0;
            foreach (int arg in args)
                p += arg;
            Console.WriteLine($"Perimeter of an {args.Length}-gon: {p}");
        }

        // Modification No.1.1
        static void Perimeter(int a)
        {
            Console.WriteLine($"Perimeter of a square: {4 * a}");
        }

        static void TestPerimeter()
        {
            Perimeter(2);
            Perimeter(1, 2);
            Perimeter(1, 2, 3);
            Perimeter(1, 2, 3, 4);
            Perimeter(2, 2, 2, 2);
            Perimeter(1, 2, 3, 4, 5);
        }

        static void TestOrders()
        {
            Order order1 = new Order("Ivanov", 2, "Luxe");
            order1.Show();

            Order order2 = new Order("Petrov", 5);
            order2.Show();

            Order order3 = new Order("Sidorov");
            order3.Show();

            Order order4 = new Order();
            order4.Show();

            Order order5 = new Order(size: 3, comfort: "Luxe");
            order5.Show();
        }

        static void Check(string s)
        {
            if (s == "Q")
                Environment.Exit(0);
        }

        // Modification No.2
        static void Mode2Orders()
        {
            string temp, name, comfort;
            int size;
            while (true)
            {
                Console.Write("Buyer name: ");
                temp = Console.ReadLine();
                Check(temp);
                name = temp;

                Console.Write("Number of beds in the room: ");
                temp = Console.ReadLine();
                Check(temp);
                size = Convert.ToInt32(temp);

                Console.Write("Comfort level: ");
                temp = Console.ReadLine();
                Check(temp);
                comfort = temp;

                Order order = new Order(name, size, comfort);
                order.Show();
            }
            return;
        }

        static void TestFigure()
        {
            Figure figure = new Figure();
            figure.ShowArea(5);
            figure.ShowArea(5, 7);
            figure.ShowArea(5, 7, 4);
        }

        static void TestTour()
        {
            Tour tour = new Tour();
            tour.TourCalc();
            tour.TourCalc("Sochi");
            tour.TourCalc("Moscow", 5);
        }

        static void Main(string[] args)
        {
            // TestPerimeter();
            // TestOrders();
            // Mode2Orders();
            // TestFigure();
            TestTour();

            Console.WriteLine("\n\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}