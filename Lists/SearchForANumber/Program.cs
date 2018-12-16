using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> modifiedNums = new List<int>();

            modifiedNums = numbers;

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numbersToTake = array[0];
            int numbersToDelete = array[1];
            int numberToSearch = array[2];

            for (int i = 0; i < numbersToTake; i++)
            {
                while (numbersToDelete > 0)
                {
                    numbersToDelete--;
                    modifiedNums.RemoveAt(0);
                }
            }

            if (modifiedNums.Contains(numberToSearch))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }



        }
    }
}
