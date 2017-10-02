using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                try
                { 
                var integer = int.Parse(Console.ReadLine());
                count++;
                }

                catch (Exception)
                {
                    Console.WriteLine(count);
                    break;                   
                }
            }
        }
    }
}
