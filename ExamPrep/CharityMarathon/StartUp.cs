using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CharityMarathon
{
    static void Main()
    {
        long days = long.Parse(Console.ReadLine());
        long runners = long.Parse(Console.ReadLine());
        long averageLaps = long.Parse(Console.ReadLine());
        long trackLenght = long.Parse(Console.ReadLine());
        long capacity = long.Parse(Console.ReadLine());
        double moneyPerKm = double.Parse(Console.ReadLine());

        long maxRunnersCount = capacity * days;
        long maxRunners = Math.Min(runners, maxRunnersCount);

        double totalKilometers = (maxRunners * averageLaps * trackLenght) / 1000.0;
        double moneyRaised = totalKilometers * moneyPerKm;
        Console.WriteLine($"Money raised: {moneyRaised:F2}");
    }
}

