using System;
//using System.Numerics;

namespace Above_the_main_diag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            AboveMainDiag(MakeSqrMatrix(n));

            //PrintSqrMatrix(MakeSqrMatrix(n));

        }

        // method for printing the sum of nums above the main diag
        static void AboveMainDiag(ulong[,] matrix)
        {
            ulong sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(sum);
        }


        // method for making square matrix
        static ulong[,] MakeSqrMatrix(int n)
        {
            ulong[,] matrix = new ulong[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (ulong)Math.Pow(2, (i + j));
                }
            }

            return matrix;
        }

        // method for printing square matrix
        static void PrintSqrMatrix(ulong[,] input)
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

