using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var word = Console.ReadLine();
            if (num < 20)
            {
                if (word == "day")
                {
                    Console.WriteLine((num*0.79)+0.70);
                }
                else if (word == "night")
                {
                    Console.WriteLine((num * 0.90) + 0.70);
                }
            }
            if (num >= 20 && num <= 100)
            {
                Console.WriteLine(num*0.09);
            }
            if (num >= 100)
            {
                Console.WriteLine(num * 0.06);
            }
        }
    }
}
