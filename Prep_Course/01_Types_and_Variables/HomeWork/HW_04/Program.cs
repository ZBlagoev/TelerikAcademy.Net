/*
 * Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.
 */

using System;
using System.Linq;

namespace HW_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double first = numbers[0];
            double second = numbers[1];

            // calculation
            double result = (first + second + Math.Abs(first - second)) / 2;

            // output
            Console.WriteLine(result);
        }
    }
}
