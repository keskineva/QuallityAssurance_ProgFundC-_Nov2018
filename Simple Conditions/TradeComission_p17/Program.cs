using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComission_p17
{
    class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine().ToLower();
            double number = double.Parse(Console.ReadLine());

           

            double comission = 0; ;

            if (town=="sofia")
            {
                if (number<=500)
                {
                    comission = number * 0.05;
                }
                else if (number>500 && number<=1000)
                {
                    comission = number * 0.07;
                }
                else if (number > 1000 && number <= 10000)
                {
                    comission = number * 0.08;
                }
                else if (number > 10000)
                {
                    comission = number * 0.12;
                }
                Console.WriteLine($"{comission:f2}");

            }
            else if (town=="varna")
            {
                if (number <= 500)
                {
                    comission = number * 0.045;
                }
                else if (number > 500 && number <= 1000)
                {
                    comission = number * 0.075;
                }
                else if (number > 1000 && number <= 10000)
                {
                    comission = number * 0.10;
                }
                else if (number > 10000)
                {
                    comission = number * 0.13;
                }
                Console.WriteLine($"{comission:f2}");

            }
            else if (town == "plovdiv")
            {
                if (number <= 500)
                {
                    comission = number * 0.055;
                }
                else if (number > 500 && number <= 1000)
                {
                    comission = number * 0.08;
                }
                else if (number > 1000 && number <= 10000)
                {
                    comission = number * 0.12;
                }
                else if (number > 10000)
                {
                    comission = number * 0.145;
                }

                Console.WriteLine($"{comission:f2}");
            }
            else
            {
                if (number <= 0)
                
                Console.WriteLine("error");
            }
        }
    }
}
