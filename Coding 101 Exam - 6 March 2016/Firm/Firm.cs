using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            var hours = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());

            var training = 0.1 * days;
            var workHours = (days - training)*8;
            var overtimeWorkers = workers * (2 * days);
            var totalHours = Math.Floor(workHours + overtimeWorkers);
            if (totalHours >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.",(totalHours-hours));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.",Math.Abs(totalHours - hours));
            }
        }
    }
}
