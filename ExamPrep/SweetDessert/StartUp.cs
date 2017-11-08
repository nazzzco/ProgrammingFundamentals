using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SweetDessert
{
    static void Main()
    {
        double cash = double.Parse(Console.ReadLine());
        long guests = long.Parse(Console.ReadLine());
        double bananaPrice = double.Parse(Console.ReadLine());
        double eggsPrice = double.Parse(Console.ReadLine());
        double berriesPrice = double.Parse(Console.ReadLine());

        double setsNums = guests / 6.0;
        if (setsNums % 1 > 0)
        {
            setsNums += 1;
        }
        int setsNum = (int)(setsNums);

        double moneyNeeded = setsNum * (2 * bananaPrice) + setsNum * (4 * eggsPrice) + setsNum * (0.2 * berriesPrice);

        if (moneyNeeded > cash)
        {
            double neededMoney = moneyNeeded - cash;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
        }

        else if (moneyNeeded <= cash)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");
        }
    }
}

