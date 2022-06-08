using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] rowsCols = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = rowsCols[0];
            int cols = rowsCols[1];

            string[,] matrix = new string[rows, cols];
            int squareCounter = 0;

            for (int row = 0; row < rows; row++)
            {

                string[] matrixData = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = matrixData[col];
                }
            }

            bool same = true;

            for (int row = 0; row < rows-1; row++)
            {

                for (int col = 0; col < cols-1; col++)
                {

                    for (int i = 0; i < 2; i++)
                    {

                        for (int j = 0; j < 2; j++)
                        {
                            if (matrix[row,col] != matrix[row + i, col + j])
                            {
                                same = false;
                            }
                        }

                    }
                    if (same)
                    {
                        squareCounter++;
                    }
                    same = true;
                }
            }


            Console.WriteLine(squareCounter);


        }
    }
}
