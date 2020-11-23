/*
Write a program that finds the length of the maximum sequence 
of equal elements in an array of integers.
*/

using System;
using System.Linq;

namespace Problem_03._Maximum_Sequence
{
    class Problem_03
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 3. Maximum Sequence");

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 1;
            int max = 1;

            // calculation
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i - 1] == arr[i])
                {
                    counter++;
                }
                else
                {
                    if (max < counter)
                    {
                        max = counter;
                    }

                    counter = 1;
                }
            }

            // output
            Console.WriteLine($"output: {max}");

        }
    }
}
