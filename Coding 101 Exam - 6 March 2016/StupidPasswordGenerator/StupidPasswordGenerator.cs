using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int symbol1 = n - n + 1;
            while (symbol1 != n)
            {
                Console.Write("{0}{1}{2}{3}{4}{5}",symbol1,new string(''));
            }
        }
    }
}
