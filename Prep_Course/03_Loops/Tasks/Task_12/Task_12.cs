/*
Find Largest Three Values
Write a program that, that finds the three largest numbers in a sequence and prints 
them in descending order in the following format:

{largest}, {second_largest} and {third_largest}.

See the example for clarity

Input
On the first line you will receive one number - N - the count of numbers to follow.
On the next N lines you will receive the sequence of numbers, each on a new line.
Output
Output the three largest numbers in the already described format.
Constraints
3 <= N <= 20
-500 <= each number <= 500
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_12
{
    class Task_12
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
                // populate main list
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numbers.Add(x);
            }

            // calculation & output
            for (int i = 1; i < 3; i++)
            {
                Console.Write(numbers.Max());
                if (i < (2)) 
                {
                    Console.Write(", ");
                }
                numbers.Remove(numbers.Max());
            }

            Console.WriteLine($" and {numbers.Max()}");
        }
    }
}
