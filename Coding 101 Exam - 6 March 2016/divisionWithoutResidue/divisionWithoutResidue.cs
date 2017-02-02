using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisionWithoutResidue
{
    class divisionWithoutResidue
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double devideByTwo = 0.00;
            double devideByThree = 0.00;
            double devideByFour = 0.00;
            double inputNumber = 0.00;


            for (int i = 0; i < n; i++)
            {
                inputNumber = double.Parse(Console.ReadLine());

                if (inputNumber % 2.00 == 0)
                {
                    devideByTwo++;
                }
                if (inputNumber % 3.00 == 0)
                {
                    devideByThree++;
                }
                if (inputNumber % 4.00 == 0)
                {
                    devideByFour++;
                }
            }
            var p1 = devideByTwo / n * 100;
            var p2 = devideByThree / n * 100;
            var p3 = devideByFour / n * 100;
            Console.WriteLine("{0:f2}%",p1);
            Console.WriteLine("{0:f2}%",p2);
            Console.WriteLine("{0:f2}%",p3);
        }
    }
}
