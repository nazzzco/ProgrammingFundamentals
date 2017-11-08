using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.SumReversedNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> values = input.Split(' ').ToList();

            List<int> reversed = new List<int>();
            for (int i = 0; i < values.Count; i++)
            {
                string reverse = values[i];
                string result = new string(reverse.ToCharArray().Reverse().ToArray());
                reversed.Add(int.Parse(result));
            }
            int sum = 0;

            foreach (var item in reversed)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
