using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalPairs
{
    class equalPairs
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxdiff = 0;

            for (int i = 0; i < input; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;

                if (num1 + num2 == sum)
                {
                    continue;
                }
                else
                {
                    maxdiff = num1 - num2;
                }
            }
            if (maxdiff != 0)
            {
                Console.WriteLine("No, maxdiff={0}",Math.Abs(maxdiff));
            }
            else
            {
                Console.WriteLine("Yes, value={0}",sum);
            }
        }
    }
}
