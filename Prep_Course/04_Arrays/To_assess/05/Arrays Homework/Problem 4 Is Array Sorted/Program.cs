using System;
using System.Diagnostics.CodeAnalysis;

namespace Problem_4_Is_Array_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    Write a program that determines if an array of integers is sorted in increasing order.*/
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            bool isSorted = true; 


            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    isSorted = false;
                    break;
                }
            }
                if (isSorted)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }

        }
    }
}
