using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_p18
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double pricePremiere = 12;
            double priceNormal = 7.50;
            double priceDiscount = 5.00;

            double money = 0;

            switch (type)
            {
                case "Premiere":
                    money = pricePremiere * r * c;
                    break;
                case "Normal":
                    money = priceNormal * r * c;
                    break;
                case "Discount":
                    money = priceDiscount * r * c;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{money:f2}");


        }
    }
}
