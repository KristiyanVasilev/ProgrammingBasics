using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {
            var workdays = double.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var currencyValue = double.Parse(Console.ReadLine());

            var moneyPerMonth = workdays * moneyPerDay;
            var bonus = moneyPerMonth * 2.5;
            var moneyPerYear = (moneyPerMonth*12) + bonus;
            var taxes = (25 * moneyPerYear) / 100;
            var netoIncom = (moneyPerYear - taxes)*currencyValue;
            var result = netoIncom / 365;
            Console.WriteLine(Math.Round(result, 2));

        }
    }
}
