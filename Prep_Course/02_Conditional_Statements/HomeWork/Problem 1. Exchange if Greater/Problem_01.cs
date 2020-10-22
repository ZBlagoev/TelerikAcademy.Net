/*
Problem 1. Exchange If Greater
Write an if-statement that takes two double variables a and b and exchanges their values 
if the first one is greater than the second one. As a result print the values a and b, 
separated by a space.
*/

using System;

namespace Problem_1._Exchange_if_Greater
{
    class Problem_01
    {
        static void Main(string[] args)
        {
            // input 
            Console.WriteLine("Problem 1. Exchange if Greater");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            double temp;

            // calculation
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            // output
            Console.WriteLine($"result: {a} {b}");

        }
    }
}
