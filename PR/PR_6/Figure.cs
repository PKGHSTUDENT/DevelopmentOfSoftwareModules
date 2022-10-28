using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6
{
    // Modification No.3
    public class Figure
    {
        public void ShowArea(int a)
        {
            Console.WriteLine($"Square. S: {a * a}");
        }

        public void ShowArea(int a, int b)
        {
            Console.WriteLine($"Rectangle. S: {a * b}");
        }
        
        public void ShowArea(int a, int b, int c)
        {
            Console.WriteLine($"Trapeze. S: {((a + b) * c) / 2}");
        }
    }
}
