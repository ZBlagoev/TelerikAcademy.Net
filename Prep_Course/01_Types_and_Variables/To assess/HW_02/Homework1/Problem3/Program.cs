using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Perimeter and Area of a Circle by Radius\n"); //header

            Console.WriteLine("Please provide the radius of the circle:"); 
            string stringNumber = Console.ReadLine();  //input
            double doubleNumber = double.Parse(stringNumber);
            double perimeterSolution = 2 * 3.14 * doubleNumber; //solution for Perimeter
            double surfaceSolution = doubleNumber * 3.14 * doubleNumber; //solution for Surface
            Console.WriteLine($"The perimeter is: {perimeterSolution:f2}"); //output1
            Console.WriteLine($"The Surface is: {surfaceSolution:f2}"); //output2
            
        }
    }
}
