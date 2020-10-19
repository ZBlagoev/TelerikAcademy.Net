/*
Guess the Season
Write a program that displays the name of the season associated 
with a given date and month. Use the table below to determine 
the season's start and end dates.

Season	Start Date
Spring	March 20
Summer	June 21
Autumn	September 22
Winter	December 21
For example, Autumn lasts from September 22 to December 20, both inclusive.

Input
On the first line, you will receive the month as a string
On the second line, you will receive the date as a number
Output
On the only line of output, print the name of the season in pascal case
*/

using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string monthStr = Console.ReadLine();
            int date = int.Parse(Console.ReadLine());

            int monthInt;

            // calculation
            switch (monthStr)
            {
                case "January": monthInt = 1; break;
                case "February": monthInt = 2; break;
                case "March": monthInt = 3; break;
                case "April": monthInt = 4; break;
                case "May": monthInt = 5; break;
                case "June": monthInt = 6; break;
                case "July": monthInt = 7; break;
                case "August": monthInt = 8; break;
                case "September": monthInt = 9; break;
                case "October": monthInt = 10; break;
                case "November": monthInt = 11; break;
                case "December": monthInt = 12; break;
            }

        }
    }
}
