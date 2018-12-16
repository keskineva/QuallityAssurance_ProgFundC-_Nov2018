using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int? minNum = null;
            for (int i = 0; i < n; i++)
            {

                int number = int.Parse(Console.ReadLine());

                if (minNum == null || number <= minNum)
                {
                    minNum = number;
                }

            }

            Console.WriteLine(minNum);
        }
    }
}
