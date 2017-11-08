using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.DrawAFilledSquare
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintHeaderAndFooter(input);
            PrintBody(input);
            PrintHeaderAndFooter(input);
        }

        static void PrintBody(int input)
        {
            for (int j = 0; j < input - 2; j++)
            {
                Console.Write('-');
                for (int i = 1; i < input; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        static void PrintHeaderAndFooter(int input)
        {
            Console.WriteLine(new string('-', 2 * input));
        }
    }
}
