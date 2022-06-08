using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = n[0];
            int cols = n[1];

            char[,] snakePath = new char[rows, cols];

            int tracker = 0;

            string snake = Console.ReadLine();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {

                    snakePath[row, col] = snake[tracker];
                    tracker++;
                    if (tracker == snake.Length)
                    {
                        tracker = 0;
                    }

                }
            }

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 != 0)
                {
                    for (int col = 0; col < cols / 2; col++)
                    {
                        char temp = snakePath[row, col];
                        snakePath[row, col] = snakePath[row, cols - col - 1];
                        snakePath[row, cols - col - 1] = temp;

                    }
                }

            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(snakePath[row,col]);
                }
                Console.WriteLine();
            }

        }
    }
}
