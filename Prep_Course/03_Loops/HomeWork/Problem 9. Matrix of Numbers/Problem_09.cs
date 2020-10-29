/*
Write a program that reads from the console a positive integer number 
n (1 ≤ n ≤ 20) and prints a matrix like in the examples below.

Use two nested loops.
*/

using System;

namespace Problem_9._Matrix_of_Numbers
{
    class Problem_09
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 9. Matrix of Numbers");

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            // calculation & output
            Console.WriteLine("matrix:");

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i + (n - 1); j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
