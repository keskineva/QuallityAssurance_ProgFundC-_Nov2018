using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;

            }
            Console.WriteLine(factoriel);
        }
    }
}
