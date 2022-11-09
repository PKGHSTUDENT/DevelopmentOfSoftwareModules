namespace PR_8
{
    class Candy : Product
    {
        private double _weight;
        private string _flavor;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Id product.</param>
        /// <param name="name">Candy name.</param>
        /// <param name="description">Description of sweets.</param>
        /// <param name="price">Candy price.</param>
        /// <param name="productType">Type of product.</param>
        /// <param name="weight">Candy weight.</param>
        /// <param name="taste">Candy flavor.</param>
        public Candy(int id,
                     string name,
                     string description,
                     double price,
                     string productType,
                     double weight,
                     string taste) : base(id,
                                          name,
                                          description,
                                          price,
                                          productType)
        {
            Weight = weight;
            Flavor = taste;
        }

        public double Weight { get => _weight; set => _weight = (value < 0) ? 1 : value; }
        public string Flavor { get => _flavor; set => _flavor = (value != "") ? value : "Unknown flavor"; }

        public override void Purchase()
        {
            Console.WriteLine($"[{Id}] name: {Name} | price: {Price} | total: {Price * (Weight / 0.1)}");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} | Product name: {Name}. Price: {Price}. Candy weight: {Weight}\n" +
                $"Flavor: {Flavor}.\n" +
                $"Description: {Description}.");
        }
    }
}
