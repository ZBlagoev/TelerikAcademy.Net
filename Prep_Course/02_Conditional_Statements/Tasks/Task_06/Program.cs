/*
Biggest of Three
Description
Write a program that finds the biggest of three numbers that are read from the console.

Input
On the first three lines you will receive the three numbers, each on a separate line.
Output
On the only output line, write the biggest of the three numbers.
Constraints
The three numbers will always be valid floating-point numbers in the range [-200, 200].
*/

using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            // calculation
            double biggest = Math.Max(a, Math.Max(b, c));

            // output
            Console.WriteLine(biggest);
        }
    }
}
