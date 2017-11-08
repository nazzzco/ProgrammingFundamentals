using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            CenterPoint(X1, Y1, X2, Y2);
        }

        public static void CenterPoint(double x1, double y1, double x2, double y2)
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
