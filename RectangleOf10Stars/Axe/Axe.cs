using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSide = n * 3;
            int mid = 0;
            int rightSide = n * 2 - 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftSide), new string('-', mid), new string('-', rightSide));
                mid++;
                rightSide--;
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftSide), new string('-', n - 1), new string('-', n - 1));
            }

            mid = n - 1;
            rightSide = n - 1;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftSide), new string('-', mid), new string('-', rightSide));
                mid += 2;
                leftSide--;
                rightSide--;
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftSide ), new string('*', mid ), new string('-', rightSide));

        }
    }
}
