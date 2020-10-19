/*
Most people believe that 1 human year (~HY~) equals 7 dog years (~DY~), however, dogs reach adulthood in approximately 2 human years.

So it's better to count the first two HY as 10 DY each and then count the remaining HY as 4 DY each.

Write a program that correctly converts human years (HY) to dog years (DY). You may need some form of conditional logic.
*/

using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int humanYears = int.Parse(Console.ReadLine());
            int dogYears;

            // calculation
            if (humanYears <= 2)
            {
                dogYears = 10 * humanYears;
            }
            else
            {
                dogYears = 4 * (humanYears - 2) + 20;
            }

            // output
            Console.WriteLine(dogYears);
        }
    }
}
