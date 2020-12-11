/*
We have the following operations defined for two-digit numbers. There are two possible ways of merging them:

Merging ab and cd produces bc
42 merged with 17 produces 21
17 merged with 42 produces 74
Squashing ab and cd produces a(b+c)d - the middle digit is the sum of b and c
42 squashed with 17 produces 437
39 squashed with 57 produces 347 (9 + 5 = 14, we use only the 4)
You have a sequence of N two-digit numbers. Your task is to merge and squash each pair of adjacent numbers.

Input
All input data is read from the standard input

On the first line, you will receive an integer N
On the next N lines you will receive N two-digit numbers
Each number will be on a separate line
Output
The output data is printed on the standard output

On the first output line print the merged numbers

There should be N - 1 of them
Separate them by spaces
On the second output line print the squashed numbers

There should be N - 1 of them
Separate them by spaces
Constraints
2 <= N <= 1000
Numbers will consist of two non-zero digits
The input data will always be correct and there is no need to check it explicitly
*/
using System;

namespace _02_Merge_Squash
{
    class Problem_02
    {
        static void Main(string[] args)
        {
            // input 
            int n = int.Parse(Console.ReadLine());

            int[] input = new int[n];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int[] merged = new int[n - 1];
            int[] squashed = new int[n - 1];

            string mergedOutput = "";
            string squashedOutput = "";

            // calculation
            for (int i = 0; i < merged.Length; i++)
            {
                merged[i] = (input[i] % 10 * 10) + (input[i + 1] / 10);
            }

            for (int i = 0; i < squashed.Length; i++)
            {
                int a = input[i] / 10;
                int b = (input[i] % 10 + input[i + 1] / 10) % 10;
                int c = input[i + 1] % 10;

                squashed[i] = a * 100 + b * 10 + c;
            }

            // test
            foreach (var item in merged)
            {
                mergedOutput += $"{item} ";
            }

            Console.WriteLine();

            foreach (var item in squashed)
            {
                squashedOutput += $"{item} ";
            }

            // output
            Console.WriteLine(string.Join(" ", mergedOutput));
            Console.WriteLine(string.Join(" ", squashedOutput));
        }
    }
}
