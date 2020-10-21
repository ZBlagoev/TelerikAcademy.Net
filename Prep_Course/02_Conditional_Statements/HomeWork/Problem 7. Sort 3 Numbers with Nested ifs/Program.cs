/*
Problem 7. Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted in descending order. 
* Use nested if statements.

Note: Don’t use arrays and the built-in sorting functionality.
*/

using System;

namespace Problem_7._Sort_3_Numbers_with_Nested_ifs
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
