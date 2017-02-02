using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            int fPlus = 0;

            for (int i = 1; i < n; i++)
            {
                if (n < 2)
                {
                    break;
                }
                fPlus = f0 + f1;
                f0 = f1;
                f1 = fPlus;
            }
            Console.WriteLine(f1);
        }
    }
}
