using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0;
            double prePrice = 0;
            double finalPrice = 0;
            double packagePrice = 0;
            double pricePerPerson = 0;

            if (groupSize > 0 && groupSize <= 50)
            {
                if (package == "Normal")
                {
                    price = 2500;
                    packagePrice = 500;
                    prePrice = (price + packagePrice);
                    finalPrice = prePrice - (prePrice * 0.05);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall\nThe price per person is {0:0.00}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    price = 2500;
                    packagePrice = 750;
                    prePrice = price + packagePrice;
                    finalPrice = prePrice - (prePrice * 0.1);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall\nThe price per person is {0:0.00}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    price = 2500;
                    packagePrice = 1000;
                    prePrice = price + packagePrice;
                    finalPrice = prePrice - (prePrice * 0.15);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Small Hall\nThe price per person is {0:0.00}$", pricePerPerson);
                }
            }

            else if (groupSize > 50 && groupSize <= 100)
            {
                if (package == "Normal")
                {
                    price = 5000;
                    packagePrice = 500;
                    prePrice = (price + packagePrice);
                    finalPrice = prePrice - (prePrice * 0.05);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace\nThe price per person is {0:0.00}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    price = 5000;
                    packagePrice = 750;
                    prePrice = price + packagePrice;
                    finalPrice = prePrice - (prePrice * 0.1);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace\nThe price per person is {0:0.00}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    price = 5000;
                    packagePrice = 1000;
                    prePrice = price + packagePrice;
                    finalPrice = prePrice - (prePrice * 0.15);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Terrace\nThe price per person is {0:0.00}$", pricePerPerson);
                }
            }

            else if (groupSize > 100 && groupSize <= 120)
            {
                if (package == "Normal")
                {
                    price = 7500;
                    packagePrice = 500;
                    prePrice = (price + packagePrice);
                    finalPrice = prePrice - (prePrice * 0.05);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Great Hall\nThe price per person is {0:0.00}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    price = 7500;
                    packagePrice = 750;
                    prePrice = price + packagePrice;
                    finalPrice = prePrice - (prePrice * 0.1);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Great Hall\nThe price per person is {0:0.00}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    price = 7500;
                    packagePrice = 1000;
                    prePrice = price + packagePrice;
                    finalPrice = prePrice - (prePrice * 0.15);
                    pricePerPerson = finalPrice / groupSize;
                    Console.WriteLine("We can offer you the Great Hall\nThe price per person is {0:0.00}$", pricePerPerson);
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
