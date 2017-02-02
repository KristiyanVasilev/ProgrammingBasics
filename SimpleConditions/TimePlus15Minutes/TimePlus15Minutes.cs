using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            
            var min2 = min + 15;
            if (min2 > 59)
            {
                hour += 1;
                min2 -= 60;
            }
            if (hour >= 23 && min>=45)
            {
                hour = 0;      
            }
            Console.WriteLine("{0}:{1:00}",hour,min2);
        }
    }
}
