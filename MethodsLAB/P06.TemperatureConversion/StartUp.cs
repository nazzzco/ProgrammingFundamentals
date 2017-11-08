using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.TemperatureConversion
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double temperatureF = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(temperatureF);
            Console.WriteLine($"{celsius:F2}");
        }

        static double FahrenheitToCelsius(double temperatureF)
        {
            double result = (temperatureF - 32) * 5 / 9;
            return result;
        }
    }
}
