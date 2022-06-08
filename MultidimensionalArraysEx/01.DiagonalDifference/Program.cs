using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sumDiagonal1 = 0;
            int sumDiagonal2 = 0;

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < n; row++)
            {
                sumDiagonal1 += matrix[row, row];
            }

            for (int row = 0; row < n; row++)
            {
                sumDiagonal2 += matrix[row,matrix.GetLength(0)-row-1];
            }

            if (sumDiagonal1 > sumDiagonal2)
            {
                sumDiagonal1 -= sumDiagonal2;
                Console.WriteLine(sumDiagonal1);
            }
            else
            {
                sumDiagonal2 -= sumDiagonal1;
                Console.WriteLine(sumDiagonal2);

            }


        }
    }
}
