using System;

namespace P11.GeometryCalc
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            AreaMethod(figureType);

        }

        static void AreaMethod(string figure)
        {
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (side * height) / 2.0;
                Console.WriteLine($"{area:F2}");
            }

            else if (figure == "rectangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = side * height;
                Console.WriteLine($"{area:F2}");
            }

            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:F2}");
            }

            else if (figure == "circle")
            {
                double side = double.Parse(Console.ReadLine());
                double area = Math.PI * side * side;
                Console.WriteLine($"{area:F2}");
            }
        }
    }
}
