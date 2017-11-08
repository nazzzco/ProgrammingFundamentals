using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.CubeProperties
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            CubeProp(side, parameter);
        }

        public static void CubeProp(double side, string parameter)
        {
            double face = Math.Sqrt(2 * side * side);
            double space = Math.Sqrt(3 * side * side);
            double volume = side * side * side;
            double area = 6 * side * side;

            if (parameter == "face")
            {
                Console.WriteLine($"{face:F2}");
            }

            else if (parameter == "space")
            {
                Console.WriteLine($"{space:F2}");
            }

            else if (parameter == "volume")
            {
                Console.WriteLine($"{volume:F2}");
            }

            else
            {
                Console.WriteLine($"{area:F2}");
            }
        }
    }
}
