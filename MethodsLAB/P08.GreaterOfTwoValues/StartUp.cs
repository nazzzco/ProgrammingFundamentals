using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.GreaterOfTwoValues
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                int max = GetMax(firstValue, secondValue);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char bigger = GetMax(firstChar, secondChar);
                Console.WriteLine(bigger);
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string longer = GetMax(firstString, secondString);
                Console.WriteLine(longer);
            }
        }

        static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static int GetMax(int firstValue, int secondValue)
        {
            int max = Math.Max(firstValue, secondValue);
            return max;
        }
    }
}
