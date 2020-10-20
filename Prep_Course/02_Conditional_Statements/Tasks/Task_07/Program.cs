/*
Biggest of Five
Description
Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

Input
On the first 5 lines you will receive the 5 numbers, each on a separate line
Output
On the only output line, write the biggest of the 5 numbers
*/

using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double firstN = double.Parse(Console.ReadLine());
            double secondN = double.Parse(Console.ReadLine());
            double thirdN = double.Parse(Console.ReadLine());
            double fourthN = double.Parse(Console.ReadLine());
            double fifthN = double.Parse(Console.ReadLine());

            double biggestN = double.MinValue;

            // calculation
            if (biggestN < firstN)
            {
                biggestN = firstN;
            }

            if (biggestN < secondN)
            {
                biggestN = secondN;
            }

            if(biggestN < thirdN)
            {
                biggestN = thirdN;
            }

            if(biggestN < fourthN)
            {
                biggestN = fourthN;
            }

            if(biggestN < fifthN)
            {
                biggestN = fifthN;
            }

            // output
            Console.WriteLine(biggestN);

        }
    }
}
