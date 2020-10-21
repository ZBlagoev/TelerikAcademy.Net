/*
 * Write a program that enters 5 numbers (each number will be on a separate/new line), calculates and prints their sum.
 */

using System;

namespace HW_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourth = double.Parse(Console.ReadLine());
            double fifth = double.Parse(Console.ReadLine());

            // calculation
            double sumOf = first + second + third + fourth + fifth;

            // output
            Console.WriteLine(sumOf);
        }
    }
}
