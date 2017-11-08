using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.CharMultiplier
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            int totalSum = 0;
            int maxLength = Math.Max(input[0].Length, input[1].Length);

            if (input[0].Length == input[1].Length)
            {
                for (int i = 0; i < maxLength; i++)
                {
                    int sum = (input[0])[i] * (input[1])[i];
                    totalSum += sum;
                }
            }

            else if (input[0].Length > input[1].Length)
            {
                for (int j = 0; j < input[1].Length; j++)
                {
                    int sum = (input[0])[j] * (input[1])[j];
                    totalSum += sum;
                }
                input[0].Reverse();

                for (int i = 0; i < input[0].Length - input[1].Length; i++)
                {
                    totalSum += (input[0])[i];
                }
            }

            else
            {
                for (int j = 0; j < input[0].Length; j++)
                {
                    int sum = (input[0])[j] * (input[1])[j];
                    totalSum += sum;
                }
                input[1].Reverse();

                for (int i = 0; i < input[1].Length - input[0].Length; i++)
                {
                    totalSum += (input[1])[i];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}