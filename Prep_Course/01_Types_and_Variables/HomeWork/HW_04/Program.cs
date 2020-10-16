/*
 * Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.
 */

using System;

namespace HW_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            // calculation
            int result = (first + second + Math.Abs(first - second)) / 2;

            // output
            Console.WriteLine(result);
        }
    }
}
