/*
Problem 6. The Biggest of Five Numbers
Write a program that enters 5 numbers (each number will be on a separate/new line), 
calculates and prints the biggest of them.
*/

using System;

namespace Problem_6._The_Biggest_of_Five_Numbers
{
    class Problem_06
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 6. The Biggest of Five Numbers");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e: ");
            double e = double.Parse(Console.ReadLine());

            double biggest = double.MinValue;

            // calculation
            if (biggest < a)
            {
                biggest = a;
            }

            if (biggest < b)
            {
                biggest = b;
            }

            if (biggest < c)
            {
                biggest = c;
            }

            if (biggest < d)
            {
                biggest = d;
            }

            if (biggest < e)
            {
                biggest = e;
            }

            // output
            Console.WriteLine($"biggest: {biggest}");
        }
    }
}
