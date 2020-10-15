/*
 * Write a program that enters 3 numbers (each number will be on a separate/new line), calculates and prints the sum of the greatest and smallest of them.
 */

using System;

namespace HW_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int biggest;
            int smallest;
            int sumOf;

            // calculation

                //biggest
            if (a > b)
            {
                if (a > c)
                {
                    biggest = a;
                }
                else
                {
                    biggest = c;
                }
            }
            else
            {
                if (b > c)
                {
                    biggest = b;
                }
                else
                {
                    biggest = c;
                }
            }

                //smallest
            if (a < b)
            {
                if (a < c)
                {
                    smallest = a;
                }
                else
                {
                    smallest = c;
                }
            }
            else
            {
                if (b < c)
                {
                    smallest = b;
                }
                else
                {
                    smallest = c;
                }
            }

            //sum
            sumOf = smallest + biggest;

            // output
            Console.WriteLine(sumOf);

        }
    }
}
