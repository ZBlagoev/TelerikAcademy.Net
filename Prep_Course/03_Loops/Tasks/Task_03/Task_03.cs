/*
Find Average
You need to calculate the average of a collection of values. 
Every value will be valid number. The average must be printed with 
two digits after the decimal point.

Input
On the first line, you will receive N - the number of the values you must read
On the next N lines you will receive numbers.
Output
On the only line of output, print the average with two digits after the decimal point.
*/

using System;

namespace Task_03
{
    class Task_03
    {
        static void Main(string[] args)
        {
            // input
            double n = double.Parse(Console.ReadLine());
            double k = 0.00;
            double average;
            
            for (int i = 1; i <= n; i++)
            {
                k += double.Parse(Console.ReadLine());
            }

            // calculation
            average = (k / n);

            // output
            Console.WriteLine(Math.Round(average,2).ToString("#.00"));
        }
    }
}
