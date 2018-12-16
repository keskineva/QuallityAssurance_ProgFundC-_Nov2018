using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;

            for (int indexInSeq = 1; indexInSeq < n; indexInSeq++)
            {
                long result = 0;
                for (int prevIndexOfSeq = indexInSeq - 1; prevIndexOfSeq >= 0 && prevIndexOfSeq >= indexInSeq - k; prevIndexOfSeq--)
                {
                    result = result + arr[prevIndexOfSeq];
                }
                arr[indexInSeq] = result;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
