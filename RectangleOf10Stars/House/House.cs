using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write(new string('-', (n / 2) - i));
                    Console.Write(new string('*', i * 2));
                    Console.Write(new string('-', (n / 2) - i));
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= (n / 2) + 1; i++)
                {
                    Console.Write(new string('-', (n / 2) + 1 - i));
                    Console.Write(new string('*', (i * 2) - 1));
                    Console.Write(new string('-', (n / 2) + 1 - i));
                    Console.WriteLine();
                }
            }

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
