using System;

namespace Spiral_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int value = 1;
            int max = n * n;

            int pointA = 0;
            int pointB = n - 1;


            // calculation
            while (value <= max)
            {
                //Right Direction Move  
                for (int right = pointA; right <= pointB; right++)
                    matrix[pointA, right] = value++;

                //Down Direction Move 
                for (int down = pointA + 1; down <= pointB; down++)
                    matrix[down, pointB] = value++;

                //Left Direction Move  
                for (int left = pointB - 1; left >= pointA; left--)
                    matrix[pointB, left] = value++;

                //Up Direction Move  
                for (int up = pointB - 1; up >= pointA + 1; up--)
                    matrix[up, pointA] = value++;

                pointA++;
                pointB--;
            }

            // output
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
