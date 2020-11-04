/*
Write a program that finds if an array of integers is symmetric - 
that is, the first number is equal to the last, the second - 
to the second last and so on
*/

using System;
using System.Linq;

namespace Problem_06._Is_Array_Symmetric
{
    class Problem_06
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 6. Is Array Symmetric");

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
    }
}
