using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04VariableInHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string numHex = Console.ReadLine();

            int numDecimal = Convert.ToInt32(numHex, 16);
            Console.WriteLine(numDecimal);
        }
    }
}
