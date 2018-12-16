using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] array = new int[num + num - 1];
            //  1 .. n (12345)
            for (int i = 0; i < num; i++)
            {
                array[i] = i + 1;
            }

            int vtoriIndex = num - 1;
            // n-1 .. 1 (4321)
            for (int i = num; i < array.Length; i++)
            {
                array[i] = vtoriIndex;
                vtoriIndex--;
            }


            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    Console.Write(array[col+row] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
