namespace PR_8
{
    class Book : Product
    {
        private string _author;
        private int _quantity;
        private string _bookType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Id product.</param>
        /// <param name="name">Name product.</param>
        /// <param name="description">Description product</param>
        /// <param name="price">Price product.</param>
        /// <param name="productType">Type of product.</param>
        /// <param name="author">Author of book.</param>
        /// <param name="quantity">Number of books</param>
        /// <param name="bookType">Book genre.</param>
        public Book(int id,
                    string name,
                    string description,
                    double price,
                    string productType,
                    string author,
                    int quantity,
                    string bookType) : base(id,
                                            name,
                                            description,
                                            price,
                                            productType)
        {
            Author = author;
            Quantity = quantity;
            BookType = bookType;
            BookType = bookType;
        }

        public string Author { get => _author; set => _author = (value != "") ? value : "Unknown author"; }
        public int Quantity { get => _quantity; set => _quantity = (value < 0) ? 0 : value; }
        public string BookType { get => _bookType; set => _bookType = (value != "") ? value : "Unknown type"; }

        public override void Purchase()
        {
            Console.WriteLine($"[{Id}] name: {Name} | price: {Price} | total: {Price * Quantity}\n");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} | Product name: {Name}. Price: {Price}. Number of books: {Quantity}\n" +
                $"Author: {Author}. Type Book: {BookType}." + 
                $"\nDescription: {Description}.");
        }
    }
}
