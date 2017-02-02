using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfSumElements
{
    class halfSumElements
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            double sum = 0;
            double biggestNumber = double.MinValue;

            for (int i = 0; i < input; i++)
            {
                var number = double.Parse(Console.ReadLine());
                sum += number;

                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }

            if (sum / biggestNumber == 2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum - biggestNumber);
            }
            else 
            {
                var difference = biggestNumber - (sum - biggestNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",Math.Abs(difference));
            }
        }
    }
}
