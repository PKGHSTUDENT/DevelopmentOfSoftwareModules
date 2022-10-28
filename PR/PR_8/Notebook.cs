using System.Runtime.CompilerServices;

namespace PR_8
{
    class Notebook : Computer
    {
        private int _time;

        /// <summary>
        /// Class constructor.
        /// </summary>
        public Notebook()
        {
        }

        /// <summary>
        /// Class Constructor.
        /// </summary>
        /// <param name="model">Laptop model</param>
        /// <param name="ram">Amount of RAM.</param>
        /// <param name="time">Laptop time in minutes.</param>
        public Notebook(string model, int ram, int time) : base(model, ram)
        {
            Time = time;
        }

        public int Time
        {
            get { return _time; }
            set
            {
                _time = (value < 10) ? 15 : value;
            }
        }

        public override void End() => Console.WriteLine($"{Model} shuts down, charge {Time} minutes");
    }
}
