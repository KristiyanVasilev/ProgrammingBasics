using System;

namespace RhombusOfStars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");

                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int row = 1; row < n; row++)
            {
                Console.Write(new string(' ', row));
                Console.Write("*");

                for (int i = n - 1; i > row; i--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
