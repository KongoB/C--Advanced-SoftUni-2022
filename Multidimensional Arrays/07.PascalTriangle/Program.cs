using System;
using System.Numerics;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[][] matrix = new BigInteger[n][];


            for (int i = 0; i < n; i++)
            {

                matrix[i] = new BigInteger[i+1];

            }


            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = 1;

                    if (row > 1)
                    {
                        if (col >= 1 && col < matrix[row].Length - 1)
                        {
                            matrix[row][col] = matrix[row - 1][col] + matrix[row - 1][col - 1];
                        }
                    }
                }


            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }


        }
    }
}
