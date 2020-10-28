/*
Matrix Numbers
Write a program that reads from the console a positive integer number N 
and prints a matrix like in the examples below. Use two nested loops.

Input
The input will always consist of a single line, which contains the number N

Output
See the examples

Input
2

Output
1 2
2 3
*/

using System;

namespace Task_09
{
    class Task_09
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation & output
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i + n - 1; j++)
                {
                    Console.Write(j + " "); 
                }
                
                Console.WriteLine();
            }
        }
    }
}
