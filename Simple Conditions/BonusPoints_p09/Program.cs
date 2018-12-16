using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints_p09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int num = int.Parse(Console.ReadLine());

            double bonusPoints = 0;
          

            if (num % 2 == 0)
            {
                bonusPoints += 1;
            }
            if (num % 10==5)
            {
                bonusPoints += 2;
            }

            if (num <= 100)
            {
                bonusPoints += 5;
            }
            else if (num > 100 && num < 1000)
            {
                bonusPoints += num * 0.20;
            }
            else if (num >= 1000)
            {
                bonusPoints += num * 0.10;
            }

            double bonusScore = bonusPoints;
            double totalScore = bonusPoints+num;

            Console.WriteLine("Bonus score: "+(bonusScore));
            Console.WriteLine("Total score: " + (totalScore));
        }
    }
}
