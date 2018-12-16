using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = original.Length;

            int[] sum = new int[original.Length];
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int lastIndex = original.Length - 1;
                for (int j = 0; j < lastIndex; j++)
                {
                    original[j] ^= original[lastIndex];
                    original[lastIndex] ^= original[j];
                    original[j] ^= original[lastIndex];
                }

                for (int r = 0; r < original.Length; r++)
                {
                    sum[r] += original[r];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
