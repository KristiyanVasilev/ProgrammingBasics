﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int r = 1; r < n; r++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
