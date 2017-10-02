using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                string input = Console.ReadLine()
;               if (input != "Bake!")
                {
                    Console.WriteLine("Adding ingredient {0}.", input);
                }
                else
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", i);
                    break;
                }
            }
        }
    }
}
