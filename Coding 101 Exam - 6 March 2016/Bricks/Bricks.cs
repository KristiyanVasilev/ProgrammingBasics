using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var bricks = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var cartCapacity = double.Parse(Console.ReadLine());

            var briksPerCours = workers * cartCapacity;
            var neededCourse = bricks / briksPerCours;
            Console.WriteLine(Math.Ceiling(neededCourse));
        }
    }
}
