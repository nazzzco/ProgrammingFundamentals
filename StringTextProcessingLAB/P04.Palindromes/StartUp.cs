using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Palindromes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var words = new List<string>();
            foreach (var word in text)
            {
                if (IsPalindrome(word))
                {
                    words.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", words.Distinct().OrderBy(w => w)));
        }

        private static bool IsPalindrome(string str)
        {
            var reversed = new string(str.Reverse().ToArray());
            return str == reversed;
        }
    }
}
