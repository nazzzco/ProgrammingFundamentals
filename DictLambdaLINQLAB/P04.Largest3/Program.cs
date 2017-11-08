using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Largest3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nums = input.OrderByDescending(x => x);
            if (input.Count < 3)
            { 
                Console.WriteLine(string.Join(" ", nums));
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums.Take(3)));
            }

        }
    }
}
