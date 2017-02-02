using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var rows = double.Parse(Console.ReadLine());
            var lines = double.Parse(Console.ReadLine());
            var premiere = 12.00;
            var normal = 7.50;
            var discount = 5.00;
            var totalSpots = rows * lines;
            if (projection == "premiere")
            {
                Console.WriteLine("{0:f2}",totalSpots*premiere);
            }
            if (projection == "normal")
            {
                Console.WriteLine("{0:f2}", totalSpots * normal);
            }
            if (projection == "discount")
            {
                Console.WriteLine("{0:f2}", totalSpots * discount);
            }
        }
    }
}
