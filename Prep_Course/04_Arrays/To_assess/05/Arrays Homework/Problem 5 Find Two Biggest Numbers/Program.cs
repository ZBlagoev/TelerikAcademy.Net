using System;

namespace Problem_5_Find_Two_Biggest_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Write a program that finds the two biggest numbers from an array of integers

                        Examples:

                        Input Output
                        8 2 1 3 5 8 9 11 2 5    11 9*/

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int biggestNumber;
            int secondBiggest;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            if (array[0] > array[1])
            {
                biggestNumber = array[0];
                secondBiggest = array[1];
            }
            else
            {
                biggestNumber = array[1];
                secondBiggest = array[0];
            }
            for (int j = 2; j<n; j++)
            {
                if (biggestNumber < array[j])
                {
                    secondBiggest = biggestNumber;
                    biggestNumber = array[j];
                }
                else if (secondBiggest < array[j])
                {
                    secondBiggest = array[j];
                }
            }
            Console.WriteLine(biggestNumber + " " + secondBiggest);
        }
    }
}
