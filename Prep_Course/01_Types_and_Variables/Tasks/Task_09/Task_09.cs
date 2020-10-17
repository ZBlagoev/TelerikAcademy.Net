/*
Converter
You want to buy this really cool car from the UK, but you are worried about the fuel consumption. 
The values you see are MPG (miles per gallon). You have no idea what 20 MPG means so, 
being a programmer, decide to write a converter that helps you calculate the consumption.

Doing some research, you learn that 1 gallon = 4.54 litres and 1 mile = 1.6 km.

After the calculation, round the result down to the neareast whole number.

Input
On the first line you will receive a number m - miles per galon
Output
On the only line of output, print {result} litres per 100 km
Constraints
1 <= m <= 100
*/

using System;

namespace Task_09
{
    class Task_09
    {
        static void Main(string[] args)
        {
            // inputs
            double m = Convert.ToDouble(Console.ReadLine());

            // calculations
            double result = (4.54 / (m * 1.6)) * 100;

            // outputs
            Console.WriteLine($"{Math.Floor(result)} litres per 100 km");

        }
    }
}
