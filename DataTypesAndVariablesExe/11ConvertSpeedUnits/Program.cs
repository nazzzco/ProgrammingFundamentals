using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            float metersPerSecond = meters / totalSeconds;
            float kiloPerHour = (float)(metersPerSecond * 3.6);
            float milesPerHour = (float)((metersPerSecond * 3.6) * 0.6215040236378688);

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kiloPerHour);
            Console.WriteLine(milesPerHour);


        }
    }
}
