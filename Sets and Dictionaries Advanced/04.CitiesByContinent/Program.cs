using System;
using System.Collections.Generic;

namespace _04.CitiesByContinent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> countries = new Dictionary<string, Dictionary<string, List<string>>>();



            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!countries.ContainsKey(continent))
                {
                    countries.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!countries[continent].ContainsKey(country))
                {
                    countries[continent].Add(country, new List<string>());
                }

                //if (!countries[continent][country].Contains(city))
                //{
                countries[continent][country].Add(city);
                //}

            }

            foreach (var continent in countries)
            {
                Console.WriteLine(continent.Key + ":");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine(country.Key+ " -> " + String.Join(", ", country.Value));
                }

            }


        }
    }
}
