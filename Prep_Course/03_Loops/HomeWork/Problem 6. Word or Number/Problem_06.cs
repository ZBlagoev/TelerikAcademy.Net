/*
Problem 6. Word or Number
Write a program that reads text from the console. Check if this text is 
a number or a word. If the text is a word print it reversed on the console. 
If it is a number add 1 to it and print it.

The input is text on a single line (without intervals).
If the input is a word it won't contain any digits!
The output is like in the examples below.
*/

using System;
using System.Linq;

namespace Problem_6._Word_or_Number
{
    class Problem_06
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 6. Word or Number");

            Console.Write("input: ");
            
            string input = Console.ReadLine();

            double number;
            bool isNum = Double.TryParse(input, out number);
            bool containsInt = input.Any(char.IsDigit);

            string result = "";

            // calculation
            if (isNum)
            {
                result = $"{number += 1}";
            }
            else if (!containsInt)
            {
                for (int i = input.Length; i > 0 ; i--)
                {
                    result += input[i-1];
                }

            } 
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                    {
                        result = input[i].ToString();
                        number += double.Parse(result);
                    }
                }
                result = $"{number + 1}";
            }

            // output
            Console.WriteLine($"result: {result}");

        }
    }
}
