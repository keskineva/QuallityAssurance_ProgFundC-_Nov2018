using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> allWordsList = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseList = new List<string>();
            List<string> mixedCaseList = new List<string>();
            List<string> upperCaseList = new List<string>();

            for (int i = 0; i < allWordsList.Count; i++)
            {
                if (IsAllUpper(allWordsList[i]))
                {
                    upperCaseList.Add(allWordsList[i]);
                }
                else if (IsAllLower(allWordsList[i]))
                {
                    lowerCaseList.Add(allWordsList[i]);
                }
                else
                {
                    mixedCaseList.Add(allWordsList[i]);
                }
            }
            Console.Write("Lower-case: ");
            Console.Write(string.Join(", ", lowerCaseList));
            Console.WriteLine();

            Console.Write("Mixed-case: ");
            Console.Write(string.Join(", ", mixedCaseList));
            Console.WriteLine();

            Console.Write("Upper-case: ");
            Console.Write(string.Join(", ", upperCaseList));
            Console.WriteLine();
        }
        public static bool IsAllUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsUpper(input[i]))
                    return false;
            }

            return true;
        }
        public static bool IsAllLower(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLower(input[i]))
                    return false;
            }

            return true;
        }
    }
}
