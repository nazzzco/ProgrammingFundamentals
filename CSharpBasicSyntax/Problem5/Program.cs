using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);

            Console.Write("Health: ");
            Console.Write('|');

            Console.Write(new string('|', health));
            Console.Write(new string('.', maxHealth - health));

            Console.WriteLine('|');

            Console.Write("Energy: ");
            Console.Write('|');

            Console.Write(new string('|', energy));
            Console.Write(new string('.', maxEnergy - energy));

            Console.WriteLine('|');


        }
    }
}
