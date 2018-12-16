using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbersfrom2_0to2_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num = 0;
            for (int i = 0; i <=n; i++)
            {
                num = Math.Pow(2, i);
                Console.WriteLine(num);
            }
        }
    }
}
