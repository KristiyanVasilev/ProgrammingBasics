using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelRoom
{
    class hotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = double.Parse(Console.ReadLine());

            var priceStudio = 0.00;
            var priceApartment = 0.00;

            switch (month)
            {
                case "May":
                case "Octomber":
                    priceStudio = 50.00;
                    priceApartment = 65.00;

                    if (nights > 14)
                    {
                        priceStudio -= 0.3 * 50;
                        priceApartment -= 0.1 * 65;
                    }
                    else if (nights > 7)
                    {
                        priceStudio -= 0.05 * 50;
                    }
                    break;

                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApartment = 68.70;

                    if (nights > 14)
                    {
                        priceStudio -= 0.2 * 75.20;
                        priceApartment -= 0.1 * 68.70;
                    }
                    break;
                case "July":
                case "August":
                    priceStudio = 76.00;
                    priceApartment = 77.00;

                    if (nights>14)
                    {
                        priceApartment -= 0.1 * 77.00;
                    }
                    break;
            }

                    Console.WriteLine("Apartment: {0:f2} lv.", priceApartment*nights);
                    Console.WriteLine("Studio: {0:f2} lv.", priceStudio * nights);
            }
        }
    }

