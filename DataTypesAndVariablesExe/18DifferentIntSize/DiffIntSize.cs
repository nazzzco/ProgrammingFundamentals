using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DifferentIntSize
{
    class DiffIntSize
    {
        static void Main(string[] args)
        {
            decimal N = decimal.Parse(Console.ReadLine());

            if (N < long.MinValue || N > long.MaxValue)
            {
                Console.WriteLine($"{N} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{N} can fit in:");
                if (N >= sbyte.MinValue && N <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (N >= byte.MinValue && N <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (N >= short.MinValue && N <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (N >= ushort.MinValue && N <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (N >= int.MinValue && N <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (N >= uint.MinValue && N <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (N >= long.MinValue && N <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
                //if (N >= ulong.MinValue && N <= ulong.MaxValue)
                //{
                //    Console.WriteLine("* ulong");
                //}
            }
                 
        }
    }
}
