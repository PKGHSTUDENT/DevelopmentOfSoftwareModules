namespace PR_7
{
    public class Product
    {
        private string _name;
        private string _description;
        private int _price;
        private int _quantity;

        public string Name { get => _name; set => _name = (value != "") ? value : "Unknown product"; }
        public string Description { get => _description; set => _description = (value != "") ? value : "no description"; }
        public int Price { get => _price; set => _price = (value < 1 || value > 20) ? 10 : value; }
        public int Quantity { get => _quantity; set => _quantity = (value < 1 || value > 10) ? 5 : value; }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name">The product's name.</param>
        /// <param name="description">Product description.</param>
        /// <param name="price">Product price. Range 1-20.</param>
        /// <param name="quantity">Amount. Range 1-10.</param>
        public Product(string name, string description, int price, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public Product()
        { }

        /// <summary>
        /// Output of information about the order of goods.
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Product: {Name}, Description: {Description}, Price: {Price}, Quantity: {Quantity}");
        }

        /// <summary>
        /// Information about the total price of the goods.
        /// </summary>
        public void Paymemt()
        {
            Console.WriteLine($"Amount payable for {Name}: {Price * Quantity} (p:{Price} / q:{Quantity})");
        }

        /// <summary>
        /// Displaying information and the total cost of the basket and the number of goods in it.
        /// </summary>
        /// <param name="products">List of products in the shopping cart</param>
        public void CartPayment(Product[] products)
        {
            int index = 1;
            int totalAmount = 0;
            int countProduct = 0;

            Console.WriteLine("\nFull cart information:");
            
            foreach (Product product in products)
            {
                Console.WriteLine($"#{index} {product.Name} | {product.Price} | {product.Quantity}");
                totalAmount += product.Quantity * product.Price;
                countProduct += product.Quantity;
                index++;
            }

            Console.WriteLine($"Total: price = {totalAmount} | count products = {countProduct}");

        }
    }
}
