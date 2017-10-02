using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringsAndObjects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";

            object obj = first + " " + second;

            string output = (string)obj;
            Console.WriteLine(output);
        }
    }
}
