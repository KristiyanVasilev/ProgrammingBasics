using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int down = n;
            for (int i = 1; i <= n; i++)
            {
                for (int row = 1; row <= n; row++)
                {
                    Console.Write("{0}", num);
                    Console.Write(" ");
                    num++;
                }
                for (int row = 1; row <= n; row++)
                {
                    Console.Write("{0}", down);
                    Console.Write(" ");
                    down--;
                }
                Console.WriteLine();
            }
            
        }
    }
}
