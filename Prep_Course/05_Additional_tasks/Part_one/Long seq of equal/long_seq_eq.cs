/*
Description
Write a program that finds the length of the maximal sequence 
of equal elements in an array of N integers.

Input
On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output
Print the length of the maximal sequence
*/

using System;

namespace Long_seq_of_equal
{
    class long_seq_eq
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int counter = 1;
            int max = 1;

            // calculation
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    continue;

                }
                else if (arr[i - 1] == arr[i])
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
            Console.WriteLine(max);
        }
    }
}
