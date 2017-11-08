using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FF = long.Parse(Console.ReadLine());
            long UT = long.Parse(Console.ReadLine());

            double FP = Math.Ceiling((double)N * (double)(FF / 100.0));
            long firstTime = N * FT;
            long secondTime = (long)FP * UT;
            long totalTime = firstTime + secondTime;
            Console.WriteLine(ConvertSecondsToDate(totalTime.ToString()));
        }

        public static string ConvertSecondsToDate(string seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(Convert.ToDouble(seconds));

            //if (t.Days > 0)
                return t.ToString(@"d\:hh\:mm\:ss");
            //return t.ToString(@"hh\:mm\:ss");

        }
    }
}
