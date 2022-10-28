namespace PR_8
{
    internal class Program
    {
        static void TestNotebook()
        {
            Notebook notebook = new Notebook("Lenovo", 2888, 50);
            notebook.Start();
            notebook.End();
        }
        static void Main(string[] args)
        {
            TestNotebook();
            
            Console.ReadKey();
        }
    }
}