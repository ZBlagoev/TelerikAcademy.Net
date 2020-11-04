/*
Write a program that determines if an array of 
integers is sorted in increasing order.
*/

using System;
using System.Linq;

namespace Problem_04._Is_Array_Sorted
{
    class Problem_04
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 4. Is Array Sorted?");

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = "Yes";

            // calculation
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    continue;
                }
                else
                {
                    result = "No";
                    break;
                }
            }

            // output
            Console.WriteLine($"output: {result}");


        }
    }
}
