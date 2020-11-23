/*
Write a program that prints the maximum length increasing subsequence to the console. 
If two or more are of the same length, print the last one
*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_09._Print_Max_Inc_Subsq
{
    class Problem_09
    {
        static void Main(string[] args)
        {
            // input 
            Console.WriteLine("Problem 9. Print Maximum Increasing Subsequence");

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> sequence = new List<int>();
            List<int> output = new List<int>();

            // calculation
            sequence.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i - 1])
                {
                    sequence.Add(arr[i]);
                }
                else
                {
                    if (sequence.Count >= output.Count)
                    {
                        output.Clear();
                        output.AddRange(sequence);
                    }

                    sequence.Clear();
                    sequence.Add(arr[i]);
                }
            }

            Console.WriteLine(string.Join(",", output));





        }
    }
}
