using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = n[0];
            int cols = n[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {

                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "END")
            {

                if (commands[0] != "swap" || commands.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }


                int first = int.Parse(commands[1]);
                int second = int.Parse(commands[2]);
                int third = int.Parse(commands[3]);
                int forth = int.Parse(commands[4]);

                bool isValidOne = first >= 0 && first < rows && second >= 0 && second < cols;
                bool isValidTwo = third >= 0 && third < rows && forth >= 0 && forth < cols;


                if (isValidOne && isValidTwo)
                {

                    string temp = matrix[first,second];

                    matrix[first, second] = matrix[third, forth];
                    matrix[third, forth] = temp;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                isValidOne = false;
                isValidTwo = false;

                commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }


        }
    }
}
