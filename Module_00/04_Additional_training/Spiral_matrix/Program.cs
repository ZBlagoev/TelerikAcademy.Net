using System;

namespace Spiral_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            PrintSpiralMatrix(n);
        }

        static void PrintSpiralMatrix(int n)
        {
            int[,] matrix = new int[n, n];

            int positionValue = 1;
            int maxValue = n * n;

            int a = 0;
            int b = n - 1;

            while (positionValue <= maxValue)
            {
                for (int horisontal = a; horisontal <= b; horisontal++)
                    matrix[a, horisontal] = positionValue++;

                for (int vertical = a + 1; vertical <= b; vertical++)
                    matrix[vertical, b] = positionValue++;

                for (int horisontal = b - 1; horisontal >= a; horisontal--)
                    matrix[b, horisontal] = positionValue++;

                for (int vertical = b - 1; vertical >= a + 1; vertical--)
                    matrix[vertical, a] = positionValue++;

                a++;
                b--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
