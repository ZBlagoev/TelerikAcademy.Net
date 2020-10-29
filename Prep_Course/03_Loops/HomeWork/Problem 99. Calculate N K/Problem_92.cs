/*
Write a program that calculates n! / k! for given n and k (1 < k < n < 100).

Use only one loop.
*/

using System;

namespace Problem_99._Calculate_N_K
{
    class Problem_92
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;

            // calculation
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

            }

            // output
            Console.WriteLine(factorial);

        }
    }

}
