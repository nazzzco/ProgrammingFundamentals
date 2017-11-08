using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.LongerLine
{
    class StartUp
    {
        static void Main(string[] args)
        {
        }

        public static void CenterPoint(int x1, int y1, int x2, int y2)
        {
            double firstDiagonal = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondDiagonal = Math.Sqrt(x2 * x2 + y2 * y2);
            if (firstDiagonal <= secondDiagonal)
            {
                Console.WriteLine($"({x1}, {y1})");
            }

            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
