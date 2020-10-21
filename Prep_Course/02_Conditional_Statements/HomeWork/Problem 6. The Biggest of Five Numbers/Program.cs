/*
Problem 6. The Biggest of Five Numbers
Write a program that enters 5 numbers (each number will be on a separate/new line), 
calculates and prints the biggest of them.
*/

using System;

namespace Problem_6._The_Biggest_of_Five_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double biggestN = double.MinValue;

            // calculation
            if (biggestN < a)
            {
                biggestN = a;
            }

            if (biggestN < b)
            {
                biggestN = b;
            }

            if (biggestN < c)
            {
                biggestN = c;
            }

            if (biggestN < d)
            {
                biggestN = d;
            }

            if (biggestN < e)
            {
                biggestN = e;
            }

            // output
            Console.WriteLine(biggestN);
        }
    }
}
