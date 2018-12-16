using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompairCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                }

                if (count== Math.Min(arr1.Length-1,arr2.Length-1))
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }

            }

            
        }
    }
}
