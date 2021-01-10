using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace Navigation
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            _ = int.Parse(Console.ReadLine());

            int[] code = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BigInteger sum = 1;

            int[] startingPosition = {R - 1, 0};

            List<int[]> passedCells = new List<int[]>();
            passedCells.Add(new int[2] { R - 1, 0 });

            //int[][] passedCells = MakeJagged(R, C);
            BigInteger[,] matrix = MakeMatrix(R, C);

            int[][] targets = CodeBreaking(code, R, C);

            // calculation
            for (int i = 0; i < code.Length; i++)
            {
                int[] target = (int[])targets[i].Clone();

                var (Y, sumH) = MoveHorisontally(startingPosition, target, passedCells, matrix);
                startingPosition[1] = Y;
                var (X, sumY) = MoveVertically(startingPosition, target, passedCells, matrix);
                startingPosition[0] = X;

                sum += sumH;
                sum += sumY;
            }

            // result
            Console.WriteLine(sum);

            //PrintMatrix(matrix);
        }

        // method for summing cell values
        static BigInteger Sum(int[] coordinates, List<int[]> passedCells, BigInteger[,] matrix)
        {
            BigInteger sum = 0;

            if (!(passedCells.Any(c => c.SequenceEqual(coordinates))))
            {
                passedCells.Add((int[])coordinates.Clone());

                sum += matrix[coordinates[0], coordinates[1]];
            }

            return sum;
        }

        // method for horisontal move
        static (int dim, BigInteger sum) MoveHorisontally(int[] start, int[] target, List<int[]> passedCells, BigInteger[,] matrix)
        {
            int[] coordinates = (int[])start.Clone();

            int dim;
            BigInteger sum = 0;

            if ((target[1] - start[1]) > 0)
            {
                for (int i = start[1] + 1; i <= target[1]; i++)
                {
                    coordinates[1] = i;

                    sum += Sum(coordinates, passedCells, matrix);
                }
            }
            else
            {
                for (int i = start[1] - 1; i >= target[1]; i--)
                {
                    coordinates[1] = i;

                    sum += Sum(coordinates, passedCells, matrix);
                }
            }

            dim = coordinates[1];

            return (dim, sum);
        }

        // method for vertical move
        static (int dim, BigInteger sum) MoveVertically(int[] start, int[] target, List<int[]> passedCells, BigInteger[,] matrix)
        {
            int[] coordinates = (int[])start.Clone(); 

            int dim;
            BigInteger sum = 0;

            if ((target[0] - start[0]) > 0)
            {
                for (int i = start[0] + 1; i <= target[0]; i++)
                {
                    coordinates[0] = i;

                    sum += Sum(coordinates, passedCells, matrix);
                }
            }
            else
            {
                for (int i = start[0] - 1; i >= target[0]; i--)
                {
                    coordinates[0] = i;

                    sum += Sum(coordinates, passedCells, matrix);
                }
            }

            dim = coordinates[0];

            return (dim, sum);
        }

        // method for code breaking
        static int[][] CodeBreaking(int[] code, int R, int C)
        {
            int[][] input = new int[code.Length][];

            for (int i = 0; i < code.Length; i++)
            {
                int coef = Math.Max(R,C);
                int row = code[i] / coef;
                int coll = code[i] % coef;

                input[i] = new int[] { row, coll };
            }

            return input;
        }

        // method for making the matrix
        static BigInteger[,] MakeMatrix(int n, int m)
        {
            // making the matrix
            BigInteger[,] matrix = new BigInteger[n, m];

            int x = 0; 
            for (int i = n - 1; i >= 0; i--, x++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = BigInteger.Pow(2, (x + j));
                }
            }

            return matrix;
        }

        // method for printing matrix
        static void PrintMatrix(BigInteger[,] input)
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
