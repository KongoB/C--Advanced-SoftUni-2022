using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<string, double> parser = x => double.Parse(x);

            double[] prices = Console.ReadLine().Split(", ").Select(parser).Select(x => x + (x * 0.2)).ToArray();

            foreach (var item in prices)
            {
                Console.WriteLine($"{item:F2}");
            }

        }

    }
}
