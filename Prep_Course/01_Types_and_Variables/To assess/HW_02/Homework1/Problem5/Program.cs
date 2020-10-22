using System;
using System.Text.RegularExpressions;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will solve x1 and x2 for a quadratic equation (type ax^2 + bx + c = 0)\n");

            Console.WriteLine("Please specify 'a':");
            string stringA = Console.ReadLine(); 
            double a = double.Parse(stringA);
            Console.WriteLine("Please specify 'b':");
            string stringB = Console.ReadLine();
            double b = double.Parse(stringB);
            Console.WriteLine("Please specify 'c':");
            string stringC = Console.ReadLine();
            double c = double.Parse(stringC);

            double d = b * b - 4 * a * c;
            double discriminantReplacer = Math.Sqrt(d);

            Console.WriteLine("\nThe value of x1 is: " + (-b + discriminantReplacer) / (2 * a));
            Console.WriteLine("The value of x2 is: " + (-b - discriminantReplacer) / (2 * a));


        }
    }
}
