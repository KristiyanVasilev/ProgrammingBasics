using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = double.Parse(Console.ReadLine());
            var weekendsInProvince = double.Parse(Console.ReadLine());

            var weekendsInSofia = 48 - weekendsInProvince;
            var gamesInSofia = weekendsInSofia * (3.00 / 4);
            var holidayGames = holidays * (2.00 / 3);
            var totalGames = gamesInSofia + holidayGames + weekendsInProvince;
            if (year == "leap")
            {
                var bonus = 0.15 * totalGames;
                Console.WriteLine(Math.Truncate(totalGames + bonus));
            }
            else
            {
                Console.WriteLine(Math.Truncate(totalGames));
            }


        }
    }
}
