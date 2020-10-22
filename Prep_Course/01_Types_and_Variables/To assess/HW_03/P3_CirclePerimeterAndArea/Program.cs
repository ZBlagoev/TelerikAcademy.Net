using System;

namespace P3_CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double circleRadius = double.Parse(Console.ReadLine());
            
            //output
            double circlePerimeter = 2.0 * Math.PI * circleRadius;
            double circleArea = Math.PI * Math.Pow(circleRadius, 2);
            
            //print output
            Console.WriteLine($"{circlePerimeter:f2}\n" +
                $"{circleArea:f2}");
        }
    }
}
