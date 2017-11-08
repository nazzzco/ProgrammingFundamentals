using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.SortNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> result = new List<double>();
            result = nums;
            result.Sort();
            Console.WriteLine(String.Join(" <= ", result));

        }
    }
}
