/*
Problem 5. The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers.
*/

using System;

namespace Problem_5._The_Biggest_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
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
            Console.WriteLine(biggest);

        }
    }
}
