﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIngr = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 1; i <= numberIngr; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    calories += 500;
                }

                else if (ingredient == "tomato sauce")
                {
                    calories += 150;
                }

                else if (ingredient == "salami")
                {
                    calories += 600;
                }

                else if (ingredient == "pepper")
                {
                    calories += 50;
                }

                
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
