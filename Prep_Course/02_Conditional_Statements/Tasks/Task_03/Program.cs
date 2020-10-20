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
using System.Diagnostics.CodeAnalysis;

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
            string season;

            // calculation
                // set up numeric form of months
            if (monthStr.ToLower() == "january")
            {
                monthInt = 100;
            }
            else if (monthStr.ToLower() == "february")
            {
                monthInt = 200;
            }
            else if (monthStr.ToLower() == "march")
            {
                monthInt = 300;
            }
            else if (monthStr.ToLower() == "april")
            {
                monthInt = 400;
            }
            else if (monthStr.ToLower() == "may")
            {
                monthInt = 500;
            }
            else if (monthStr.ToLower() == "june")
            {
                monthInt = 600;
            }
            else if (monthStr.ToLower() == "july")
            {
                monthInt = 700;
            }
            else if (monthStr.ToLower() == "august")
            {
                monthInt = 800;
            }
            else if (monthStr.ToLower() == "september")
            {
                monthInt = 900;
            }
            else if (monthStr.ToLower() == "october")
            {
                monthInt = 1000;
            }
            else if (monthStr.ToLower() == "november")
            {
                monthInt = 1100;
            }
            else 
            {
                monthInt = 1200;
            }

            // add monthInt to date variable
            date += monthInt;

                // set seasons logic
            if (date >= 320 && date < 621)
            {
                season = "Spring";
            }
            else if (date >= 621 && date < 922)
            {
                season = "Summer";
            }
            else if (date >= 922 && date < 1221)
            {
                season = "Autumn";
            }
            else 
            {
                season = "Winter";
            }

            // output
            Console.WriteLine(season);

        }
    }
}
