using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictLambdaLINQLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var sortNums = new SortedDictionary<double, int>();
            foreach (var num in nums)
            {
                if (sortNums.ContainsKey(num))
                {
                    sortNums[num]++;
                }
                else
                {
                    sortNums[num] = 1;
                }
            }

            foreach (var num in sortNums.Keys)
            {
                Console.WriteLine($"{num} -> {sortNums[num]}");
            }
        }
    }
}
