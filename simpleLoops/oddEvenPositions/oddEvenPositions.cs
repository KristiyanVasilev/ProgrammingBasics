using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEvenPositions
{
    class oddEvenPositions
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            var oddSum = 0.00;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenSum = 0.00;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            for (int i = 1; i <= input; i++)
            {
                if (i % 2 == 0)
                {
                    var evenNumber = double.Parse(Console.ReadLine());
                    evenSum += evenNumber;
                    if (evenNumber > evenMax)
                    {
                        evenMax = evenNumber;
                    }
                    if (evenNumber < evenMin)
                    {
                        evenMin = evenNumber;
                    }
                }
                else
                {
                    var oddNumber = double.Parse(Console.ReadLine());
                    oddSum += oddNumber;
                    if (oddNumber > oddMax)
                    {
                        oddMax = oddNumber;
                    }
                    if (oddNumber < oddMin)
                    {
                        oddMin = oddNumber;
                    }
                }
            }
            Console.WriteLine("OddSum={0},", oddSum);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0},", oddMin);
            }

            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMax={0},", oddMax);
            }

            Console.WriteLine("EvenSum={0},", evenSum);

            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine("EvenMin={0},", evenMin);
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax={0}", evenMax);
            }
        }
    }
}
