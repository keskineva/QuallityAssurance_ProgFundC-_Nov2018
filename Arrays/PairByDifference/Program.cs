using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (var num in numbers)
            {
                foreach (var nextNum in numbers)
                {
                    if (num==nextNum+difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
