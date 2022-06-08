using System;
using System.Linq;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string> namePrinter = x => Console.WriteLine("Sir " + x);

            string[] input = Console.ReadLine().Split();
            
            foreach (var item in input)
            {
                namePrinter(item);
            }

        }

    }
}
