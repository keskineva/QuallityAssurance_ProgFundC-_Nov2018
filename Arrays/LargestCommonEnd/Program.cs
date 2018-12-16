using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();
            int smallerArr = Math.Min(firstArr.Length, secondArr.Length);
            int leftCorner = 0;
            int rightCorner = 0;
            for (int left = 0; left < smallerArr; left++)
            {
                if (firstArr[left] == secondArr[left])
                {
                    leftCorner++;
                }
                else
                {
                    break;
                }
            }
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            for (int right = 0; right < smallerArr; right++)
            {
                if (secondArr[right] == firstArr[right])
                {
                    rightCorner++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Math.Max(leftCorner, rightCorner));
        }

    }
}

