using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool equal = true;
            double eps = 0.000001;

            if (Math.Abs(b - a) >= eps)
            {
                equal = false;
                Console.WriteLine(equal);
            }

            if (Math.Abs(b - a) < eps)
            {
                Console.WriteLine(equal);
            }
        }
    }
}
