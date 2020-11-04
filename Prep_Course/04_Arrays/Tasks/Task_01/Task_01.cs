/*
Sort Numbers
Write a program that reads a list of numbers separated by a comma and space.

Arrange the numbers in descending order.

Output all numbers on a single line, separated by a comma and a space.

Input
On the only line you will receive all the numbers to be sorted.

Output
On the only line of output, print all the numbers sorted in format n1, n2, n3, .. n
*/

using System;

namespace Task_01
{
    class Task_01
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            string[] arrayS = input.Split(',');
            int[] arrayN = Array.ConvertAll(arrayS, int.Parse);

            string result = "";

            // calculation
            Array.Sort(arrayN);
            Array.Reverse(arrayN);

            foreach(int num in arrayN)
            {
                result += ", " + num;
            }

            // output
            Console.WriteLine(result.Substring(2));

        }
    }
}
