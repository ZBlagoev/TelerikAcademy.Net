using System;
using System.Numerics;

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

        static void AboveMainDiag(BigInteger[,] matrix)
        {
            BigInteger sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(sum);
        }


        // method for making square matrix
        static BigInteger[,] MakeSqrMatrix(int n)
        {
            BigInteger[,] matrix = new BigInteger[n, n];

            for (int i = 0; i < n; i++)
            {
                int x = i;
                
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (BigInteger)Math.Pow(2, x);

                    x++;
                }
            }

            return matrix;
        }

        // method for printing square matrix
        static void PrintSqrMatrix(BigInteger[,] input)
        {          
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(0); j++)
                {
                    Console.Write($"{input[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
