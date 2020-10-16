/*
 * Write a program that reads 3 int numbers from the console and prints their sum.
 */

using System;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            // calculation
            int sumOf = first + second + third;

            // output
            Console.WriteLine(sumOf);
        }
    }
}
