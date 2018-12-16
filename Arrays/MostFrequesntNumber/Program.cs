using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequesntNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] count = new int[65536];

            foreach (var num in numbers)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (count[numbers[i]] == maxValue)
                {
                    Console.WriteLine(numbers[i]);
                    return;
                }

            }

          
        }
    }
}
