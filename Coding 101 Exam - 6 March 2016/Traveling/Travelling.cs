using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var seson = Console.ReadLine().ToLower();

            if (budget <= 100 && seson == "winter")
            {
                var price = 0.7 * budget;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:f2}",price);
            }
            else if (budget<=100 && seson == "summer")
            {
                var price = 0.3 * budget;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:f2}", price);
            }
            else if (budget <= 1000 && seson == "winter")
            {
                var price = 0.8 * budget;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:f2}", price);
            }
            else if (budget <= 1000 && seson == "summer")
            {
                var price = 0.4 * budget;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:f2}", price);
            }
            else if (budget >= 1000 && seson == "winter")
            {
                var price = 0.9 * budget;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", price);
            }
            else if (budget >= 1000 && seson == "summer")
            {
                var price = 0.9 * budget;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", price);
            }
        }
    }
}
