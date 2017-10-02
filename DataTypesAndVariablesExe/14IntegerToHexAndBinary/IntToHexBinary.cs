using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14IntegerToHexAndBinary
{
    class IntToHexBinary
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string hexValue = input.ToString("X");
            string binaryValue = Convert.ToString(input, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binaryValue);
        }
    }
}
