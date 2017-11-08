using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.OddOccurrences
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var words = input.Split(' ');
            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }

            var result = new List<string>();
            foreach (var pair in dict)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
