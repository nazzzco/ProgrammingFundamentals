using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.ReverseStringUsingStringBuilder
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed.Append(text[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
