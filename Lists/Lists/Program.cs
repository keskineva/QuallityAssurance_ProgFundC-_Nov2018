using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newNumbers = new List<int>();

            foreach (var num in numbers)
            {
                if (num>=0)
                {
                    newNumbers.Add(num);
                }
            }

            if (newNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                newNumbers.Reverse();
                foreach (var item in newNumbers)
                {
                    Console.Write(item + " ");
                }
            }
            
        }
    }
}
