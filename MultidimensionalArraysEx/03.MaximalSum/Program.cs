using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rowsCols[0];
            int cols = rowsCols[1];

            int[,] matrix = new int[rows, cols];
            int topHighest = 0;
            int[] highestStartingCoordinates = new int[2];
            int currentSum = 0;


            for (int row = 0; row < rows; row++)
            {

                int[] matrixData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = matrixData[col];
                }
            }


            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int  j = 0;  j < 3;  j++)
                        {
                            currentSum += matrix[row+i, col+j];
                        }
                    }

                    if (currentSum > topHighest)
                    {
                        topHighest = currentSum;
                        highestStartingCoordinates[0] = row;
                        highestStartingCoordinates[1] = col;
                    }

                    currentSum = 0;
                }
            }

            Console.WriteLine("Sum = " + topHighest );

            for (int row = highestStartingCoordinates[0]; row < highestStartingCoordinates[0] + 3; row++)
            {
                for (int col = highestStartingCoordinates[1]; col < highestStartingCoordinates[1] + 3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

    }

}
