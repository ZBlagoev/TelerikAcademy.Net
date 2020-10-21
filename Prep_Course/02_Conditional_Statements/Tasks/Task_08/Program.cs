/*
Sort Three Numbers
Description
Write a program that enters 3 real numbers and prints them sorted in descending order.

Use nested if statements.
Don’t use arrays and the built-in sorting functionality.

Input
On the first three lines, you will receive the three numbers, each on a separate line.
Output
Output a single line on the console - the sorted numbers, separated by a white space
Constraints
The three numbers will always be valid integer numbers in the range [-1000, 1000]
*/

using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int thirdN = int.Parse(Console.ReadLine());

            int small;
            int medium;
            int big;

            // calculation
                //big
            if (firstN > secondN)
            {
                if (firstN > thirdN)
                {
                    big = firstN;
                }
                else
                {
                    big = thirdN;
                }
            }
            else
            {
                if (secondN > thirdN)
                {
                    big = secondN;
                }
                else
                {
                    big = thirdN;
                }
            }

                // small
            if (firstN < secondN)
            {
                if (firstN < thirdN)
                {
                    small = firstN;
                }
                else
                {
                    small = thirdN;
                }
            }
            else
            {
                if (secondN < thirdN)
                {
                    small = secondN;
                }
                else
                {
                    small = thirdN;
                }
            }

            // medium
            if ((big == firstN && small == secondN) || (big == secondN && small == firstN))
            {
                medium = thirdN;
            }
            else if ((big == firstN && small == thirdN) || (big == thirdN && small == firstN))
            {
                medium = secondN;
            }
            else
            {
                medium = firstN;
            }

            // output
            Console.WriteLine($"{big} {medium} {small}");
        }
    }
}
