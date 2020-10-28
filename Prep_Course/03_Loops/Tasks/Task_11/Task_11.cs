/*
Find Maximum Value
Write a program that finds the maximum number from a given sequence.

Input
On the first line you will receive one number - N - the count of numbers to follow.
On the next N lines you will receive the sequence of numbers, each on a new line.

Output
Output only one number - the maximum number you find

Constraints
1 <= N <= 20
-200 <= each number <= 200
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_11
{
    class Task_11
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            // calculation
            // populate main list
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numbers.Add(x);
            }

            // output
            Console.WriteLine(numbers.Max());

        }
    }
}
