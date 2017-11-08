using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.ShortWordsSorted
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(new Char[] { ' ', '\n', '.', ',', ';', ':', '(', ')', '[', ']', '\"', '\'', '/', '\\', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct();

            //var dict = new Dictionary<string, int>();
            //foreach (var word in input)
            //{
            //    dict[word] = word.Length;
            //    if (word.Length < 5)
            //    {

            //    }
            //}

            Console.WriteLine(string.Join(", ", input));



        }
    }
}
