using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGD
{
    class CGD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.MinValue;

            c = a % b;
            int result = b % c;
            Console.WriteLine(result);

            
            
        }
    }
}
