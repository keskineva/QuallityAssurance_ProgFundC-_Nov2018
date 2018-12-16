using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNum = input[0];
            int power = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNum)
                {
                    int leftindex = Math.Max(i - power, 0);
                    int rightindex = Math.Min(i + power, numbers.Count - 1);

                    numbers.RemoveRange(i, rightindex - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftindex, i - leftindex);
                    i = 0;
                }

            }
            Console.WriteLine(string.Join("", numbers.Sum()));
            //Console.WriteLine("{0} {1}", position , lenght);

        }
    }
}
