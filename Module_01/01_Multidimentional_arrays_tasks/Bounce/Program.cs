using System;
using System.Linq;

namespace Bounce
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *matrix [i,j]
             *
             *item[0,0] - start - down-right
             *item[i-1, x] - change dir - up-right
             *item[x, j-1] - change dir - up-left
             *item[0, x] - change dir - down-left
             *item[i-1, x] - change dir - up-left
             *
             * i changes first sub-dir
             * j changes second sub-dir
             *
             *item[0, j-1] - up-right exit
             *item[i-1, j-1] - down-right exit
             *item[i-1, 0] - down-left exit
             *item[0,0] - up-left exit
             *
             *directions explained:
             *  down-right: i++, j++;
             *  up-right: i++, j--;
             *  up-left: i--, j--;
             *  down-left: i--, j++;
            */


            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = dimentions[0];
            int m = dimentions[1];

            // making the matrix
            ulong[,] matrix = new ulong[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = (ulong)Math.Pow(2, (i + j));
                }
            }

            // setting the sum, position coordinates and movement directions
            ulong sum = matrix[0,0];

            int x = 0;
            int y = 0;

            int verticalMove = 1;
            int horizontalMove = 1;

            // loop for movement
            do
            {
                // movement
                x += verticalMove;
                y += horizontalMove;

                // break if matrix is one dimentional
                if (x == n || y == m)
                {
                    break;
                }

                // incrementing the sum
                sum += matrix[x, y];

                // vertical wallhit
                if (x == n - 1 || x == 0)
                {
                    verticalMove = -verticalMove;
                }

                // horizontal wallhit
                if (y == m - 1 || y == 0)
                {
                    horizontalMove = -horizontalMove;
                }

            } while (!((x == 0 || x == n - 1) && (y == 0 || y == m - 1)));

            // result print
            Console.WriteLine(sum);
        }
    }
}
