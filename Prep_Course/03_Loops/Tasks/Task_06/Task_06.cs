/*
Convert Degrees
You need to provide conversion of the temperature given in Celsius to their 
Fahrenheit representation.

Explanation
Hint
Search how you could split the list of values and then you can iterate over them.
JavaScript
forEach
Java
For-each loop
C#

For-each loop
Input
On the first line, you will receive a list of values separated by a single space.
Output
On each line in the output print the converted temperature. 
Print a whole number rounded to the nearest integer (Math rules apply) 
and without digits after the decimal point.
*/

using System;
using System.Collections.Generic;

namespace Task_06
{
    class Task_06
    {
        static void Main(string[] args)
        {
            // input

            string input = Console.ReadLine();
            string[] fInput = input.Split(" ");

            List<double> fehrenheit = new List<double>();
            List<double> celsius = new List<double>();

            double oneNum;

            // calculation
                // fill fehreneit list
            foreach (string s in fInput)
            {
                if (Double.TryParse(s, out oneNum))
                    fehrenheit.Add(oneNum);
            }

                // fill celsius list
            foreach (double d in fehrenheit)
            {
                 celsius.Add(Math.Round(d * 9 / 5 + 32));
            }

            // output
            celsius.ForEach(Console.WriteLine);

        }
    }
}

/*
Status: Compile Error
Error: /tmp/tmpo2NSiA/00305degrees.cs(13,37): error CS1502: The best overloaded 
method match for `string.Split(params char[])' has some invalid arguments 
/usr/lib/mono/4.5/mscorlib.dll (Location of the symbol related to previous error) 
/tmp/tmpo2NSiA/00305degrees.cs(13,43): error CS1503: Argument `#1' cannot convert 
`string' expression to type `char[]'
*/


