/*
Write a program that reads from the console a sequence of n integer numbers 
and returns the minimal, the maximal number, the sum and the average of 
all numbers (displayed with 2 digits after the decimal point).

The input starts by the number n (alone in a line) followed by n lines, 
each holding an integer number.
The output is like in the examples below.
*/

using System;

namespace Problem_5._Min_Max_Sum_and_Avg
{
    class Problem_05
    {
        static void Main(string[] args)
        {
            //input 
            Console.WriteLine("Problem 5. Min, Max, Sum and Average of N Numbers");
            
            Console.Write("n: ");
            double n = double.Parse(Console.ReadLine());

            double k;
            double min = double.MaxValue;
            double max = double.MinValue;
            double average;
            double sum = 0.00;

            // calculation
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"n{i}: ");
                k = double.Parse(Console.ReadLine());
                sum += k;

                if (k < min)
                {
                    min = k;
                }

                if (k > max)
                {
                    max = k;
                }

            }

            average = sum / n;

            // output
            Console.WriteLine("output:");
            Console.WriteLine($"min={min:#.00}");
            Console.WriteLine($"max={max:#.00}");
            Console.WriteLine($"sum={sum:#.00}");
            Console.WriteLine($"avg={average:#.00}");
        }
    }
}
