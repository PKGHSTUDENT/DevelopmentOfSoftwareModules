namespace PR_7
{
    internal class Program
    {
        static void TestStudent()
        {
            // Old code
            // Student student1 = new Student("Ivan", 3);
            // student1.ShowInfo();

            Student student1 = new Student("Ivan", "Ivanov", 15, 2);
            student1.ShowInfo();

            Student student2 = new Student("Petya", "Petrov", 120, -7);
            student2.ShowInfo();

            Student student3 = new Student("", "", 5, -7);
            student3.ShowInfo();
        }

        static void TestAuto()
        {
            Auto auto = new Auto("Audi", "black", 120);
            auto.ShowInfo();

            Auto auto1 = new Auto("", "", -700);
            auto1.ShowInfo();
        }

        static void TestPruduct()
        {
            Product product = new Product("Cookie", "Very tasty cookies", 15, 3);
            product.ShowInfo();
            product.Paymemt();

            Product product1 = new Product("Shampoo", "And the hair is always clean", 20, 1);
            product1.ShowInfo();

            Product[] cart = new Product[] { product, product1 };
            Product temp = new Product();

            temp.CartPayment(cart);
        }

        static void Main(string[] args)
        {
            // TestStudent();
            // TestAuto();
            TestPruduct();

            Console.ReadKey();
        }
    }
}