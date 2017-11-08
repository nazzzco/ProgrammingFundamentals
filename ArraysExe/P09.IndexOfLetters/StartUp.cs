using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.IndexOfLetters
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] array = input.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                Console.Write($"{letter} -> ");
                Console.WriteLine((int)letter - 97);
            }
        }
    }
}
