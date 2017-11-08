using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            List<string> items = values.Split(' ').ToList();
            List<int> nums = new List<int>();
            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }

            List<int> result = new List<int>();

            foreach (var num in nums)
            {
                if (num > 0)
                {
                    result.Add(num);
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("empty list");
            }

            else
            {
                result.Reverse();
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
