/*
Problem 2. Numbers Not Divisible by 3 and 7
Write a program that enters from the console a positive integer n 
and prints all the numbers from 1 to n not divisible by 3 or 7, 
on a single line, separated by a space.
*/

using System;

namespace Problem_2._Numbers_not_divisible_by_3_or_7
{
    class Problem_02
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 2. Numbers not divisible by 3 and 7");

            Console.Write("n: ");
            uint n = uint.Parse(Console.ReadLine());

            string result = "";

            // calculation
            for (int i = 1; i <= n ; i++)
            {
                if (!((i % 3 == 0) || (i % 7 == 0)))
                {
                    result += $"{i} "; 
                }
            }

            // output
            Console.WriteLine($"result: {result}");
        }
    }
}
