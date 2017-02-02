using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
            }
            if (gender == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
            }

        }
    }
}
