/*
Write a program that find all pairs of integers whose sum is equal to a given number. 
On the first line you will receive the target sum, on the second line - the array.
*/

using System;
using System.Linq;

namespace Problem_11._Pairs
{
    class Problem_11
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 11. Pairs");

            Console.Write("sum: ");
            int sum = int.Parse(Console.ReadLine());

            Console.Write("array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string pairs = "";

            // calculation
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        continue;
                    }
                    else if (arr[i] + arr[j] == sum)
                    {
                        pairs += $"{arr[i]}, {arr[j]}";
                    }
                }
            }

            // output
            Console.WriteLine("output:");
            for (int i = 1; i <= pairs.Length; i++)
            {
                if (i == 1)
                {
                    Console.Write(pairs[i - 1]);
                }
                else if (i % 4 == 0)
                {
                    Console.Write(pairs[i - 1]);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(pairs[i - 1]);
                }
            }
             
        }
    }
}
