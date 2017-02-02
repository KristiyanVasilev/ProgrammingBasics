using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var vinaryMeters = double.Parse(Console.ReadLine());
            var grapePerMeter = double.Parse(Console.ReadLine());
            var litersNeeded = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());

            var totalGrape = vinaryMeters * grapePerMeter;
            var wine = 0.4 * (totalGrape / 2.50);
            if (wine>=litersNeeded)
            {
                var result = (wine - litersNeeded);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(result),Math.Ceiling(result/workers));
            }
            else
            {
                var result = (litersNeeded - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(result));
            }
        }
    }
}
