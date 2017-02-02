using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairTale
{
    class RepairTale
    {
        static void Main(string[] args)
        {
            {
                var lenght = int.Parse(Console.ReadLine());
                var tilesWidth = double.Parse(Console.ReadLine());
                var tilesLenght = double.Parse(Console.ReadLine());
                var benchWidth = int.Parse(Console.ReadLine());
                var benchLenght = int.Parse(Console.ReadLine());

                var landing = lenght * lenght;
                var bench = benchWidth * benchLenght;
                var tiles = tilesWidth * tilesLenght;
                var totalSpot = landing - bench;
                var tilesNeeded = totalSpot / tiles;
                var timeNeeded = tilesNeeded * 0.2;
                Console.WriteLine(tilesNeeded);
                Console.WriteLine(timeNeeded);
            }
        }
    }
}
