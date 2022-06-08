using System;
using System.Linq;

namespace _06.Jagged_ArrayModif
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {

                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] inputCommand = Console.ReadLine().Split();

            while (inputCommand[0] != "END")
            {

                int changeRow = int.Parse(inputCommand[1]);
                int changeCol = int.Parse(inputCommand[2]);
                int changeBy = int.Parse(inputCommand[3]);

                if (inputCommand[0] == "Add")
                {

                    if (changeRow >= 0 && changeRow < matrix.GetLength(0) && changeCol >= 0 && changeCol < matrix.GetLength(1))
                    {
                        matrix[changeRow, changeCol] += changeBy;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                else if (inputCommand[0] == "Subtract")
                {

                    if (changeRow >= 0 && changeRow < matrix.GetLength(0) && changeCol >= 0 && changeCol < matrix.GetLength(1))
                    {
                        matrix[changeRow, changeCol] -= changeBy;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }

                
                inputCommand = Console.ReadLine().Split();

            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
