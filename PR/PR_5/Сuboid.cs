namespace PR_5
{
    public class Сuboid
    {
        /// <summary>
        /// It is considered good manners to start private variables with an underscore.
        /// So other programmers in the course of studying yours when there are no
        /// questions what kind of variable it is and what modifier it has,
        /// if they come to use your code or use your logic in other places.
        /// https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/coding-conventions
        /// 
        /// Useful links:
        /// https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/private
        /// https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
        /// </summary>
        private double _a, _b, _c;

        public Сuboid(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public void Set_a(double a) { _a = a; }
        public void Set_b(double b) { _b = b; }
        public void Set_c(double c) { _c = c; }
        public double Get_a() { return _a; }
        public double Get_b() { return _b; }    
        public double Get_c() { return _c; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns the volume of a figure</returns>
        public double GetVolume()
        {
            return _a * _b * _c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Returns the area of a shape</returns>
        public double GetSquare()
        {
            return 2 * (_a * _b + _b * _c + _a * _c);
        }

        /// <summary>
        /// Displays complete information about the cuboid
        /// </summary>
        public void PrintInfo()
        {
            string str = "**************************\n" +
                         "*                        *\n" +
                         "*         Cuboid         *\n" +
                         "*                        *\n" +
                         "**************************\n";

            Console.WriteLine(str);

            Console.WriteLine("Sides of a cuboid:\n" +
                               $"Height: {_a}\n" +
                               $"Length: {_b}\n" +
                               $"Width: {_c}\n");

            Console.WriteLine($"Volume: {GetVolume()}\n" +
                              $"Square: {GetSquare()}\n");
        }
    }
}
