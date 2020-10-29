/*
Write a program that, for a given two integer numbers n and x, 
calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.

Use only one loop. Print the result with 5 digits after the decimal point.
Note that each element can be calculated from the previous by this "formula": 
(previous_element) * i / x
*/

using System;

namespace Problem_8._Calculate
{
    class Problem_08
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 8. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N");

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());

            double s = 1.00;
            int factorial = 1;

            // calculation
            for (int i = 1; i <= n; i++)
            {
                factorial = 1;

                for (int j = i; j >= 1;  j--)
                {
                    factorial *= j;
                }

                s += factorial / Math.Pow(x, i);
            }

            // output
            Console.WriteLine($"S: {Math.Round(s, 5).ToString("0.00000")}");

        }
    }
}
