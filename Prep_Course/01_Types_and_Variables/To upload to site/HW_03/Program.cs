/*
 * Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 
 */

using System;

namespace HW_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            double radius = double.Parse(Console.ReadLine());

            // calculation
            double area = Math.PI * radius * radius;
            double perimeter = Math.PI * radius * 2;

            // output
            Console.WriteLine(Math.Round(perimeter, 2));
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
