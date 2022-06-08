using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            input.OrderBy(x => x);

            int[] even = input.Where(x => x % 2 == 0).ToArray();
            int[] odd = input.Where(x => x % 2 != 0).ToArray();

            Console.Write(String.Join(' ', even) + " " + String.Join(' ', odd));


        }
    }
}
