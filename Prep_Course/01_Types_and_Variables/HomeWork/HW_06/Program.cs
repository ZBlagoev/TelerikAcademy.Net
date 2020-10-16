/*
 * Write a program that enters 5 numbers (each number will be on a separate/new line), calculates and prints their sum.
 */

using System;

namespace HW_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            int fifth = int.Parse(Console.ReadLine());

            // calculation
            int sumOf = first + second + third + fourth + fifth;

            // output
            Console.WriteLine(sumOf);
        }
    }
}
