/*
Problem 4. Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, 
without calculating it. * Use a sequence of if operators.
*/

using System;

namespace Problem_4._Multiplication_Sign
{
    class Problem_04
    {
        static void Main(string[] args)
        {
            // input **********************************************
            Console.WriteLine("Problem 4. Multiplication Sign");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            string result;

            // calculation **********************************************
            if ((a < 0) || (b < 0) || (c < 0) || ((a < 0) && (b < 0) && (c < 0)))
            {
                result = "result: -";
            }
            else if ((a == 0.0) || (b == 0.0) || (c == 0.0))
            {
                result = "result: 0";
            }
            else
            {
                result = "result: +";
            }

            // output **********************************************
            Console.WriteLine(result);

        }
    }
}
