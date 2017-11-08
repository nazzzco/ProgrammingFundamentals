using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double energyContent = (energy / 100.0) * volume;
            double sugarContent = (sugar / 100.0) * volume;

            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, energyContent, sugarContent);
        }
    }
}
