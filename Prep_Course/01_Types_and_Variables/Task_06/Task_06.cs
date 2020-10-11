/*
Write a program that reads a positive integer (n) You must print the sum of all integers from 1 to n.

Hint
You could use the formula sum = n*(n+1)/2
Input
On the first line you will receive a number (n)
Output
You should print the sum of the integers from 1 to n
*/

using System;

namespace Task_06
{
    class Task_06
    {
        static void Main(string[] args)
        {
            // inputs
            string a = Console.ReadLine();

            // calculations
            int sum = int.Parse(a) * (int.Parse(a) + 1) / 2;

            // ouptuts
            Console.WriteLine(sum);
        }
    }
}
