using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMoney
{
    class ChangeMoney
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var cny = double.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            var bgn1 = bitcoins * 1168;
            var usd = cny * 0.15;
            var bgn2 = usd * 1.76;
            var bgnTotal = bgn1 + bgn2;
            var euro = bgnTotal / 1.95;
            var commision = (percent * euro) / 100;
            var result = euro - commision;
            Console.WriteLine(result);
        }
    }
}
