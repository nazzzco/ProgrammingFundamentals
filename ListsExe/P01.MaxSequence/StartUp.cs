using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExe
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

            List<int> longestSequence = new List<int>();
            List<int> temp = new List<int>();

            int count = 0;
            int counter = 0;

            // check the count - 1
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                int nextElement = j + 1;
                count = 0;
                temp.Clear();
                temp.Add(numbers[j]);

                while (numbers[j] == numbers[nextElement])
                {
                    temp.Add(numbers[nextElement]);
                    nextElement++;
                    count++;
                }

                if (count > counter)
                {
                    longestSequence.Clear();
                    counter = count;
                    for (int k = 0; k < temp.Count; k++)
                    {
                        longestSequence.Add(temp[k]);
                    }
                }
            }
            foreach (int element in longestSequence)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
