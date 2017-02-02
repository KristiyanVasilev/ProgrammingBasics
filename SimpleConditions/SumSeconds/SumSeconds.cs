using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var sec1 = double.Parse(Console.ReadLine());
            var sec2 = double.Parse(Console.ReadLine());
            var sec3 = double.Parse(Console.ReadLine());

            var totalSeconds = sec1 + sec2 + sec3;

            if (totalSeconds >= 0 && totalSeconds <= 59)
            {
                Console.WriteLine("0:{0:00}", totalSeconds);
            }       

            else if (totalSeconds >= 60 && totalSeconds <= 119)
            {
                Console.WriteLine("1:{0:00}", totalSeconds - 60);
            }

            else if (totalSeconds >= 120 && totalSeconds <= 179)
            {
                Console.WriteLine("2:{0:00}", totalSeconds-120);
            }
        }
    }
}
