using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            double area = 0;
            var figure = Console.ReadLine();
            var num = double.Parse(Console.ReadLine());

            if (figure == "square")
                {
                    area = Math.Round(num * num,3);
                    Console.WriteLine(area);
                }

            if (figure == "rectangle")
                {
                    var num2 = double.Parse(Console.ReadLine());
                    area = Math.Round(num * num2,3);
                    Console.WriteLine(area);
                }

            if (figure == "circle")
                {
                    area = Math.Round((num * num)*Math.PI,3);
                    Console.WriteLine(area);
                }

            if (figure == "triangle")
                {
                    var num2 = double.Parse(Console.ReadLine());
                    area = Math.Round((num * num2)/2,3);
                    Console.WriteLine(area);
                }
        }
    }
}
