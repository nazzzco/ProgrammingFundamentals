using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if (end > start)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine(i);
                }
            }

            else
            {
                for (int i = end; i <= start; i++)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
