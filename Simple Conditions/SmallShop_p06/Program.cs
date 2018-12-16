using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop_p06
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            
            double quantity = double.Parse(Console.ReadLine());
            double total = 0;
            double priceCoffee = 0;
            double priceWater = 0;
            double priceBeer = 0;
            double priceSweets = 0;
            double pricePeanuts = 0;

            if (town.Equals("sofia"))
            {
                if (product.Equals("coffee"))
                {
                    priceCoffee = 0.50;
                    total = priceCoffee * quantity;
                    Console.WriteLine(total);
                }
                else if (product.Equals("water"))
                {
                    priceWater = 0.80;
                    total = priceWater * quantity;
                    Console.WriteLine(total);

                }

                else if (product.Equals("beer"))
                {
                    priceBeer = 1.20;
                    total = priceBeer * quantity;
                    Console.WriteLine(total);

                }
                else if (product.Equals("sweets"))
                {
                    priceSweets = 1.45;
                    total = priceSweets * quantity;
                    Console.WriteLine(total);

                }
                else if (product.Equals("peanuts"))
                {
                    pricePeanuts = 1.60;
                    total = pricePeanuts * quantity;
                    Console.WriteLine(total);

                }
            }
            if (town.Equals("plovdiv"))
            {
                if (product.Equals("coffee"))
                {
                    priceCoffee = 0.40;
                    total = priceCoffee * quantity;
                    Console.WriteLine(total);
                }
                else if (product.Equals("water"))
                {
                    priceWater = 0.70;
                    total = priceWater * quantity;
                    Console.WriteLine(total);

                }

                else if (product.Equals("beer"))
                {
                    priceBeer = 1.15;
                    total = priceBeer * quantity;
                    Console.WriteLine(total);

                }
                else if (product.Equals("sweets"))
                {
                    priceSweets = 1.30;
                    total = priceSweets * quantity;
                    Console.WriteLine(total);

                }
                else if (product.Equals("peanuts"))
                {
                    pricePeanuts = 1.50;
                    total = pricePeanuts * quantity;
                    Console.WriteLine(total);

                }
            }
            if (town.Equals("varna"))
            {
                if (product.Equals("coffee"))
                {
                    priceCoffee = 0.45;
                    total = priceCoffee * quantity;
                    Console.WriteLine(total);
                }
                else if (product.Equals("water"))
                {
                    priceWater = 0.70;
                    total = priceWater * quantity;
                    Console.WriteLine(total);

                }

                else if (product.Equals("beer"))
                {
                    priceBeer = 1.10;
                    total = priceBeer * quantity;
                    Console.WriteLine(total);

                }
                else if (product.Equals("sweets"))
                {
                    priceSweets = 1.35;
                    total = priceSweets * quantity;
                    Console.WriteLine(total);

                }
                else if (product.Equals("peanuts"))
                {
                    pricePeanuts = 1.55;
                    total = pricePeanuts * quantity;
                    Console.WriteLine(total);

                }
            }

        }
    }
}
