using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        public static bool IsPrime(long num)
        {
            if (num <= 1)
            {
                return false;
            }

            else if (num % 2 == 0)
            {
                return false;
            }

            double N = Math.Sqrt(num) + 0.5;

            for (int i = 3; i <= N; i += 2)
                if (num % i == 0)
                    return false;

            return true;
        }
    }
}
