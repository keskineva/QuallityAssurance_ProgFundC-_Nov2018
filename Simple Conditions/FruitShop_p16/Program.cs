using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop_p16
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());

            var price = -1D;



            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    price = amount * 2.5;
                }
                else if (fruit == "apple")

                {
                    price = amount * 1.20;
                }
                else if (fruit == "orange")

                {
                    price = amount * 0.85;
                }
                else if (fruit == "grapefruit")

                {
                    price = amount * 1.45;
                }
                else if (fruit == "kiwi")

                {
                    price = amount * 2.70;

                }
                else if (fruit == "pineapple")

                {
                    price = amount * 5.50;
                }
                else if (fruit == "grapes")

                {
                    price = amount * 3.85;
                }

                else
                {
                    Console.WriteLine("error");
                }

            }


            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    price = amount * 2.7;
                }
                else if (fruit == "apple")

                {
                    price = amount * 1.25;
                }
                else if (fruit == "orange")

                {
                    price = amount * 0.90;
                }
                else if (fruit == "grapefruit")

                {
                    price = amount * 1.60;
                }
                else if (fruit == "kiwi")

                {
                    price = amount * 3.00;

                }
                else if (fruit == "pineapple")

                {
                    price = amount * 5.60;
                }
                else if (fruit == "grapes")

                {
                    price = amount * 4.20;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine(Math.Round(price, 2));

        }
    }
}