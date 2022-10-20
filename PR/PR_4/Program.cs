namespace PR_4
{
    internal class Program
    {
        // Documentation for the methods:
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.");

            // Task 1.
            Console.WriteLine("1.Объясните что такое методы и почему они важны?\n");
            Console.WriteLine("Метод — это блок кода, содержащий ряд инструкций.\n" + 
                              "Программа инициирует выполнение инструкций, вызывая метод и указывая все аргументы,\n" +
                              "необходимые для этого метода. В C# все инструкции выполняются в контексте метода.\n");

            Console.WriteLine("2.Назовите общее описание метода.\n");
            Console.WriteLine("[модификаторы] тип_возвращаемого_значения название_метода ([параметры])\r\n{\r\n    // тело метода\r\n}\n");

            Console.WriteLine("3.Опишите три возможных пути передачи параметров и соответствующие ключевые слова С#.\n");
            Console.WriteLine("Возможнеые пути передачи параметров это:\n" +
                              "1.По назначению\n2.По ссылке\n3.Выходные параметры.\n\n" +
                              "Соответствующие ключевые слова:\n" +
                              "1.ref\n2.out\n3.params.\n\n");

            // Task 2.
            double x, y;
            Console.WriteLine("Task 2.\nEnter two numbers with Enter.");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Max:" + max(x, y) + "\n");

            Console.WriteLine("Task 3.\n");
            Console.WriteLine("Number substitution result:\n" + "Before: x = " + x + " | y = " + y);

            replacement(ref x, ref y);

            Console.WriteLine("\nAfter: x = " + x + " | y = " + y + "\n");

            // 8. Составить процедуру, изображающую на экране Ваше имя с помощью символов «*». Каждую букву оформить в виде отдельной процедуры
            Console.WriteLine("Task 4. Option 8.\n\nEnter any key...");
            Console.ReadKey();
            Console.Clear();
            stupid_procedure();
            Console.ReadKey();
        }

        static double max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        static void replacement(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }

        static void stupid_procedure()
        {
            d();
            o();
            b();
            r();
            o();
            d();
            e();
            l();
            e();
            t();
            e();
        }

        static void d()
        {
            Console.WriteLine("   *\n" + " ***\n" + "*  *\n" + " ***\n");
        }

        static void o()
        {
            Console.WriteLine(" **\n" + "*  *\n" + "*  *\n" + " **\n");
        }

        static void b()
        {
            Console.WriteLine("*\n" + "***\n" + "*  *\n" + "***\n");
        }

        static void r()
        {
            Console.WriteLine("* *\n" + "*   *\n" + "*   *\n" + "*\n");
        }

        static void e()
        {
            Console.WriteLine(" **\n" + "****\n" + "*\n" + " **\n");
        }

        static void l()
        {
            Console.WriteLine("*\n" + "*\n" + "*\n" + "***\n");
        }

        static void t()
        {
            Console.WriteLine(" **\n" + "****\n" + " **\n" + " **\n");
        }
    }
}