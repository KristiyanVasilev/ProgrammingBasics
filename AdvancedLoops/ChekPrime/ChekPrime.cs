using System;

namespace CheckPrime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            bool prime = true;
            bool underTwo = n <= 2;

            for (double i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0.00)
                {
                    prime = false;
                    break;
                }
            }
            if (prime && underTwo == false)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
