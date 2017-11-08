using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.PrimesInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            var result = FindPrimes(firstNum, secondNum);
            Console.WriteLine(String.Join(", ", result));
        }

        static List<int> FindPrimes(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
            }

            int str;

            for (int i = startNum; i <= endNum; i++)
            {

                str = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        str++;
                        break;
                    }
                }
                if (str == 0 && i != 1)
                {
                    if (i != 0)
                    {
                        primes.Add(i);
                    }
                }
            }
            return primes;
        }
    }
}
