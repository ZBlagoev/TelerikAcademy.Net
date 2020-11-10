/*
Write a program that prints the maximum length increasing subsequence to the console. 
If two or more are of the same length, print the last one
*/

using System;
using System.Linq;

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

            string sequence = "";

            // calculation
            for (int i = 1; i < arr.Length; i++)
            {

            }







        }
    }
}
