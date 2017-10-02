using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u'
                || input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U')
            {
                Console.WriteLine("vowel");
            }

            else if (input >= 48 && input <= 57)
            {
                Console.WriteLine("digit");
            }

            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
