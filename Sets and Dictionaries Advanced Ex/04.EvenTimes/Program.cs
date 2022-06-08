using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {

                int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;

                for (int j = 0; j < number.Length; j++)
                {

                    if (!numbers.ContainsKey(number[j]))
                    {
                        numbers.Add(number[j], 0);
                    }

                    numbers[number[j]]++;

                }

            }


            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }


        }
    }
}
