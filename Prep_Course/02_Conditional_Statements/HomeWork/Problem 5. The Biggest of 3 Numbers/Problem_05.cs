/*
Problem 5. The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers.
*/

using System;

namespace Problem_5._The_Biggest_of_3_Numbers
{
    class Problem_05
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 5. The Biggest of 3 Numbers");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            double biggest;

            // calculation
            if (a > b)
            {
                if (a > c)
                {
                    biggest = a;
                }
                else
                {
                    biggest = c;
                }
            }
            else if (b > c)
            {
                biggest = b;
            }
            else
            {
                biggest = c;
            }

            // output
            Console.WriteLine($"biggest: {biggest}");

        }
    }
}
