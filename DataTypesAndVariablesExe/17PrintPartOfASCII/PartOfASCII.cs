using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17PrintPartOfASCII
{
    class PartOfASCII
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.Write("{0} ",(char)i);
            }
            Console.WriteLine();
        }
    }
}
