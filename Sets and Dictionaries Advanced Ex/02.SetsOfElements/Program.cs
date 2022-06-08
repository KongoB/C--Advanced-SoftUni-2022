using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();


            for (int i = 0; i < n; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in first)
            {
                foreach (var itemus in second)
                {
                    if (itemus == item)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
        }
    }
}
