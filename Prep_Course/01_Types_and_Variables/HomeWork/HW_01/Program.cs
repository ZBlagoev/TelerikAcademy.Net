/*
 * Write a program that reads 3 int numbers from the console and prints their sum.
 */

using System;
using System.Linq;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int first = numbers[0];
            int second = numbers[1];
            int third = numbers[2];

            // calculation
            int sumOf = first + second + third;

            // output
            Console.WriteLine(sumOf);
        }
    }
}
