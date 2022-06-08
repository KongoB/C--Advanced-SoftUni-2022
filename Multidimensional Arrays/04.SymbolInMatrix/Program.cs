using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {

                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }

            }

            char search = char.Parse(Console.ReadLine());
            bool contains = false;
            
            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    if (search == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        contains = true;
                        break;
                    }

                }
                if (contains == true)
                {
                    break;
                }

            }

            if (!contains)
            {
                Console.WriteLine(search + " does not occur in the matrix");
            }



        }
    }
}
