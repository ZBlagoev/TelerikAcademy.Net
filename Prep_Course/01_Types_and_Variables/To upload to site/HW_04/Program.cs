/*
 * Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.
 */

using System;

namespace HW_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            // calculation
            double result = (first + second + Math.Abs(first - second)) / 2;

            // output
            Console.WriteLine(result);
        }
    }
}
