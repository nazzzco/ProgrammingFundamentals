using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P03.CameraView
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int m = indices[0];
            int n = indices[1];
            string pattern = @"\\|\\<(.{{{m}}})(.{{{n}}})";
            Regex regex = new Regex(pattern);
            string inputLine = Console.ReadLine();
            Match match = regex.Match(inputLine);

            List<string> results = new List<string>();
            while (inputLine.Length > match.Index + 2)
            {
                results.Add(match)
                inputLine = inputLine.Substring(match.Index)
            }
            Console.WriteLine(match.Groups[2].Value);

        }
    }
}
