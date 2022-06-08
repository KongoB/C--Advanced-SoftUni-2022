using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            HashSet<string> carPlates = new HashSet<string>();


            while (input[0] != "END")
            {


                if (input[0] == "IN")
                {
                    if (!carPlates.Contains(input[1]))
                    {
                        carPlates.Add(input[1]);
                    }
                }

                if (input[0] == "OUT")
                {
                    if (carPlates.Contains(input[1]))
                    {
                        carPlates.Remove(input[1]);
                    }
                }
                

                input = Console.ReadLine().Split(", ");
            }

            Console.WriteLine(String.Join(Environment.NewLine, carPlates));

        }
    }
}
