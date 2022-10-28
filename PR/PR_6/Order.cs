namespace PR_6
{
    public class Order
    {
        private string _fullname = "noname";
        private int _size = 3;
        private string _comfort = "standart";

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="fullname">Buyer name.</param>
        /// <param name="size">Number of beds in the room.</param>
        /// <param name="comfort">Comfort level.</param>
        public Order(string fullname = "noname", int size = 3, string comfort = "standart")
        {
            this._fullname = fullname;
            this._size = size;
            this._comfort = comfort;
        }

        /// <summary>
        /// Demonstration of class constructor overloading.
        /// </summary>
        /*
        public Order(string fullname, int size)
        {
            _fullname = fullname;
            _size = size;
        }

        public Order(string fullname)
        {
            _fullname = fullname;
        }

        public Order()
        { }
        */

        public void Show()
        {
            Console.WriteLine($"{_fullname} booked {_size} rooms with {_comfort} comfort level");
        }
    }
}
