using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class PopulationAggregation
{
    static void Main()
    {
        string command = Console.ReadLine();
        while (command != "stop")
        {
            string[] commandArgs = command.Split('\\');

            command = Console.ReadLine();

            string country;
            string city;

            if (char.IsUpper(commandArgs[0][0]))
            {
                country = commandArgs[0];
                city = commandArgs[1];
            }

            else
            {
                country = commandArgs[1];
                city = commandArgs[0];
            }



            country = country.Replace("@", string.Empty);
            country = country.Replace("#", string.Empty);
            country = country.Replace("$", string.Empty);
            country = country.Replace("&", string.Empty);
            country = Regex.Replace(country, @"[\d-]", string.Empty);
            city = city.Replace("@", string.Empty);
            city = city.Replace("#", string.Empty);
            city = city.Replace("$", string.Empty);
            city = city.Replace("&", string.Empty);
            city = Regex.Replace(city, @"[\d-]", string.Empty);

            SortedDictionary<string, int> citiesCountByCountry = new SortedDictionary<string, int>();
            Dictionary<string, long> populationByCity = new Dictionary<string, long>();

            //AddOrUpdate(citiesCountByCountry, country, 0);
            if (!citiesCountByCountry.ContainsKey(country))
            {
                citiesCountByCountry[country] = 0;
            }
            citiesCountByCountry[country]++;
            populationByCity[city] = long.Parse(commandArgs[2]);



            foreach (var c in citiesCountByCountry)
            {
                Console.WriteLine(String.Join(" -> ", citiesCountByCountry.Keys.OrderBy(x => x)));
                Console.WriteLine(String.Join(" ",citiesCountByCountry.Values));
            }

            var top3Cities = populationByCity.OrderByDescending(x => x.Value).Take(3);

            foreach (var citi in top3Cities)
            {
                Console.WriteLine(citi);
            }
        }
    }

    static void AddOrUpdate(SortedDictionary<string, int> CitiesCountByCountry, string key, int value)
    {
        if (!CitiesCountByCountry.ContainsKey(key))
        {
            CitiesCountByCountry[key] = value;
        }
        else
        {
            CitiesCountByCountry.Add(key, value);
        }
    }
}

