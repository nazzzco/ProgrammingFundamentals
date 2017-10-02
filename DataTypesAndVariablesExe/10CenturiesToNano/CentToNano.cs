using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CenturiesToNano
{
    class CentToNano
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int years = 100 * input;
            int days = (int)(years * 365.2422);
            uint hours = (uint)days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = " +
                $"{minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds " +
                $"= {nanoseconds} nanoseconds");
        }
    }
}
