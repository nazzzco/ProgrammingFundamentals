using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.SignOfIntegerNumber
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        static void PrintSign(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("The number {0} is zero.", number);
            }

            else if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }

            else
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
        }
    }
}
