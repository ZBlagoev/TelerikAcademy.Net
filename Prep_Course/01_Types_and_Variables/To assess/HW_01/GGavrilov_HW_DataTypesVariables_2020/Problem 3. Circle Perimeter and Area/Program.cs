using System;

namespace Problem_3._Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = radius * 2 * Math.PI;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("{0:0.00}", perimeter);
            Console.WriteLine("{0:0.00}", area);
        }
    }
}
//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

//Examples:
//r     perimeter    area
//2	     12.57	    12.57
//3.5	 21.99	    38.48