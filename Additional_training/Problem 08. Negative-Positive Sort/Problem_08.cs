/*
Write a program that moves all negative numbers to the beginning 
and all positive to the end, without changing the order of positive negative
*/

using System;
using System.Linq;

namespace Problem_08._Negative_Positive_Sort
{
    class Problem_08
    {
        static void Main(string[] args)
        {
            // input 
            Console.WriteLine("Problem 8. Negative-Positive Sort");

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string positive = "";
            string negative = "";

            // calculation
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    positive += " " + arr[i].ToString();
                }
                else
                {
                    negative += " " + arr[i].ToString();
                }
            }

            // output
            Console.Write($"output:{negative}{positive}");

        }
    }
}
