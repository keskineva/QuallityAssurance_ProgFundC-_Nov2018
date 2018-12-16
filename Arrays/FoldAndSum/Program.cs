using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = original.Length / 4;

            int[] leftside = new int[k];
            int[] rightside = new int[k];
            int[] sum = new int[k*2];
            int[] newArr = new int[k*2];

            int[] middleArr = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                leftside[i] = original[k - i - 1];
                rightside[i] = original[original.Length - i - 1];
            }
            for (int j = 0; j < sum.Length/2; j++)
            {
                
                newArr[j] = leftside[j];
                
            }

            for (int j = 0; j < sum.Length / 2; j++)
            {
                newArr[k+j] = rightside[j];
                
            }

            for (int i = 0; i < k*2; i++)
            {
                middleArr[i] = original[i+k];
            }

            for (int i = 0; i < k*2; i++)
            {
                sum[i] = newArr[i] + middleArr[i];
            }

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
