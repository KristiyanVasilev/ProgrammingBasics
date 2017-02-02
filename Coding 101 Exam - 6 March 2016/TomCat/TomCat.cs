using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCat
{
    class TomCat
    {
        static void Main(string[] args)
        {
            var daysOff = int.Parse(Console.ReadLine());
            var workDays = 365 - daysOff;
            var timeForPlay = (workDays * 63) + (daysOff * 127);
            if (timeForPlay <= 30000)
            {
                var minutesLess = (30000-timeForPlay);
                var hours = minutesLess / 60;
                var minutes = minutesLess % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",hours,minutes);
            }
            if (timeForPlay >= 30000)
            {
                var minutesLess = (timeForPlay - 30000);
                var hours = minutesLess / 60;
                var minutes = minutesLess % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",hours,minutes);
            }
        }
    }
}
