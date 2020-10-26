/*
 * Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 
 */

using System;

namespace HW_03
{
    class Problem_3
    {
        static void Main(string[] args)
        {
            // input 
            Console.WriteLine("Problem 3. Circle Perimeter and Area");

            Console.Write("radius: ");
            double radius = double.Parse(Console.ReadLine());

            // calculation
            double area = Math.PI * radius * radius;
            double perimeter = Math.PI * radius * 2;

            // output
            Console.Write("perimeter: ");
            Console.WriteLine(Math.Round(perimeter, 2));
            Console.Write("area: ");
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
