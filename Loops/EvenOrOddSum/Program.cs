using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd= 0;
            int sumEven = 0;
            int diff = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }
            if (sumEven==sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOdd}");
            }
            else
            {
                diff = Math.Abs(sumOdd - sumEven);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
                
        }
    }
}
