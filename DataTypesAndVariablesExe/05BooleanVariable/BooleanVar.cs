using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BooleanVariable
{
    class BooleanVar
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool output = Convert.ToBoolean(input);

            if (output)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
