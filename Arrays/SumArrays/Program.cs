using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int max = Math.Max(len1, len2);
            int[] summedArr = new int[Math.Max(len1, len2)];
            

           
                for (int i = 0; i < max; i++)
                {
                 summedArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
                }
                
           
            
            Console.WriteLine(string.Join(" ", summedArr));
        }
        
    }
}
