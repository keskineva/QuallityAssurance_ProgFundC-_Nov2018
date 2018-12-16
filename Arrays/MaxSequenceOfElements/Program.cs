using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int bestStart = 0;
            int len = 0;
            int bestLen = 0;

            for (int pos = 1; pos < array.Length; pos++)
            {
                if (array[start] == array[pos])
                {
                    len++;
                    if (len>bestLen)
                    {
                        bestLen = len;
                        bestStart = start;

                    }
                }
                else
                {
                    start++;
                    pos = start;
                    len = 0;

                }

            }
            for (int i = 0; i <= bestLen; i++)
            {
                Console.Write(array[bestStart+i] + " ");
            }


        }
    }
}
