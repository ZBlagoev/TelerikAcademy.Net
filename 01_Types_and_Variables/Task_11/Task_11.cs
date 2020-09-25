/*
Write a program that reads a four-digit number and displays the sum of its digits

1213 => 1 + 2 + 1 + 3 = 7
2346 => 2 + 3 + 4 + 6 = 15
Input
On the first line, you will receive the four-digit number N
Output
On the only line of output, print the sum of digits
Constraints
1000 <= N <= 9999
*/
using System;

namespace Task_11
{
    class Task_11
    {
        static void Main(string[] args)
        {
            // inputs
            int a = Convert.ToInt16(Console.ReadLine());

            // calculations
            int sum = (a % 10) + (a/10 % 10) + (a / 100 % 10) + (a / 1000 % 10);

            Console.WriteLine(sum);
        }
    }
}
