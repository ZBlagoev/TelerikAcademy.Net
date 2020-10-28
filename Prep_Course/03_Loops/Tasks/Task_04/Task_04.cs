/*
Min Max Sum Average
Description
Write a program that reads from the console a sequence of N real numbers 
and returns the minimal, the maximal number, the sum and the average of 
all numbers (displayed with 2 digits after the decimal point).

The input starts by the number N (alone in a line) followed by N lines, 
each holding an real number.
The output is like in the examples below.
Input
On the first line, you will receive the number N.
On each of the next N lines, you will receive a single real number.
Output
You output must always consist of exactly 4 lines - the minimal element 
on the first line, the maximal on the second, the sum on the third 
and the average on the fourth, in the following format:
min=3.00
max=6.00
sum=9.00
avg=4.50
Constraints
1 <= N <= 1000
All numbers will be valid integer numbers that will be in the range [-10000, 10000]
*/

using System;
using System.Transactions;
using System.Xml;

namespace Task_04
{
    class Task_04
    {
        static void Main(string[] args)
        {
            //input 
            double n = double.Parse(Console.ReadLine());
            
            double k = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            double average = 0.00;
            double sum = 0.00;

            // calculation
            for (int i = 1; i <= n; i++)
            {
                k = double.Parse(Console.ReadLine());
                sum += k;

                if (k < min)
                {
                    min = k;
                }

                if (k > max)
                {
                    max = k;
                }

            }

            average = sum / n;

            // output
            Console.WriteLine($"min={Math.Round(min, 2).ToString("#.00")}");
            Console.WriteLine($"max={Math.Round(max, 2).ToString("#.00")}");
            Console.WriteLine($"sum={Math.Round(sum, 2).ToString("#.00")}");
            Console.WriteLine($"avg={Math.Round(average, 2).ToString("#.00")}");
        }
    }
}
