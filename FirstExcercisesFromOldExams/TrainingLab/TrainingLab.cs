using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            {
                var h = double.Parse(Console.ReadLine());
                var w = double.Parse(Console.ReadLine());
                var hinCentimeters = h * 100;
                var winCentimeters = w * 100;
                var LabLenght = Math.Floor(hinCentimeters / 120);
                var LabWidht = Math.Floor((winCentimeters - 100) / 70);
                var LabSpots = (LabLenght * LabWidht) - 3;
                Console.WriteLine(LabSpots);
            }
        }
    }
}
