using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace CurrencyConvertor
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                var amount = double.Parse(Console.ReadLine());
                var inputCode = Console.ReadLine();
                var outputCode = Console.ReadLine();
                double firstConvertion = 0;
                double secondConvertion = 0;
                var m = 1;
                var mm = 1000;
                var cm = 100;
                var mi = 0.000621371192;
                var inc = 39.3700787;
                var km = 0.001;
                var ft = 3.2808399;
                var yd = 1.0936133;

                switch (inputCode)
                {
                    case "m":
                        firstConvertion = amount * m;
                        break;
                    case "mm":
                        firstConvertion = amount * mm;
                        break;
                    case "cm":
                        firstConvertion = amount * cm;
                        break;
                    case "mi":
                        firstConvertion = amount * mi;
                        break;
                    case "in":
                        firstConvertion = amount * inc;
                        break;
                    case "km":
                        firstConvertion = amount * km;
                        break;
                    case "ft":
                        firstConvertion = amount * ft;
                        break;
                    case "yd":
                        firstConvertion = amount * yd;
                        break;
                }

                switch (outputCode)
                {
                    case "m":
                        secondConvertion = firstConvertion / m;
                        break;
                    case "mm":
                        secondConvertion = firstConvertion / mm;
                        break;
                    case "cm":
                        secondConvertion = firstConvertion / cm;
                        break;
                    case "mi":
                        secondConvertion = firstConvertion / mi;
                        break;
                    case "in":
                        secondConvertion = firstConvertion / inc;
                        break;
                    case "km":
                        secondConvertion = firstConvertion / km;
                        break;
                    case "ft":
                        secondConvertion = firstConvertion / ft;
                        break;
                    case "yd":
                        secondConvertion = firstConvertion / yd;
                        break;
                }
                Console.WriteLine(secondConvertion);
            }
        }
    }

}
    }
}
