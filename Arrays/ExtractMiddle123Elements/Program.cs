﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddle123Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            ExtractMiddleNumbers(array1);
        }

       

        public static void ExtractMiddleNumbers(int[] array)
        {
            if (array.Length == 1)
            {
                Console.Write($"{{ {array[0]} }}");
            }
            else if (array.Length % 2 == 0)
            {
                Console.Write($"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]} }}");
            }
            else
            {
                Console.Write($"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length / 2 + 1]} }}");
            }

        }


    }

}
