using System;

namespace P03.EnglishNameOfLastDigit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long lastNum = (Math.Abs(input)) % 10;
            PrintName(lastNum);
        }

        public static void PrintName(long a)
        {
            if (a == 0)
            {
                Console.WriteLine("zero");
            }
            else if (a == 1)
            {
                Console.WriteLine("one");
            }
            else if (a == 2)
            {
                Console.WriteLine("two");
            }
            else if (a == 3)
            {
                Console.WriteLine("three");
            }
            else if (a == 4)
            {
                Console.WriteLine("four");
            }
            else if (a == 5)
            {
                Console.WriteLine("five");
            }
            else if (a == 6)
            {
                Console.WriteLine("six");
            }
            else if (a == 7)
            {
                Console.WriteLine("seven");
            }
            else if (a == 8)
            {
                Console.WriteLine("eight");
            }
            else if (a == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
