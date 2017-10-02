using System;

namespace ConditionalStatementsLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes > 59)
            {
                hours++;
                minutes = minutes - 60;
                if (hours == 24)
                {
                    hours = 0;
                }

            }

            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
