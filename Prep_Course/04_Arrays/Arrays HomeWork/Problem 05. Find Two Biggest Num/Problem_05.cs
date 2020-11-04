/*
Write a program that finds the two biggest numbers from an array of integers
*/

using System;
using System.Linq;

namespace Problem_05._Find_Two_Biggest_Num
{
    class Problem_05
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 5. Find Two Biggest Numbers");

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bigA = int.MinValue;
            int bigB = int.MinValue;

            // calculation
            foreach (int element in arr)
            {
                if (element > bigA)
                {
                    bigB = bigA;
                    bigA = element;
                }
                else if (element > bigB)
                {
                    bigB = element;
                }   
            }

            // output
            Console.WriteLine($"output: {bigA} {bigB}");
        }
    }
}
