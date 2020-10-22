using System;

namespace P5_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            
            //output
            double x1 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            double x2 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            
            if (x1 == -0.0)
            {
                x1 = 0.0;
            }
            if (x2 == -0.0)
            {
                x2 = 0.0;
            }

            //print output
            Console.WriteLine($"x1={x1}; x2={x2}");
        }
    }
}
