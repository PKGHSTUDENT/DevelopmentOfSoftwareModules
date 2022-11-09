namespace PR_8
{
    class Product
    {
        private int _id;
        private string _name;
        private string _description;
        private double _price;
        private string _productType;

        /// <summary>
        /// Class constructor. Base class for describing goods
        /// </summary>
        /// <param name="id">Id product.</param>
        /// <param name="name">Name product.</param>
        /// <param name="description">Description product</param>
        /// <param name="price">Price product.</param>
        /// <param name="productType">Type of product.</param>
        public Product(int id, string name, string description, double price, string productType)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ProductType = productType;
        }

        public int Id
        {
            get => _id;
            set => _id = (value <= 0) ? 1 : value;
        }
        public string Name
        {
            get => _name;
            set => _name = (value != "") ? value : "Unknowt product";
        }
        public string Description
        {
            get => _description;
            set => _description = (value != "") ? value : "No description";
        }
        public double Price
        {
            get => _price;
            set => _price = (value < 0) ? 1 : value;
        }
        public string ProductType
        { 
            get => _productType; 
            set => _productType = (value != "") ? value : "Unknown type"; 
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} | Product name: {Name}. Price: {Price}.\nDescription: {Description}.");
        }

        public virtual void Purchase()
        {
            Console.WriteLine($"[{Id}] name: {Name} | price: {Price}");
        }
    }
}
