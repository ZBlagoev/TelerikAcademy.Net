using System;

namespace Problem_5._Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double coeffA = double.Parse(Console.ReadLine());
            double coeffB = double.Parse(Console.ReadLine());
            double coeffC = double.Parse(Console.ReadLine());
            double rootX1 = (-coeffB - Math.Sqrt(Math.Pow(coeffB, 2) - 4 * coeffA * coeffC)) / (2 * coeffA);
            double rootX2 = (-coeffB + Math.Sqrt(Math.Pow(coeffB, 2) - 4 * coeffA * coeffC)) / (2 * coeffA);
            Console.WriteLine("x1="+Math.Abs(rootX1));
            Console.WriteLine("x2="+Math.Abs(rootX2));
        }
    }
}
//Problem 5. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots). 
//Asume there always will be one or two real roots(b2 - 4ac >= 0)

//Examples:
//  a    b    c       roots
//  2	  5	   -3	   x1=-3; x2=0.5
// -1	  3	    0	   x1=3; x2=0
//-0.5  4	   -8	   x1=4; x2=4