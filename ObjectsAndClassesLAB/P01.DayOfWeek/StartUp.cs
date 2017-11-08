using System;
using System.Globalization;

namespace ObjectsAndClassesLAB
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            DateTime myDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(myDate.DayOfWeek);
        }
    }
}
