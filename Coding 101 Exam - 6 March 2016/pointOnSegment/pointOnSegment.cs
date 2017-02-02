using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointOnSegment
{
    class pointOnSegment
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var point = double.Parse(Console.ReadLine());

            var rightEnd = 0.00;
            var leftEnd = 0.00;

            if (first > second)
            {
                 rightEnd = first;
                 leftEnd = second;
            }
            else
            {
                 leftEnd = first;
                 rightEnd = second;
            }
            if (point >= leftEnd && point <= rightEnd)
            {
                Console.WriteLine("in");
                if (Math.Abs(rightEnd - point) < Math.Abs(leftEnd - point))
                {
                    Console.WriteLine(Math.Abs(rightEnd-point));
                }
                else
                {
                    Console.WriteLine(Math.Abs(leftEnd-point));
                }
            }
            else
            {
                Console.WriteLine("out");
                if (Math.Abs(rightEnd - point) < Math.Abs(leftEnd - point))
                {
                    Console.WriteLine(Math.Abs(rightEnd - point));
                }
                else
                {
                    Console.WriteLine(Math.Abs(leftEnd - point));
                }
            }
        }
    }
}
