using System;

namespace ConditionalStatementsExe
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double waterPrice = 0.70;
            double coffeePrice = 1.00;
            double beer = 1.70;
            double tea = 1.20;
            double price;

            if (input == "Athlete")
            {
                price = quantity * waterPrice;
                Console.WriteLine("The Athlete has to pay {0:0.00}.", price);
            }

            else if (input == "SoftUni Student")
            {
                price = quantity * beer;
                Console.WriteLine("The SoftUni Student has to pay {0:0.00}.", price);
            }

            else if (input == "Businessman" || input == "Businesswoman")
            {
                price = quantity * coffeePrice;
                Console.WriteLine("The {0} has to pay {1:0.00}.", input, price);
            }

            else
            {
                price = quantity * tea;
                Console.WriteLine("The {0} has to pay {1:0.00}.", input, price);
            }
        }
    }
}
