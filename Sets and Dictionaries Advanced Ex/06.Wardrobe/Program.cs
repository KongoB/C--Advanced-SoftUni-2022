using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string[] dresses = input[1].Split(',',StringSplitOptions.RemoveEmptyEntries);


                if (!wardrobe.ContainsKey(input[0]))
                {
                    wardrobe.Add(input[0], new Dictionary<string, int>());
                }

                for (int j = 0; j < dresses.Length; j++)
                {

                    if (!wardrobe[input[0]].ContainsKey(dresses[j]))
                    {

                        wardrobe[input[0]].Add(dresses[j], 0);


                    }
                    wardrobe[input[0]][dresses[j]]++;
                }
            }

            string[] lookFor = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);



            foreach (var color in wardrobe)
            {

                Console.WriteLine(color.Key + " clothes:");

                foreach (var dress in color.Value)
                {

                    if (color.Key == lookFor[0] && dress.Key == lookFor[1])
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }

                }

            }

        }
    }
}
