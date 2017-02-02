using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            var percent = -1.00;
            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500) percent = 0.05;
                else if (sales > 500 && sales <= 1000) percent = 0.07;
                else if(sales > 1000 && sales <= 10000) percent = 0.08;
                else if(sales > 10000) percent = 0.12;
                Console.WriteLine("{0:f2}",percent *sales);

            }
            if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500) percent = 0.045;
                else if (sales > 500 && sales <= 1000) percent = 0.075;
                else if (sales > 1000 && sales <= 10000) percent = 0.1;
                else if (sales > 10000) percent = 0.13;
                Console.WriteLine("{0:f2}",percent *sales);
            }
            if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500) percent = 0.055;
                else if (sales > 500 && sales <= 1000) percent = 0.08;
                else if (sales > 1000 && sales <= 10000) percent = 0.12;
                else if (sales > 10000) percent = 0.145;
                Console.WriteLine("{0:f2}",percent*sales);
            }
            if (percent == -1)
            {
                Console.WriteLine("error");
            }
           
        }
    }
}
