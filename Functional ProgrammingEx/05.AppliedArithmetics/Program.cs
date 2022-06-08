using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {

                switch (command)
                {
                    case "add": input = input.Select(x => x + 1).ToArray();
                        break;
                    case "multiply": input = input.Select(x => x * 2).ToArray();
                        break;
                    case "subtract": input = input.Select(x => x - 1).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(String.Join(" ", input));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

        }
    }
}
