using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backToThePast
{
    class backToThePast
    {
        static void Main(string[] args)
        {
            var legacyMoney = double.Parse(Console.ReadLine());
            var yearToLive = double.Parse(Console.ReadLine());
            var yearsCount = yearToLive - 1800;

            for (int i = 0; i <= yearsCount; i++)
            {
                if (i % 2 == 0)
                {
                    legacyMoney -= 12000;
                }
                else
                {
                    legacyMoney -= 12000 + (50* (18+i));
                }
            }
            if (legacyMoney>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",legacyMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(legacyMoney));
            }
        }
    }
}
