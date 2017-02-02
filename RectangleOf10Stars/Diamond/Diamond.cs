using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
      
            int outsideLines = (n - 1) / 2;
            int insidLlines = n - 2 * outsideLines - 2;

            if (n % 2 == 0)
            {             
                for (int i = 0; i <= outsideLines + 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('_', outsideLines), new string('_', insidLlines));
                    insidLlines += 2;
                    outsideLines--;
                }

                for (int i = 0; i < outsideLines + 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('_', outsideLines), new string('_', insidLlines));
                    insidLlines -= 2;
                    outsideLines++;
                }
            }
            else
            {
                Console.WriteLine("{0}*{0}", new string('_', (n - 1) / 2));
            }


        }
    }
}
