﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine(days[0]);
                    break;
                case 2:
                    Console.WriteLine(days[1]);
                    break;
                case 3:
                    Console.WriteLine(days[2]);
                    break;
                case 4:
                    Console.WriteLine(days[3]);
                    break;
                case 5:
                    Console.WriteLine(days[4]);
                    break;
                case 6:
                    Console.WriteLine(days[5]);
                    break;
                case 7:
                    Console.WriteLine(days[6]);
                    break;

                default:
                    Console.WriteLine("Invalid Day!");
                    break;
            }
        }
    }
}
