using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


             int? maxNum = null;
            for (int i = 0; i < n; i++)
            {
                
                int number = int.Parse(Console.ReadLine());
               
                if (maxNum==null || number>=maxNum)
                {
                    maxNum = number;
                }
            
            }
            
            Console.WriteLine(maxNum);
        }
    }
}
