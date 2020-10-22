/*
Problem 10. Beer Time
A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
and prints beer time or non-beer time according to the definition above 
or invalid time if the time cannot be parsed.
Note: You may need to learn how to parse dates and times.
*/

using System;
using System.Globalization;

namespace Problem_10._Beer_Time
{
    class Problem_10
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 10. Beer time");

            Console.Write("time: ");
            var time = Convert.ToDateTime(Console.ReadLine());

            // doesn't work for some reason
            //DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm tt", CultureInfo.InvariantCulture);

            string partyZeit;

            // calculation
            if ((time >= Convert.ToDateTime("1:00 PM")) || (time <= Convert.ToDateTime("3:00 AM")))
            {
                partyZeit = "beer time";
            }
            else
            {
                partyZeit = "non-beer time";
            }

            
            // output
            Console.WriteLine(partyZeit);
            Console.WriteLine(time);
        }
    }
}
