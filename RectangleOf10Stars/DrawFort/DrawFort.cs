using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int element = n / 2;
            int underlines = n * 2 - 2 * element - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', element), new string('_', underlines));
            for (int i = 1; i <= n - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ', element + 1), new string('_', underlines));
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', element), new string(' ', underlines));



        }
    }
}
