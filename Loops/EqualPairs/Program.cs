using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int? sum = null;
            if (n<0)
            {
                return;
            }
            int[,] array = new int[n,2];
            for (int i = 0; i <n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2= int.Parse(Console.ReadLine());

                array[i, 0] = num1;
                array[i, 1] = num2;

                sum = num1 + num2;
            }
            if (n == 1)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else if (n>1)
            {
                // trqbva da proverqvam sumata na dvoikite, sprqmo purvata suma
                int purvaSuma = array[0,0]+array[0,1];
                int maxDiff=0;
                int minSum=purvaSuma;
                int maxSum=purvaSuma;
                for (int i = 1; i < n; i++)
                {
                    int tekushtaSuma = array[i, 0] + array[i, 1];
                    if (tekushtaSuma!=purvaSuma)
                    {
                        if (tekushtaSuma<minSum)
                        {
                            minSum = tekushtaSuma;
                        }
                        else if (tekushtaSuma>maxSum)
                        {
                            maxSum = tekushtaSuma;
                        }
                        int currDiff = Math.Abs(maxSum - minSum);
                        if (currDiff>maxDiff)
                        {
                            maxDiff = currDiff;
                        }
                    }
                }
                if (maxDiff==0)
                {
                    Console.WriteLine($"Yes, value={purvaSuma}");
                }
                else
                {
                    Console.WriteLine($"No, maxdiff={maxDiff}");
                }
            }
        }
    }
}
