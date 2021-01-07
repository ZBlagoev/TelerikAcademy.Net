using System;
using System.Linq;

namespace Matrix_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            // number of rows
            int n = int.Parse(Console.ReadLine());

            // variables for sums
            int sum = 0;
            int maxSum = int.MinValue;

            // create and fill jagged
            int[][] jagged = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] arrStrings = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jagged[i] = arrStrings;
            }

            // number of columns
            int m = jagged[0].Length;

            // create and fill matrix
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = jagged[i][j];
                }
            }

            // check if matrix is ok
            //PrintSqrMatrix(matrix);

            int[] pairs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int first = 0;
            int second = 1;

            while (second <= pairs.Length)
            {
                sum = 0;
                
                int r = pairs[first];
                int c = pairs[second];

                int startX;
                int startY;
                int endX;
                int endY;
                int goalX = Math.Abs(r) - 1;
                int goalY = Math.Abs(c) - 1;

                if (r > 0)
                {
                    startY = 0;
                    endY = Math.Abs(c) - 1;
                }
                else
                {
                    startY = Math.Abs(c) - 1;
                    endY = m - 1;
                }

                if (c > 0)
                {
                    startX = 0;
                    endX = Math.Abs(r) - 1;
                }
                else
                {
                    startX = Math.Abs(r) - 1;
                    endX = n - 1;
                }


                for (int i = startX; i <= endX; i++)
                {
                    for (int j = startY; j <= endY; j++)
                    {
                        if ((i == goalX) || (j == goalY))
                        {
                            //int temp = matrix[i, j];
                            sum += matrix[i, j];
                        }
                    }
                }

                first += 2;
                second += 2;

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            // print result
            Console.WriteLine(maxSum);

        }

        // method for printing square matrix
        static void PrintSqrMatrix(int[,] input)
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
