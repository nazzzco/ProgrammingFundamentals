using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrders
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < N; i++)
            {
                decimal price = CalculatePrice();
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        static decimal CalculatePrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", null);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());

            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${price:F2}");
            return price;
        }
    }
}
