using System;

namespace Problem_9_Print_Maximum_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   Write a program that prints the maximum length increasing subsequence 
              to the console.If two or more are of the same length, print the last one*/


            int count = 1;
            int tempCount = 1;
            int[] tempSubsequence;
            int[] subsequence;

            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    tempCount++;
                }
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;

                }
            }
            Console.WriteLine(count);
        }

    }

}
