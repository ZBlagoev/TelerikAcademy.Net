/*
Problem 11. Number as Words
Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.



Examples:
numbers     number as words
0	        Zero
9	        Nine
10	        Ten
12	        Twelve
19	        Nineteen
25	        Twenty five
98	        Ninety eight
98      	Ninety eight
273	        Two hundred and seventy three
400	        Four hundred
501	        Five hundred and one
617	        Six hundred and seventeen
711	        Seven hundred and eleven
999	        Nine hundred and ninety nine
*/

using System;

namespace Problem_11._Number_as_Words
{
    class Problem_11
    {
        static void Main(string[] args)
        {
            // input **********************************************
            Console.WriteLine("Problem 11. Numbers as Words");

            Console.Write("number: ");

                // input number
            int number = int.Parse(Console.ReadLine());

                // strings to be used in the number-words translation
            string[] listOnes = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] listTeens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] listTens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                // digit of the hundreds
            int hundreds = (int)(number / 100 % 10);

                // digit of the tens
            int tens = (int)(number / 10 % 10);

                // digit of the ones
            int ones = (int)(number % 10);

                // last 2 digits (tens and ones)
            int tenOne = tens * 10 + ones;

                // string to keep the result
            string result = "";

            // calculation **********************************************
            
                // check only for hundreds
            if ((hundreds > 0) && (tenOne > 0)) 
            {
                result += $"{listOnes[hundreds]} hundred and ";
            }
            else if (hundreds > 0)
            {
                result += $"{listOnes[hundreds]} hundred";
            }

                // check for tens and ones
            if ((tenOne < 10) && (tenOne != 0)) // only ones present
            {
                result += $"{listOnes[ones]}";
            }
            else if ((tenOne >= 10) && (tenOne < 20)) // only teens present
            {
                result += $"{listTeens[(tenOne - 10)]}";
            }
            else if ((tenOne >= 20) && (ones == 0)) // only tens present
            {
                result += $"{listTens[(tens - 2)]}"; 
            }
            else if ((tenOne >= 20) && (ones > 0))  // tens and ones present
            {
                result += $"{listTens[(tens - 2)]} {listOnes[ones]}";
            }

                // capitalize first letter
            result = char.ToUpper(result[0]) + result.Substring(1);

            // output **********************************************
            Console.WriteLine($"result: {result}");

        }
    }
}
