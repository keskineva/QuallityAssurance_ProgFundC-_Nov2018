using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainMasiv = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedArr = new int[mainMasiv.Length - 1];

            if (mainMasiv.Length == 1)
            {
                Console.WriteLine(mainMasiv[0]);
                return;
            }

            for (int i = 0; i < mainMasiv.Length; i++)
            {
                for (int j = 0; j < condensedArr.Length - i; j++)
                {
                    condensedArr[j] = mainMasiv[j] + mainMasiv[j + 1];
                }
                mainMasiv = condensedArr;
            }
            Console.WriteLine(condensedArr[0]);

        }
    }
}
