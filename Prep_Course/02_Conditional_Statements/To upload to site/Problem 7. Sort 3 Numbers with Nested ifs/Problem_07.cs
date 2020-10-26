/*
Problem 7. Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted in descending order. 
* Use nested if statements.

Note: Don’t use arrays and the built-in sorting functionality.
*/

using System;

namespace Problem_7._Sort_3_Numbers_with_Nested_ifs
{
    class Problem_07
    {
        static void Main(string[] args)
        {
            // input **********************************************
            Console.WriteLine("Problem 7. Sort 3 Numbers with Nested ifs");

            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            int small;
            int medium;
            int big;

            // calculation **********************************************
                //big
            if (a > b)
            {
                if (a > c)
                {
                    big = a;
                }
                else
                {
                    big = c;
                }
            }
            else
            {
                if (b > c)
                {
                    big = b;
                }
                else
                {
                    big = c;
                }
            }

                // small
            if (a < b)
            {
                if (a < c)
                {
                    small = a;
                }
                else
                {
                    small = c;
                }
            }
            else
            {
                if (b < c)
                {
                    small = b;
                }
                else
                {
                    small = c;
                }
            }

                // medium
            if ((big == a && small == b) || (big == b && small == a))
            {
                medium = c;
            }
            else if ((big == a && small == c) || (big == c && small == a))
            {
                medium = b;
            }
            else
            {
                medium = a;
            }

            // output **********************************************
            Console.WriteLine($"result: {big} {medium} {small}");
        }
    }
}
