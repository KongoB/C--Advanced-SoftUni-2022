using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            int[,] highestMatrix = new int[2, 2];
            int highestSum = 0;

            for (int row = 0; row < rows; row++)
            {

                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {

                    matrix[row, col] = rowData[col];

                }
            }


            for (int row = 0; row < rows - 1; row++)
            {

                

                for (int col = 0; col < cols - 1; col++)
                {
                    int currentSum = 0;

                    currentSum += matrix[row, col] + matrix[row, col + 1];
                    currentSum += matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > highestSum)
                    {
                        highestSum = currentSum;
                        highestMatrix[0, 0] = matrix[row, col];
                        highestMatrix[0, 1] = matrix[row, col + 1] ;
                        highestMatrix[1, 0] = matrix[row+1, col];
                        highestMatrix[1, 1] = matrix[row+1, col+1];

                    }
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(highestMatrix[row,col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(highestSum);
        }
    }
}
