using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.CompareCharArrays
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string abc = "a b c";
            char[] arr = abc.ToCharArray().;
            //string[] firstArr = Console.ReadLine()
            //     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] secondArr = Console.ReadLine()
            //     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (char ch in arr)
            {
                Console.WriteLine(ch);
            }

        }
    }
}
