/*
 * Write a program that enters 5 numbers (each number will be on a separate/new line), calculates and prints their sum.
 */

using System;

namespace HW_06
{
    class Problem_6
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 6. Sum of 5 Numbers");

            Console.Write("a: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double third = double.Parse(Console.ReadLine());
            Console.Write("d: ");
            double fourth = double.Parse(Console.ReadLine());
            Console.Write("e: ");
            double fifth = double.Parse(Console.ReadLine());

            // calculation
            double sumOf = first + second + third + fourth + fifth;

            // output
            Console.WriteLine($"sum: {sumOf}");
        }
    }
}
