using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFugures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "square":
                    double side = double.Parse(Console.ReadLine());
                    double areaSq = side * side;
                    Console.WriteLine($"{areaSq}");
                    break;
                case "rectangle":
                    double side1 = double.Parse(Console.ReadLine());
                    double side2 = double.Parse(Console.ReadLine());
                    double areaRect = side1 * side2;
                    Console.WriteLine($"{areaRect}");
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    double areaCirc = Math.PI * r * r;
                    Console.WriteLine($"{areaCirc:F3}");
                    break;
                case "triangle":
                    double side3 = double.Parse(Console.ReadLine());
                    double side4 = double.Parse(Console.ReadLine());
                    double areaTriang = (side3 * side4)/2;
                    Console.WriteLine($"{areaTriang}");
                    break;
                default:
                    break;
            }
        }
    }
}
