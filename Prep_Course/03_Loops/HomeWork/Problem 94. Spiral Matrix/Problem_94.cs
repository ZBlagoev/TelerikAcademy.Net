/*
Additional NON-Required Advanced Problem: Spiral Matrix
Write a program that reads from the console a positive integer number n 
(1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in 
the form of square spiral like in the examples below.
 */

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
            while (positionValue <= maxValue)
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

/*
scenario with n = 5:

a = 0
b = 4
    //Right Direction Move  
0,0|0,1|0,2|0,3|0,4
    //Down Direction Move 
1,4|2,4|3,4|4,4
    //Left Direction Move  
4,3|4,2|4,1|4,0
    //Up Direction Move
3,0|2,0|1,0|

a = 1
b = 3
    //Right Direction Move  
1,1|1,2|1,3
    //Down Direction Move 
2,3|3,3
    //Left Direction Move  
3,2|3,1
    //Up Direction Move
2,1

a = 2
b = 2
    //Right Direction Move  
2,2
*/
