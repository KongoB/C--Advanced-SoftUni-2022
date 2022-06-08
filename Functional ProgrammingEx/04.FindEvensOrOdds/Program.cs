using System;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> evenNumbers = x => x % 2 == 0;

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string evenOdd = Console.ReadLine();

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (evenNumbers(i) && evenOdd == "even")
                {
                    Console.Write(i + " ");
                }
                else if (!evenNumbers(i) && evenOdd == "odd")
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
