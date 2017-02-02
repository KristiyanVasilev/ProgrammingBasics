using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0}", number);
                    Console.Write(" ");
                    number++;
                    if (number > n)
                    {
                        break;
                    }
                }
                if (number > n)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
