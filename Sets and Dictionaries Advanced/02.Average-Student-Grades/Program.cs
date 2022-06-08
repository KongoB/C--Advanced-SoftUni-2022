using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            if (grades.ContainsKey(input[0]))
            {
                grades[input[0]].Add(decimal.Parse(input[1]));
            }
            else
            {
                grades.Add(input[0], new List<decimal>());
                grades[input[0]].Add(decimal.Parse(input[1]));
            }

        }

        foreach (var key in grades)
        {
            Console.WriteLine(key.Key + " -> " + String.Join(" ", key.Value.Select(x => x.ToString("F2"))) + " (avg: " + $"{key.Value.Average():F2}" + ")");
        }



    }
}