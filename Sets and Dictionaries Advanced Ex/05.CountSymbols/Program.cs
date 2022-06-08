using System;
using System.Collections.Generic;


namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<char,int> sentence = new SortedDictionary<char,int>();



            string input = Console.ReadLine();


            for (int i = 0; i < input.Length; i++)
            {

                if (!sentence.ContainsKey(input[i]))
                {
                    sentence.Add(input[i], 0);
                }

                sentence[input[i]]++;

            }

            foreach (var item in sentence)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
