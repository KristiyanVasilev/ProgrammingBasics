using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billetsForGame
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var numberOfPeople = double.Parse(Console.ReadLine());

            if (numberOfPeople >= 1 && numberOfPeople<= 4)
            {
                var transport = 0.75 * budget;
                var moneyLeft = budget - transport;
                var priceNormal = 249.99 * numberOfPeople;
                var priceVIP = 499.99 * numberOfPeople;

                if (category == "normal" && moneyLeft >= priceNormal)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.",moneyLeft - priceNormal);
                }
                else if (category == "normal" && moneyLeft <= priceNormal)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.",priceNormal - moneyLeft);
                }
                else if (category == "vip" && moneyLeft >= priceVIP)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceVIP);
                }
                else if (category == "vip" && moneyLeft <= priceVIP)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceVIP - moneyLeft);
                }              
            }
            if (numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                var transport = 0.6 * budget;
                var moneyLeft = budget - transport;
                var priceNormal = 249.99 * numberOfPeople;
                var priceVIP = 499.99 * numberOfPeople;

                if (category == "normal" && moneyLeft >= priceNormal)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceNormal);
                }
                else if (category == "normal" && moneyLeft <= priceNormal)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceNormal - moneyLeft);
                }
                else if (category == "vip" && moneyLeft >= priceVIP)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceVIP);
                }
                else if (category == "vip" && moneyLeft <= priceVIP)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceVIP - moneyLeft);
                }
            }
            if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                var transport = 0.5 * budget;
                var moneyLeft = budget - transport;
                var priceNormal = 249.99 * numberOfPeople;
                var priceVIP = 499.99 * numberOfPeople;

                if (category == "normal" && moneyLeft >= priceNormal)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceNormal);
                }
                else if (category == "normal" && moneyLeft <= priceNormal)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceNormal - moneyLeft);
                }
                else if (category == "vip" && moneyLeft >= priceVIP)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceVIP);
                }
                else if (category == "vip" && moneyLeft <= priceVIP)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceVIP - moneyLeft);
                }
            }
            if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                var transport = 0.4 * budget;
                var moneyLeft = budget - transport;
                var priceNormal = 249.99 * numberOfPeople;
                var priceVIP = 499.99 * numberOfPeople;

                if (category == "normal" && moneyLeft >= priceNormal)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceNormal);
                }
                else if (category == "normal" && moneyLeft <= priceNormal)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceNormal - moneyLeft);
                }
                else if (category == "vip" && moneyLeft >= priceVIP)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceVIP);
                }
                else if (category == "vip" && moneyLeft <= priceVIP)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceVIP - moneyLeft);
                }
            }
            if (numberOfPeople >= 50)
            {
                var transport = 0.25 * budget;
                var moneyLeft = budget - transport;
                var priceNormal = 249.99 * numberOfPeople;
                var priceVIP = 499.99 * numberOfPeople;

                if (category == "normal" && moneyLeft >= priceNormal)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceNormal);
                }
                else if (category == "normal" && moneyLeft <= priceNormal)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceNormal - moneyLeft);
                }
                else if (category == "vip" && moneyLeft >= priceVIP)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceVIP);
                }
                else if (category == "vip" && moneyLeft <= priceVIP)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceVIP - moneyLeft);
                }
            }

        }
    }
}
