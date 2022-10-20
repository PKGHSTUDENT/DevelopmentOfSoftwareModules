namespace PR_5
{
    class Build
    {
        /// <summary>
        /// A test class that is used in this case for training
        /// and is not needed for anything other than this.
        /// </summary>
        
        public string name;
        public double area;
        public int floor;
        public int nof;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Buildings name</param>
        /// <param name="area">Buildings area</param>
        /// <param name="nof">number of residents</param>
        /// <param name="floor">number of floors of the building</param>
        public Build(string name, double area, int nof, int floor = 0)
        {
            this.name = name;
            this.area = area;
            this.nof = nof;
            this.floor = floor;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"In house {name}, area {area} living {nof} people, {area / nof}, {floor} floors.");
        }
    }
}