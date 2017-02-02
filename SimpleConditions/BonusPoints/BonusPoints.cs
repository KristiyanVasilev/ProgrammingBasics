using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            decimal bonusPoints = 0;
            var num = decimal.Parse(Console.ReadLine());
            if (num <= 100)
            {
                bonusPoints = 5;
            }

            else if (num >= 100 && num <= 1000)
            {
                bonusPoints = (num * 20 / 100);
            }

            else if (num >= 1000)
            {
                bonusPoints = (num * 10 / 100);
            }

            if (num%2==0)
            {
                bonusPoints += 1;
            }
            else if (num % 10 ==5)
            {
                bonusPoints +=2;
            }
    
            Console.WriteLine(bonusPoints);
            Console.WriteLine(num + bonusPoints);
        }
    }
}
