using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();

            if (inputCurrency == "USD")
            {
                if (outputCurrency == "BGN")
                {
                    Console.WriteLine(num*1.79549);
                }
                if (outputCurrency == "EUR")
                {
                    Console.WriteLine(num/ 1.95583);
                }
            }
        }
    }
}
