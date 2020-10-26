/*
 * Write a program that reads 3 int numbers from the console and prints their sum.
 */

using System;

namespace HW_01
{
    class Problem_1
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 1. Sum of 3 Numbers");

            Console.Write("a: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int third = int.Parse(Console.ReadLine());

            // calculation
            int sumOf = first + second + third;

            // output
            Console.WriteLine($"sum: {sumOf}");
        }
    }
}
