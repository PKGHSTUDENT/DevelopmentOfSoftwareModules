using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6
{
    // Modification No.3
    public class Tour
    {
        public void TourCalc()
        {
            Console.WriteLine("Country: Minsk Sea | Price: free");
        }

        public void TourCalc(string country)
        {
            Console.WriteLine($"Country: {country} | Price: 900");
        }

        public void TourCalc(string country, int days_count)
        {
            Console.WriteLine($"Country: {country} | Price: {900 * days_count}");
        }
    }
}
