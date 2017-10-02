using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 2 ; i<= range; i++)
{
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
{
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {isPrime}");
                //if (i == 0 || i == 1)
                //{
                //    Console.WriteLine($"{i + 2} -> {isPrime}");
                //}
                //else
                //{
                //    Console.WriteLine($"{i} -> {isPrime}");
                //}
            }
        }
    }
}
