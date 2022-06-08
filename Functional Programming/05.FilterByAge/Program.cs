using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> names = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(", ");


                if (!names.ContainsKey(input[0]))
                {
                    names.Add(input[0], int.Parse(input[1]));
                }

            }

        }


        static void PrintNamesOnly (Dictionary<string, int> names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item.Key);
            }
        }

        static void PrintAgesOnly(Dictionary<string, int> names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item.Value);
            }
        }

        static void PrintNameAndAge(Dictionary<string, int> names)
        {
            foreach (var item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }


    }
}
