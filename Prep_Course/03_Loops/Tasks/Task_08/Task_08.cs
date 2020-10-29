/*
Calculate Complex Sum
Description
Write a program that, for a given two numbers N and x, 
calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

Use only one loop. Print the result with 5 digits after the decimal point.
Input
On the first line you will receive one number - N.
On the second line you will receive another number - x.
Output
Output only one number - the sum of the sequence for the given N and x.
Constraints
N will always be a valid integer between 2 and 10, inclusive.
X will always be a valid floating-point number between 0.5 and 100
*/

using System;

namespace Task_08
{
    class Task_08
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double s = 1.00;
            double factorial = 1;

            // calculation
            for (int i = n; i >= 1; i--)
            {

                // solution with while loop 

                
                while (i != 1)
                {
                    factorial = factorial * i;
                    i -= 1;
                }

                s += factorial / Math.Pow(x,i);
                factorial = 1;
            }

            // output 

            Console.WriteLine(factorial);
            

            Console.WriteLine(Math.Round(s, 5).ToString("0.00000"));

        }


    }


}


