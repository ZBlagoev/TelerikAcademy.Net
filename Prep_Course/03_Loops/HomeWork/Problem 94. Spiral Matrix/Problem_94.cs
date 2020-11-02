using System;

namespace Problem_94._Spiral_Matrix
{
    class Problem_94
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Additional NON-Required Advanced Problem: Spiral Matrix");

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

                //empty array in square form
            int[,] matrix = new int[n, n];

            int positionValue = 1;
            int maxValue = n * n;

            int a = 0; 
            int b = n - 1;


            // calculation
            while (positionValue < maxValue)
            {
                //Right Direction Move  
                for (int horisontal = a; horisontal <= b; horisontal++)
                    matrix[a, horisontal] = positionValue++;

                //Down Direction Move  
                for (int vertical = a + 1; vertical <= b; vertical++)
                    matrix[vertical, b] = positionValue++;

                //Left Direction Move  
                for (int horisontal = b - 1; horisontal >= a; horisontal--)
                    matrix[b, horisontal] = positionValue++;

                //Up Direction Move  
                for (int vertical = b - 1; vertical >= a + 1; vertical--)
                    matrix[vertical, a] = positionValue++;

                a++;
                b--;
            }

            // output
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
