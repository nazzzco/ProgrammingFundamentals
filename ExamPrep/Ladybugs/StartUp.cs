using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Ladybugs
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        int[] health = new int[input.Count];
        double[] sum = new double[input.Count];

        string patternLetters = @"([A-Za-z]+)";

        for (int i = 0; i < input.Count; i++)
        {
            List<string> letters = new List<string>();

            foreach (Match m in Regex.Matches(input[i], patternLetters))
            {
                letters[i] = (int.Parse)(m.Value);
            }

            foreach (char ch in letters.ToString())
            {
                health[i] += (int)ch;
            }
        }


        string patternDigits = @"(\+?-?[0-9]\.?[0-9]?)";

        List<double> digits = new List<double>();
        for (int j = 0; j < input.Count; j++)
        {
            //foreach (Match d in Regex.Matches(input[j], patternDigits))
            //{
            //    digits[j] = (double.Parse(d.Value));
            //}
            //sum[j] = digits.Sum();
        }

        for (int k = 0; k < input.Count; k++)
        {
            int[] asterixCount = new int[input.Count];
            int[] backslashCount = new int[input.Count];
            List<char> asterix = new List<char>() { '*' };
            List<char> backslash = new List<char>() { '\\' };
            asterixCount[k] = input[k].Count(x => asterix.Contains(x));
            backslashCount[k] = input[k].Count(y => backslash.Contains(y));

            for (int i = 0; i < asterixCount.Length; i++)
            {
                sum[i] *= 2;
            }

            for (int j = 0; j < backslashCount.Length; j++)
            {
                sum[j] /= 2;
            }
        }

        foreach (var demon in input)
        {
            Console.WriteLine($"{input} - {health} health, {sum} damage");
        }

    }
}

