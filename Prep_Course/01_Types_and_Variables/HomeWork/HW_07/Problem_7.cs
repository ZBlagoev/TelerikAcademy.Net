/*
 * Write a program that enters 3 numbers (each number will be on a separate/new line), calculates and prints the sum of the greatest and smallest of them.
 */
using System;
using System.Numerics;

namespace HW_07
{
    class Problem_7
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 7. Sum of greatest and smallest");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            // calculation
            double biggest = Math.Max(a, Math.Max(b, c));
            double smallest = Math.Min(a, Math.Min(b, c));
            double sumOf = smallest + biggest;

            // output
            Console.WriteLine($"sum: {sumOf}");

        }
    }
}
