using System.Runtime.InteropServices;

namespace PR_8
{
    class Netbook : Notebook
    {
        private double _weight;

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Netbook()
        {
        }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="model">Laptop model.</param>
        /// <param name="ram">Amount of RAM.</param>
        /// <param name="time">Laptop time in minutes.</param>
        /// <param name="weight">Laptop weight.</param>
        public Netbook(string model, int ram, int time, double weight) : base(model, ram, time)
        {
            Weight = weight;
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = (value < 0.5 || value > 3.3) ? 0.5 : value; }
        }

        public override void Start() => Console.WriteLine($"{Model} works, ram = {Ram}, weight = {Weight}.");
    }
}
