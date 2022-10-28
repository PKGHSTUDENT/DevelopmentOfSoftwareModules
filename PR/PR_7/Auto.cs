namespace PR_7
{
    public class Auto
    {
        private string _brand;
        private string _color;
        private int _speed;

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="brand">Car brand.</param>
        /// <param name="color">Car color.</param>
        /// <param name="speed">Auto speed.</param>
        public Auto(string brand, string color, int speed)
        {
            Brand = brand;
            Color = color;
            Speed = speed;
        }

        public string Brand { get { return _brand; } set => _brand = (value != "") ? value : "Unknown brand"; }
        public string Color { get { return _color; } set => _color = (value != "") ? value : "Unknown color"; }
        public int Speed { get { return _speed; } set => _speed = (value < 20 || value > 120) ? 20 : value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, color: {Color}, speed: {Speed}");
        }
    }
}
