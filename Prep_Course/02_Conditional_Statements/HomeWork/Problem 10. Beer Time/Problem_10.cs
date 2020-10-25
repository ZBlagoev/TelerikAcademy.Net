/*
Problem 10. Beer Time
A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
and prints beer time or non-beer time according to the definition above 
or invalid time if the time cannot be parsed.
Note: You may need to learn how to parse dates and times.
*/

/*
if (DateTime.TryParse(inputString, out dDate))
{
    String.Format("{0:d/MM/yyyy}", dDate); 
}
else
{
    Console.WriteLine("Invalid"); // <-- Control flow goes here
}
*/



using System;
using System.Globalization;

namespace Problem_10._Beer_Time
{
    class Problem_10
    {
        static void Main(string[] args)
        {
            // input **********************************************
            Console.WriteLine("Problem 10. Beer time");

            Console.Write("time: ");
            string time = Console.ReadLine();

            string partyZeit = "";

                // variables to test if input is in correct datetime format
            DateTime dDate;
            string format = "h:mm tt";

            // calculation **********************************************
            if (DateTime.TryParseExact(time, format, CultureInfo.InvariantCulture,DateTimeStyles.None, out dDate)) 
                // ensures input is in AM/PM form only (revert for previous commit for every datetime format)
            {
                if ((Convert.ToDateTime(time) >= Convert.ToDateTime("1:00 PM")) || (Convert.ToDateTime(time) <= Convert.ToDateTime("3:00 AM")))
                    // ensures the correct time windows for both outcomes
                {
                    partyZeit = "beer time";
                }
                else 
                {
                    partyZeit = "non-beer time";
                }
            }
            else
            {
                partyZeit = "invalid time";
            }

            // output **********************************************
            Console.WriteLine(partyZeit);
        }
    }
}
