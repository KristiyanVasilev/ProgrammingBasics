using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConvertor
{
    class MetricConvertor
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            
            if (input == "km")
            {
                if (output == "m")
                {
                    var result = (num / 0.001);
                    Console.WriteLine(result + " m");
                }
                if (output == "mm")
                {
                    var result = (num / 0.001)*1000;
                    Console.WriteLine(result + " mm");
                }

                if (output == "cm")
                {
                    var result = (num / 0.001) * 100;
                    Console.WriteLine(result + " cm");
                }
                if (output == "mi")
                {
                    var result = (num / 0.001) * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (output == "in")
                {
                    var result = (num / 0.001) * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (output == "ft")
                {
                    var result = (num / 0.001) * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (output == "yd")
                {
                    var result = (num / 0.001) * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (output == "km")
                {
                    Console.WriteLine(num + " km");
                }
            }

            if (input == "mm")
            {
                if (output == "m")
                {
                    var result = (num / 1000);
                    Console.WriteLine(result + " m");
                }
                if (output == "km")
                {
                    var result = (num / 1000) * 0.001;
                    Console.WriteLine(result + " km");
                }

                if (output == "cm")
                {
                    var result = (num / 1000) * 100;
                    Console.WriteLine(result + " cm");
                }
                if (output == "mi")
                {
                    var result = (num / 1000) * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (output == "in")
                {
                    var result = (num / 1000) * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (output == "ft")
                {
                    var result = (num / 1000) * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (output == "yd")
                {
                    var result = (num / 1000) * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (output == "mm")
                {
                    Console.WriteLine(num + " mm");
                }
            }
            if (input == "cm")
            {
                if (output == "m")
                {
                    var result = (num / 100);
                    Console.WriteLine(result + " m");
                }
                if (output == "km")
                {
                    var result = (num / 100) * 0.001;
                    Console.WriteLine(result + " km");
                }

                if (output == "mm")
                {
                    var result = (num / 100) * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (output == "mi")
                {
                    var result = (num / 100) * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (output == "in")
                {
                    var result = (num / 100) * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (output == "ft")
                {
                    var result = (num / 100) * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (output == "yd")
                {
                    var result = (num / 100) * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (output == "cm")
                {
                    Console.WriteLine(num + " cm");
                }
            }
            if (input == "mi")
            {
                if (output == "m")
                {
                    var result = (num / 0.000621371192);
                    Console.WriteLine(result + " m");
                }
                if (output == "km")
                {
                    var result = (num / 0.000621371192) * 0.001;
                    Console.WriteLine(result + " km");
                }

                if (output == "mm")
                {
                    var result = (num / 0.000621371192) * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (output == "cm")
                {
                    var result = (num / 0.000621371192)*100;
                    Console.WriteLine(result + " cm");
                }
                if (output == "in")
                {
                    var result = (num / 0.000621371192) * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (output == "ft")
                {
                    var result = (num / 0.000621371192) * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (output == "yd")
                {
                    var result = (num / 0.000621371192) * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (output == "mi")
                {
                    Console.WriteLine(num + " mi");
                }
            }
            if (input == "in")
            {
                if (output == "m")
                {
                    var result = (num / 39.3700787);
                    Console.WriteLine(result + " m");
                }
                if (output == "km")
                {
                    var result = (num / 39.3700787) * 0.001;
                    Console.WriteLine(result + " km");
                }

                if (output == "mm")
                {
                    var result = (num / 39.3700787) * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (output == "mi")
                {
                    var result = (num / 39.3700787)* 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (output == "cm")
                {
                    var result = (num / 39.3700787)*100;
                    Console.WriteLine(result + " cm");
                }
                if (output == "ft")
                {
                    var result = (num / 39.3700787) * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (output == "yd")
                {
                    var result = (num / 39.3700787) * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (output == "in")
                {
                    Console.WriteLine(num + " in");
                }
            }
            if (input == "ft")
            {
                if (output == "m")
                {
                    var result = (num / 3.2808399);
                    Console.WriteLine(result + " m");
                }
                if (output == "km")
                {
                    var result = (num / 3.2808399) * 0.001;
                    Console.WriteLine(result + " km");
                }

                if (output == "mm")
                {
                    var result = (num / 3.2808399) * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (output == "mi")
                {
                    var result = (num / 3.2808399)* 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (output == "in")
                {
                    var result = (num / 3.2808399)* 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (output == "yd")
                {
                    var result = (num / 3.2808399) * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
                if (output == "cm")
                {
                    var result = (num / 3.2808399) * 100;
                    Console.WriteLine(result + " cm");
                }
                if (output == "ft")
                {
                    Console.WriteLine(num + " ft");
                }
            }
            if (input == "yd")
            {
                if (output == "m")
                {
                    var result = (num / 1.0936133);
                    Console.WriteLine(result + " m");
                }
                if (output == "km")
                {
                    var result = (num / 1.0936133) * 0.001;
                    Console.WriteLine(result + " km");
                }

                if (output == "mm")
                {
                    var result = (num / 1.0936133) * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (output == "mi")
                {
                    var result = (num / 1.0936133)* 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (output == "in")
                {
                    var result = (num / 1.0936133)* 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (output == "cm")
                {
                    var result = (num / 1.0936133) * 100;
                    Console.WriteLine(result + " cm");
                }
                if (output == "ft")
                {
                    var result = (num / 1.0936133) * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (output == "yd")
                {
                    Console.WriteLine(num + " yd");
                }
            }
            if (input == "m")
            {
                if (output == "m")
                {
                    Console.WriteLine(num + " m");
                }
                if (output == "km")
                {
                    var result = num * 0.001;
                    Console.WriteLine(result + " km");
                }
                if (output == "mm")
                {
                    var result = num * 1000;
                    Console.WriteLine(result + " mm");
                }
                if (output == "mi")
                {
                    var result = num * 0.000621371192;
                    Console.WriteLine(result + " mi");
                }
                if (output == "in")
                {
                    var result = num * 39.3700787;
                    Console.WriteLine(result + " in");
                }
                if (output == "cm")
                {
                    var result = num * 100;
                    Console.WriteLine(result + " cm");
                }
                if (output == "ft")
                {
                    var result = num * 3.2808399;
                    Console.WriteLine(result + " ft");
                }
                if (output == "yd")
                {
                    var result = num * 1.0936133;
                    Console.WriteLine(result + " yd");
                }
            }
        }
    }
}
