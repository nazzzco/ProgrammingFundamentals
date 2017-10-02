using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            int count = 0;
            string plural;

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1, 1);
                Console.WriteLine("{0}ies", noun);
            }

            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") ||
                     noun.EndsWith("x") || noun.EndsWith("z"))
            {
                //noun = noun.Remove(noun.Length - 2, 2);
                Console.WriteLine("{0}es", noun);
            }

            else
            {
                Console.WriteLine("{0}s", noun);
            }
        }
    }
}
