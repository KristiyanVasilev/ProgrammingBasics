using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange
{
    class NumberInRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n > 100 || n <= 0)
            {
                Console.WriteLine("Invalid number!");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", n);
        }
    }
}
