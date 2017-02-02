using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();

            for (int s = 1; s <= n - 2; s++)
            {
                Console.Write("|");
                for (int i = 0; i < n-2; i++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }

            Console.Write("+");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();

        }
    }
}
