using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }

            for (int row = 0; row < n; row++)
            {

                sum += matrix[row, row];


                //for (int col = 0; col < n; col++)
                //{
                //    sum += matrix[row, row];
                //}

            }

            Console.WriteLine(sum);

        }
    }
}
