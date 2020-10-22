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
            // input 
            int number = int.Parse(Console.ReadLine());

            string[] listof = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            

            int hundreds = (int)(number / 100 % 10);
            int tens = (int)(number / 10 % 10);
            int ones = (int)(number % 10);

            Console.WriteLine(listof[hundreds]);

            /*
            // calculation
            if (hundreds > 0)
            {
                listof[3];
            }
            */

            // output
            Console.WriteLine(hundreds);
            Console.WriteLine(tens);
            Console.WriteLine(ones);
        }
    }
}
