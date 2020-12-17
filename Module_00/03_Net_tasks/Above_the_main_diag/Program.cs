using System;

namespace Above_the_main_diag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //AboveMainDiag(MakeMatrix(n));

            PrintSqrMatrix(MakeSqrMatrix(n));
            
        }

        static void AboveMainDiag(long[,] matrix)
        {
            long sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    sum += (long)matrix[i, j];
                }
            }

            Console.WriteLine(sum);
        }


        // method for making square matrix
        static long[,] MakeSqrMatrix(int n)
        {
            long[,] matrix = new long[n, n];

            for (int i = 0; i < n; i++)
            {
                int x = i;
                
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (int)Math.Pow(2, x);

                    x++;
                }
            }

            return matrix;
        }

        // method for printing square matrix
        static void PrintSqrMatrix(long[,] input)
        {          
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(0); j++)
                {
                    Console.Write($"{MakeSqrMatrix(input.GetLength(0))[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
