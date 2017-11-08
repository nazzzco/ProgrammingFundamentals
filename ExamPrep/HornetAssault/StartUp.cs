using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HornetAssault
{
    static void Main()
    {
        List<long> beehives = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        List<long> hornets = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        List<long> beesLeft = new List<long>();

        foreach (var beehive in beehives)
        {
            if (hornets.Count == 0)
            {
                beesLeft.Add(beehive);
                continue;
            }
            long hornetPower = hornets.Sum();

            if (hornetPower >= beehive)
            {
                if (hornetPower == beehive)
                {
                    hornets.RemoveAt(0);
                }
            }
            else
            {
                beesLeft.Add(beehive - hornetPower);
                hornets.RemoveAt(0);
            }
        }
        if (beesLeft.Count > 0)
        {
            Console.WriteLine(string.Join(" ", beesLeft));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));
        }
    }
}

