/*
 * Write a program that enters 3 numbers (each number will be on a separate/new line), calculates and prints the sum of the greatest and smallest of them.
 */
using System;
using System.Numerics;

namespace HW_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // calculation
            int biggest = Math.Max(a, Math.Max(b, c));
            int smallest = Math.Min(a, Math.Min(b, c));
            int sumOf = smallest + biggest;

            // output
            Console.WriteLine(sumOf);

        }
    }
}
