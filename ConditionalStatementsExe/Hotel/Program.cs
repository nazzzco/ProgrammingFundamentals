using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double doubleroom = 0;
            double suite = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                doubleroom = 65;
                suite = 75;

                if (nights > 7 && month == "May")
                {
                    studio = studio * nights * 0.95;
                    doubleroom = doubleroom * nights;
                    suite = suite * nights;
                }

                else if (nights <= 7)
                {
                    studio *= nights;
                    doubleroom *= nights;
                    suite *= nights;
                }
            }

            else if (month == "June" || month == "September")
            {
                studio = 60;
                doubleroom = 72;
                suite = 82;

                if (nights > 14)
                {
                    studio = studio * nights;
                    doubleroom = doubleroom * nights * 0.9;
                    suite = suite * nights;
                }
                else if (nights <= 14)
                {
                    studio = studio * nights;
                    doubleroom = doubleroom * nights;
                    suite = suite * nights;
                }
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                doubleroom = 77;
                suite = 89;

                if (nights > 14)
                {
                    studio = studio * nights;
                    doubleroom = doubleroom * nights;
                    suite = suite * nights * 0.85;
                }
                else
                {
                    studio = studio * nights;
                    doubleroom = doubleroom * nights;
                    suite = suite * nights;
                }
            }

            Console.WriteLine("Studio: {0:0.00} lv.", studio);
            Console.WriteLine("Double: {0:0.00} lv.", doubleroom);
            Console.WriteLine("Suite: {0:0.00} lv.", suite);
        }
    }
}
