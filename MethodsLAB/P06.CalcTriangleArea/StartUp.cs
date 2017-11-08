using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.CalcTriangleArea
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double baseSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateArea(baseSide, height);
            Console.WriteLine(area);
        }

        static double CalculateArea(double baseSide, double height)
        {
            double result = baseSide * height / 2;
            return result;
        }
    }
}
