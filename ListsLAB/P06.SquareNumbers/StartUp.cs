using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.SquareNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> squareNums = new List<double>();

            foreach (double num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNums.Add(num);
                }
            }

            squareNums.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(String.Join(" ", squareNums));
        }
    }
}
