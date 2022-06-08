using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();


            for (int i = 0; i < n; i++)
            {
                string namesInput = Console.ReadLine();

                names.Add(namesInput);
            }


            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
