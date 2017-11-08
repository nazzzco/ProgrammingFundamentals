using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.EnglishNameOfLastDigit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ReverseNumber(input);
        }

        private static void ReverseNumber(string a)
        {
            string output = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                output += a[i];
            }
            Console.WriteLine(output);
        }
    }
}
