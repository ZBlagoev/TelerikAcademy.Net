using System;
using System.Linq;

namespace Zig_Zag
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dims = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = MakeMatrix(dims[0], dims[1]);

            PrintMatrix(matrix);
        }


        // method for making the matrix
        static int[,] MakeMatrix(int n, int m)
        {
            // making the matrix
            int[,] matrix = new int[n, m];

            for (int i = n - 1; i >= 0; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = (int)Math.Pow(2, (i + j));
                }
            }

            return matrix;
        }

        // method for printing matrix
        static void PrintMatrix(int[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
