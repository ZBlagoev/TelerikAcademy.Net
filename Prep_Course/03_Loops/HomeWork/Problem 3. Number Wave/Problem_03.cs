/*
Write a program that reads from the console a positive integer number n 
and prints a "wave" i.e. the numbers from 1 to n and then the numbers 
from n - 1 to 1 on a single line separated by space.
*/

using System;
using System.Net.Http.Headers;

namespace Problem_3._Number_Wave
{
    class Problem_03
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 3. Number Wave");

            Console.Write("n: ");
            uint n = uint.Parse(Console.ReadLine());

            string result = "";

            // calculation
            for (int i = 1; i <= n; i++)
            {
                result += $"{i} ";

                if (i == n)
                {
                    for (uint j = n - 1; j >= 1; j--)
                    {
                        result += $"{j} ";
                    }
                }

            }

            // output
            Console.WriteLine($"result: {result}");
        }
    }
}
