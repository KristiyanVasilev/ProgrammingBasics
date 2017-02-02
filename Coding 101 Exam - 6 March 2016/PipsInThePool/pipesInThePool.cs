using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipsInThePool
{
    class pipesInThePool
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var result = (h * p1) + (h * p2);
            if (result <= v)
            {
                var percentfull = (result / v) * 100;
                var pipe1percents = ((h * p1) / result) * 100;
                var pipe2percents = ((h * p2) / result) * 100;
                Console.Write("The pool is {0}% full. ",Math.Truncate(percentfull));
                Console.WriteLine("Pipe 1: {0}%. Pipe 2: {1}%.",Math.Truncate(pipe1percents), Math.Truncate(pipe2percents));
            }
            if (result > v)
            {
                var overflows = result - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",h,overflows);
            }

        }
    }
}
