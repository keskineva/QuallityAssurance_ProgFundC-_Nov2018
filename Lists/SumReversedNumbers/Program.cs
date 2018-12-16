using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;


            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i].ToString();
                int newNum = numbers[i].ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
                sum += newNum;
            }

            Console.WriteLine(sum);
        }
    }
}
