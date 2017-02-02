using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var blanks = new string(' ', n);
            Console.Write(blanks);
            Console.Write(" | ");
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.Write(new string('*', i));
                Console.Write(new string(' ', n - i));
                Console.WriteLine();
            }
        }
    }
}
