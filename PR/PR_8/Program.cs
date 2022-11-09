namespace PR_8
{
    internal class Program
    {
        static void TestNotebook()
        {
            Notebook notebook = new Notebook("Lenovo", 2888, 50);
            notebook.Start();
            notebook.End();

            Computer computer = new Notebook("Asus", 2333, 180);
            computer.Start();
            computer.End();

            Netbook netbook = new Netbook("ThinkPad", 1999, 30, 2.1);
            netbook.Start();
            netbook.End();
        }

        static void TestProduct()
        {
            Product book = new Book(1, "1984", "The most popular dystopia", 29.9, "book", "George Orwell", 10, "dystopian novel");
            book.ShowInfo();
            book.Purchase();

            Candy candy = new Candy(2, "Caramel", "Delicious and juicy caramel", 6.99, "candy", 2, "sweet, salty");
            candy.ShowInfo();
            candy.Purchase();
        }

        static void Main(string[] args)
        {
            // I was too lazy to make a child Pen class,
            // and there is nothing new or interesting there.

            // TestNotebook();
            TestProduct();

            Console.ReadKey();
        }
    }
}