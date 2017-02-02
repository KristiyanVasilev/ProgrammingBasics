using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "snake":
                case "tortoise":
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
