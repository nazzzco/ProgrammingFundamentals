using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            string areaToString = String.Format("{0:0.00}", area);
            Console.WriteLine(areaToString);
        }
    }
}
