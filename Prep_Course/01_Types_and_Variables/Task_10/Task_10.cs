/*
Write a program that reads days, hours, minutes and seconds from the standard input. 
Display the total amount of seconds.

Input
First line - d - days
Second line - h - hours
Third line - m - minutes
Fourth line - s - seconds
Output
On the only line of output, print the total amount of seconds
Constraints
0 <= d, h, m, s <= 1000
*/

using System;

namespace Task_10
{
    class Task_10
    {
        static void Main(string[] args)
        {
            // inputs
            int d = Convert.ToUInt16(Console.ReadLine());
            int h = Convert.ToUInt16(Console.ReadLine());
            int m = Convert.ToUInt16(Console.ReadLine());
            int s = Convert.ToUInt16(Console.ReadLine());

            // calculations
            int total = s + m * 60 + h * 3600 + d * 86400;

            // outputs
            Console.WriteLine(total);
        }
    }
}
