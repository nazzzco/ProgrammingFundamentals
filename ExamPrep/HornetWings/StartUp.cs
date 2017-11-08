using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HornetWings
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        int P = int.Parse(Console.ReadLine());

        double metersTravelled = (N / 1000) * M;
        double flapsSeconds = N / 100;
        double restSeconds = (N / P) * 5;
        var secondsPassed = flapsSeconds + restSeconds;

        Console.WriteLine($"{metersTravelled:F2} m.");
        Console.WriteLine($"{secondsPassed} s.");
    }
}

