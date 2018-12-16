using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeqOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int len = array.Length;

            MaxIncreaseSeq(array,len);

        }

        static void MaxIncreaseSeq(int [] array, int len)
        { 
            int countCurSeq = 0;
            int startCurSeq = 0;
            int countMaxSeq = 0;
            int startMaxSeq = 0;

            for (int pos = 1; pos < len; pos++)
            {
                if (array[pos] - array[pos - 1] >= 1)
                {
                    countCurSeq++;
                    startCurSeq = pos - countCurSeq;
                    if (countCurSeq > countMaxSeq)
                    {
                        countMaxSeq = countCurSeq;
                        startMaxSeq = startCurSeq;
                    }
                }
                else
                {
                    countCurSeq = 0;
                }

            }
            for (int i =startMaxSeq; i <= (startMaxSeq+countMaxSeq); i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
