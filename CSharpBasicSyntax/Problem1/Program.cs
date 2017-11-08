using System;

namespace CSharpBasicSyntax
{
    class Problem1
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            string output = String.Format("{0:D4} {1:D4} {2:D4} {3:D4}", a, b, c, d);
            Console.WriteLine(output);
        }
    }
}
