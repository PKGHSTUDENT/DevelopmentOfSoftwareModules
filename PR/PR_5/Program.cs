namespace PR_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If you do not create a constructor,
            // then you can use this format for assigning values ​​to variables.

            /*
            house1.name = "country house";
            house1.area = 30;
            house1.nof = 4;
            */

            // It's best to use a constructor and destructor,
            // because your code may contain logic for working
            // with data that you may not assign, which will lead to an error.

            Build house1 = new Build("country house", 30, 4);
            Build house2 = new Build("House", 7000, 1200, 25);

            house1.ShowInfo();
            house2.ShowInfo();

            Console.WriteLine();

            Сuboid cuboid = new Сuboid(15, 10, 7.5);

            cuboid.PrintInfo();

            Student student = new Student("Ivan", "Ivanov", 19, 2);

            student.ShowInfo();

            Console.ReadKey();
        }
    }
}