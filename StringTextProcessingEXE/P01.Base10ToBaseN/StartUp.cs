using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StringTextProcessing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger baseN = input[0];
            BigInteger num = input[1];
            Console.WriteLine(ConvertDecimalToBaseN(baseN, num));

        }

        private static string ConvertDecimalToBaseN(BigInteger baseN, BigInteger num)
        {
            StringBuilder res = new StringBuilder();
            StringBuilder resCorrect = new StringBuilder();
            string result = string.Empty;

            do
            {
                res.Append((num % baseN).ToString());
                num = num / baseN;
            } while (num > 0);

            for (int i = res.Length - 1; i >= 0; i--)
            {
                resCorrect.Append(res[i]);
            }
            return resCorrect.ToString();
        }
    }
}
