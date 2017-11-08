using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.MultiplyEvensByOdds
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);
            int result = GetMultiplyOfEvensAndOdds(input);
            Console.WriteLine(result);
        }

        static int GetMultiplyOfEvensAndOdds(int input)
        {
            int evenSum = GetSumOfEvens(input);
            int oddSum = GetSumOfOdds(input);
            return evenSum * oddSum;
        }

        static int GetSumOfOdds(int input)
        {
            int sum = 0;
            while (input >0)
            {
                int lastDigit = input % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                input /= 10;
            }
            return sum;
        }

        static int GetSumOfEvens(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int lastDigit = input % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                input /= 10;
            }
            return sum;
        }
    }
}
