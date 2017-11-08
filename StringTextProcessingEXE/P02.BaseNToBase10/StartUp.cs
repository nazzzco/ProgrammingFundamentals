using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.BaseNToBase10
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long baseN = input[0];
            long number = input[1];


            Console.WriteLine(ConvertBaseNToBase10(baseN, number));
        }

        private static double ConvertBaseNToBase10(long baseN, long number)
        {
            
        }
    }
}
