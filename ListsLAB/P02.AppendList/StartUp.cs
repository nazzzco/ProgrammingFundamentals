using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.AppendList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split('|');

            List<string> result = new List<string>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                //int[] elements =
                //    tokens[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                //    Select(int.Parse);
            }
        }
    }
}
