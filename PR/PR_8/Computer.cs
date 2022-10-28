namespace PR_8
{
    class Computer
    {
        private string _model;
        private int _ram;

        public string Model
        {
            get { return _model; }
            set { _model = (value != "") ? value : "Unknown model"; }
        }
        public int Ram
        {
            get { return _ram; }
            set { _ram = (value < 500) ? 640 : value; }
        }

        public Computer()
        {
        }

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="model">Computer model.</param>
        /// <param name="ram">Amount of RAM.</param>
        public Computer(string model, int ram)
        {
            Model = model;
            Ram = ram;
        }

        public void Start() => Console.WriteLine($"{Model} works, ram = {Ram}.");

        public void End() => Console.WriteLine($"{Model} shuts down.");
    }
}
