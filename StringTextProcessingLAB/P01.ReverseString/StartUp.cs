using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTextProcessingLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(String.Join("", input.Reverse()));
        }
    }
}
