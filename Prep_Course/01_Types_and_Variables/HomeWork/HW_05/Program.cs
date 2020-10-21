/*
 * Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
 * (prints its real roots). Asume there always will be one or two real roots (b2 - 4ac >= 0)
 */

using System;

namespace HW_05
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
            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            // output
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
