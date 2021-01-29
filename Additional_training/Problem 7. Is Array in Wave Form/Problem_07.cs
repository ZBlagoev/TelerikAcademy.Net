/*
Write a program that determines if an array of integers is in Wave Form -
e.g. first > second < third > fourth < fifth > ...
*/

using System;
using System.Linq;

namespace Problem_7._Is_Array_in_Wave_Form
{
    class Problem_07
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 7. Is Array in Wave Form");

            Console.Write("input: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int result = 0;

            // calculation
            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (!(arr[i] < arr[i - 1]))
                    {
                        result++;
                    }
                }
                else if (i % 2 == 0)
                {
                    if (!(arr[i] > arr[i - 1]))
                    {
                        result++;
                    }
                }
            }

            // output
            if (result == 0)
            {
                Console.WriteLine("output: Yes");
            }
            else
            {
                Console.WriteLine("output: No");
            }

        }
    }
}
