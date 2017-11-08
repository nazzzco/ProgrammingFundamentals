using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.MaxSequenceSecondVariant
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> values = input.Split(' ').ToList();
            List<int> numbers = new List<int>();
            for (int i = 0; i < values.Count; i++)
            {
                numbers.Add(int.Parse(values[i]));
            }

            //var numbers = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();

            int count = 1;
            int number = 0;
            int maxCount = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            if (maxCount == 1)
            {
                Console.WriteLine($"{numbers[0]}");
            }
            else
            {
                for (int k = 0; k < maxCount; k++)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
