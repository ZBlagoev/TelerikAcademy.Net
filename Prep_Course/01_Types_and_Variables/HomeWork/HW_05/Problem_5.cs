/*
 * Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
 * (prints its real roots). Asume there always will be one or two real roots (b2 - 4ac >= 0)
 */

using System;

namespace HW_05
{
    class Problem_5
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 5. Quadratic Equation");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            // calculation
            decimal x1 = (decimal)((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
            decimal x2 = (decimal)((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));

            // output
            Console.Write("first root: ");
            Console.WriteLine(x1);
            Console.Write("second root: ");
            Console.WriteLine(x2);
        }
    }
}
