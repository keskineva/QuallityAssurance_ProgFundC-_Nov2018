using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int diff = 0;
            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                sum1 += number1;
            }

            for (int i = 0; i < n; i++)
            {
                int number2 =int.Parse(Console.ReadLine());
                sum2 += number2;
            }

            if (sum1==sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                diff = Math.Abs(sum1 - sum2);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
