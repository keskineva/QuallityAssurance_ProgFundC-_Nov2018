using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            if (n<2)
            {
                Console.WriteLine("Not prime");
                return;
            }
            for (long divider = 2; divider <= Math.Sqrt(n); divider++)
            {
                if (n % divider == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
