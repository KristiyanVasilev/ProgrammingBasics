using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class onTimeForExam
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine()) * 60;
            var minutes = int.Parse(Console.ReadLine());
            var ariveHour = int.Parse(Console.ReadLine()) * 60;
            var ariveMinutes = int.Parse(Console.ReadLine());

            var arive = ariveHour + ariveMinutes;
            var start  = hour + minutes;
            var late = arive > start;
            var onTime = start > arive;

            if (late && (arive - start) < 30)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", (arive-start).ToString("00"));
            }
            else if (late && (arive - start) >= 30)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1} hours after the start", (arive - hour)/60,(arive-hour)%60);
            }
            else if (onTime && (start - arive) <= 30 )
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start",start-arive);
            }
            else if (onTime && (start - arive) > 30 && (start - arive)<60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", start - arive);
            }
            else if (onTime && (start - arive) >= 60 )
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}:{1} hours before the start", (start - arive) / 60, ((start - arive) % 60).ToString("00"));
            }
            
        }
    }
}
